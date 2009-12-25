/*This file is part of GameLocker.

    Foobar is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Configurator
{
    public class CheckedOutGame : Game
    {
        Process proc;
        string unlock;
        Game oldGame;
        TimeSpan playedThisSession = new TimeSpan();

        public CheckedOutGame(Game game)
        {
            this._filename = game.FileName;
            this._gameName = game.GameName;
        }

        public new CheckedOutGame CheckOut()
        {
            return null;
        }

        public CheckedOutGame(Game game, ProcessStartInfo info, string unlocked)
        {
            this._gameName = game.GameName;
            this._filename = game.FileName;
            timeLog = TimeLogFactory.loadLog(_filename);
            timeLog.getTotalTime();
            proc = Process.Start(info);
            unlock = unlocked;
            oldGame = game;
            if (proc.StartTime != null)
            {
                timeLog.startNewSession(proc.StartTime);
                usingDetailedTime = true;
            }
            else
            {
                timeLog.startNewSession(DateTime.Now);
                usingDetailedTime = false;
            }
            checkedout = true;
        }

        private bool usingDetailedTime;

        public bool hasExited()
        {
            return proc.HasExited;
        }

        public TimeSpan SessionTime()
        {
            //totalTimePlayed = (DateTime.Now - proc.StartTime);
            playedThisSession = (DateTime.Now - proc.StartTime);
            //return totalTimePlayed;
            return playedThisSession;
        }

        public TimeSpan LiveTotalTime()
        {
            return timeLog.currentSessionTotalTime();
        }

        public Game thisGame
        {
            get
            {
                return oldGame;
            }
        }

        public bool checkedout = false;

        public Game CheckIn(bool emergency)
        {
            lockerSettings settings = new lockerSettings();
            //alert the user of its death
            if (!emergency)
            proc.WaitForExit((int)settings.checkInWait.TotalMilliseconds);

            while (!proc.HasExited)
            {
                proc.Kill();
                proc.WaitForExit(10000);
            }
            if (!timeLog.detectedLogError() || usingDetailedTime)
                timeLog.endSession(proc.ExitTime);
            else if (timeLog.detectedLogError())
            {
                timeLog.addNewSession(proc.StartTime, proc.ExitTime);
            }
            else
            {
                //forget this session
            }
            locker.removeFile(unlock);
            TimeLogFactory.saveLog(timeLog);
            settings.lastTry = DateTime.Now;
            checkedout = false;
            settings.Save();
            return this;
        }
    }
}
