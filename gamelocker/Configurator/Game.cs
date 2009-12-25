/* Copyright 2009, 2010 (C) Robert Landers (landers.robert@gmail.com)
 * 
 * This file is part of GameLocker.
 * 
 * GameLocker is free software: you can redistribute it and/or modify 
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * GameLocker is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with GameLocker.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Configurator
{
    public class Game
    {
        protected string _gameName;
        protected string _filename;
        protected ITimeLog timeLog;

        public override string ToString()
        {
            return _gameName;
        }

        public TimeSpan WhatIsTotalTime
        {
            get
            {
                return timeLog.getTotalTime();
            }
        }

        public Game(string game, string filename)
        {
            _gameName = game;
            _filename = filename;
            timeLog = TimeLogFactory.loadLog(filename);
        }

        public Game()
        {
        }

        public string GameName
        {
            get
            {
                return _gameName;
            }
        }

        public string FileName
        {
            get
            {
                return _filename;
            }
        }

        public CheckedOutGame CheckOut()
        {
            string unlocked = locker.useFile(_filename);
            ProcessStartInfo info = new ProcessStartInfo(unlocked);
            return new CheckedOutGame(this, info, unlocked);
        }
    }
}
