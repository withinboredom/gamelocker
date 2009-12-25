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

namespace Configurator
{
    public class TimeLogFactory
    {
        public static void saveLog(ITimeLog log)
        {
            log.saveLog();
        }

        public static ITimeLog loadLog(string filename)
        {
            TimeLogV1 log = new TimeLogV1(filename);
            log.loadLog();
            return log;
        }
    }
}
