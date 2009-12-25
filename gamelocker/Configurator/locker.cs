/* Copyright 2009, 2010 (C) Robert Landers (landers.robert@gmail.com)

    GameLocker is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    GameLocker is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with GameLocker.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;

namespace Configurator
{
    public static class locker
    {
        [System.Runtime.InteropServices.DllImport("KERNEL32.dll",EntryPoint="RtlZeroMemory")]
        public static extern bool zeroMemory(ref string destination, int length);

        public static string lockFile(string filename)
        {
            encryptFile(filename, filename);
            lockerSettings settings = new lockerSettings();
            settings.Reload();
            settings.fileList.Add(filename);
            settings.Save();
            return filename;
        }

        public static void unlockAllFiles()
        {
            lockerSettings settings = new lockerSettings();
            foreach (string file in settings.fileList)
            {
                decryptFile(file, file + ".dec", file);
                File.Copy(file + ".dec", file, true);
                File.Delete(file + ".key");
                File.Delete(file + ".t");
                File.Delete(file + ".dec");
            }
            settings.Reset();
            settings.fileList.Clear();
            settings.fileMap.Clear();
        }

        public static string useFile(string filename)
        {
            File.Copy(filename, filename + ".enc");
            decryptFile(filename + ".enc", filename, filename);
            return filename;
        }

        public static bool removeFile(string unlocked)
        {
            FileInfo info = new FileInfo(unlocked);
            try
            {
                info.Delete();
            }
            catch (System.UnauthorizedAccessException)
            {
                return false;
            }
            catch (System.Security.SecurityException)
            {
                return false;
            }
            catch (System.IO.IOException)
            {
                return false;
            }

            File.Copy(unlocked + ".enc", unlocked);
            File.Delete(unlocked + ".enc");

            return true;
        }

        private static void encryptFile(string filename, string keyFile)
        {
            //set up the file stream to save the encrypted file
            FileStream fsOut;
            try
            {
                fsOut = new FileStream(filename + ".enc", FileMode.Create, FileAccess.Write);
            }
            catch
            {
                File.Delete(filename + ".enc");
                fsOut = new FileStream(filename + ".enc", FileMode.Create, FileAccess.Write);
            }
            if (fsOut == null)
                throw new Exception("Unable to open file for Encryption.  Is it running?");
            //create a crypto provider
            TripleDESCryptoServiceProvider algo = new TripleDESCryptoServiceProvider();
            //create an encrypted file stream
            CryptoStream csenc = new CryptoStream(fsOut, algo.CreateEncryptor(), CryptoStreamMode.Write);
            //create the writer to the encrypted file stream
            BinaryWriter encStream = new BinaryWriter(csenc);
            //create the reader from the original file
            BinaryReader decStream = new BinaryReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
            try
            {
                byte currline = decStream.ReadByte();
                while (true)
                {
                    encStream.Write(currline);
                    currline = decStream.ReadByte();
                }

                
            }
            catch (System.IO.EndOfStreamException)
            {
            }
            finally
            {
                decStream.Close();
                encStream.Flush();
                encStream.Close();

                saveKey(filename, algo.Key, algo.IV);

                File.Delete(filename);
                File.Copy(filename + ".enc", filename);
                File.Delete(filename + ".enc");
            }
        }

        public static string getWorkingDirectory(string filename)
        {
            return Path.GetDirectoryName(filename);
        }

        public static string getFile(string filename)
        {
            return Path.GetFileNameWithoutExtension(filename);
        }

        public static string homeDir
        {
            get
            {
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string ret = dir + "\\RLanders\\Locker\\";
                if (Directory.Exists(ret))
                    return ret;
                Directory.CreateDirectory(ret);
                return ret;
            }
        }

        private static void decryptFile(string filename, string newName, string keyFile)
        {
            //
            string home = homeDir;
            string work = getWorkingDirectory(filename);
            string file = getFile(filename);

            //create the filestream to the encrypted and decrypted files
            FileStream fsIn = new FileStream(filename, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(newName, FileMode.Create, FileAccess.Write);

            //set up the algorithm
            TripleDESCryptoServiceProvider algo = new TripleDESCryptoServiceProvider();
            algo.Key = readKey(keyFile);
            algo.IV = readIV(keyFile);

            //create the decryption stream
            CryptoStream csenc = new CryptoStream(fsIn, algo.CreateDecryptor(), CryptoStreamMode.Read);

            //create the reader
            BinaryReader br = new BinaryReader(csenc);
            //create the writer
            BinaryWriter bw = new BinaryWriter(fsOut);

            try
            {
                byte currline = br.ReadByte();
                while (true)
                {
                    bw.Write(currline);
                    currline = br.ReadByte();
                }
            }
            catch (System.IO.EndOfStreamException)
            {
            }
            finally
            {
                br.Close();
                bw.Flush();
                bw.Close();
                fsOut.Close();
            }
        }

        private static void saveKey(string filename, byte[] key, byte[] iv)
        {
            FileStream fsout = new FileStream(filename + ".key", FileMode.Create, FileAccess.Write);
            BinaryWriter bwFile = new BinaryWriter(fsout);
            bwFile.Write(key);
            bwFile.Write(iv);
            bwFile.Flush();
            bwFile.Close();
        }

        private static byte[] readKey(string filename)
        {
            FileStream fskey = new FileStream(filename + ".key", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fskey);
            byte[] ret = br.ReadBytes(24);
            br.Close();
            return ret;
        }

        private static byte[] readIV(string filename)
        {
            FileStream fskey = new FileStream(filename + ".key", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fskey);
            byte[] junk = br.ReadBytes(24);
            byte[] ret = br.ReadBytes(8);
            br.Close();
            return ret;
        }
    }
}
