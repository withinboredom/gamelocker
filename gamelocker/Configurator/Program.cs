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
using System.Windows.Forms;
using System.Configuration;

namespace Configurator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if (arg == "uninstall")
                {
                    locker.unlockAllFiles();
                    Application.Exit();
                }
            }
            //initialize Application
            lockerSettings settings = new lockerSettings();
            settings.Reset();
            if (settings.fileMap.Count > 0 && settings.fileMap[0] == "begin")
            {
                settings.fileMap.Clear();
                settings.fileList.Clear();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new OptionsForm());
                settings.Save();
                Application.Restart();
            }
            else
            {
                SettingsSystem.init();
                SettingsSystem.Sync();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PlayGame());
            }
        }
    }
}
