/*This file is part of GameLocker.

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
using System.IO;

namespace Configurator
{
    public class TimeLogV1 : ITimeLog
    {
        protected List<TimeSpan> sessionTotalTimes = new List<TimeSpan>();
        protected List<DateTime> sessionStartTimes = new List<DateTime>();
        protected List<DateTime> sessionEndTimes = new List<DateTime>();
        protected TimeSpan totalTime;
        protected bool inSession;

        protected string filename;

        public TimeLogV1(string filename)
        {
            this.filename = filename;
        }

        public void addNewSession(DateTime startTime, DateTime endTime)
        {
            sessionEndTimes.Add(endTime);
            sessionStartTimes.Add(startTime);
            sessionTotalTimes.Add(endTime - startTime);
            totalTime += endTime - startTime;
        }

        public bool detectedLogError()
        {
            if (sessionStartTimes.Count == sessionTotalTimes.Count)
                return true;
            else return false;
        }

        public void saveLog()
        {
            if (!inSession)
            {
                //recalc totaltime
                totalTime = new TimeSpan();
                foreach (TimeSpan sessiontime in sessionTotalTimes)
                {
                    totalTime += sessiontime;
                }

                FileStream fsout = new FileStream(filename + ".t", FileMode.Create, FileAccess.Write);
                BinaryWriter bwFile = new BinaryWriter(fsout);
                //write the version number
                bwFile.Write(this.Version());
                bwFile.Write(totalTime.Ticks);
                bwFile.Write(sessionStartTimes.Count);
                for (int i = 0; i < sessionStartTimes.Count; i++)
                {
                    bwFile.Write(sessionTotalTimes[i].Ticks);
                    bwFile.Write(sessionStartTimes[i].Ticks);
                    bwFile.Write(sessionEndTimes[i].Ticks);
                }
                bwFile.Flush();
                bwFile.Close();
            }
            else
            {
                throw new InSessionException("Cannot save while in session");
            }
        }

        public void startNewSession(DateTime startTime)
        {
            inSession = true;
            sessionStartTimes.Add(startTime);
        }

        public void endSession(DateTime endTime)
        {
            inSession = false;
            sessionEndTimes.Add(endTime);
            sessionTotalTimes.Add(sessionEndTimes[sessionEndTimes.Count - 1] - sessionStartTimes[sessionStartTimes.Count - 1]);
            totalTime += sessionTotalTimes[sessionTotalTimes.Count - 1];
        }

        public TimeSpan currentSessionTime()
        {
            if (inSession)
            {
                return (DateTime.Now - sessionStartTimes[sessionStartTimes.Count - 1]);
            }
            else
            {
                return new TimeSpan();
            }
        }

        public TimeSpan currentSessionTotalTime()
        {
            if (inSession)
            {
                return (currentSessionTime() + totalTime);
            }
            else return totalTime;
        }

        public bool loadLog()
        {
            if (File.Exists(filename + ".t"))
            {
                int version;
                int sessionCount;
                long totalTime;
                
                FileStream fskey = new FileStream(filename + ".t", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fskey);
                try
                {
                    //read in the version
                    version = br.ReadInt32();
                    //check version
                    if (version != 1)
                    {
                        br.Close();
                        return false;
                    }
                    //get total time
                    totalTime = br.ReadInt64();
                    this.totalTime = new TimeSpan(totalTime);

                    //get session count
                    sessionCount = br.ReadInt32();

                    //get session times
                    for (int i = 0; i < sessionCount; i++)
                    {
                        this.sessionTotalTimes.Add(new TimeSpan(br.ReadInt64()));
                        this.sessionStartTimes.Add(new DateTime(br.ReadInt64()));
                        this.sessionEndTimes.Add(new DateTime(br.ReadInt64()));
                    }
                }
                catch (EndOfStreamException)
                {
                    br.Close();
                    return false;
                }
                br.Close();
                return true;
            }
            else
                return false;
        }

        public int SessionCount()
        {
            return sessionEndTimes.Count;
        }

        public TimeSpan getTotalTime()
        {
            return totalTime;
        }

        public DateTime getSessionEndTime(int session)
        {
            return sessionEndTimes[session];
        }

        public DateTime getSessionStartTime(int session)
        {
            return sessionStartTimes[session];
        }

        public TimeSpan getSessionTime(int session)
        {
            return sessionTotalTimes[session];
        }

        public int Version()
        {
            return 1;
        }
    }
}
