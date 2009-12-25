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

namespace Configurator
{
    public interface ITimeLog
    {
        bool loadLog();
        void saveLog();
        int Version();
        int SessionCount();
        TimeSpan getTotalTime();
        TimeSpan getSessionTime(int session);
        DateTime getSessionStartTime(int session);
        DateTime getSessionEndTime(int session);
        void addNewSession(DateTime startTime, DateTime endTime);
        void startNewSession(DateTime startTime);
        void endSession(DateTime endTime);
        TimeSpan currentSessionTime();
        TimeSpan currentSessionTotalTime();
        bool detectedLogError();
    }
}
