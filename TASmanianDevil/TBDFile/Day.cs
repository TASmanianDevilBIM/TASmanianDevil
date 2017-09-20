using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Day
    /// </summary>
    public class Day
    {
        private TBD.day pDay;

        internal Day(TBD.day Day)
        {
            pDay = Day;
        }

        /// <summary>
        /// Day Type of TAS Day
        /// </summary>
        /// <param name="Day">Day</param>
        /// <returns name="DayType">DayType</returns>
        /// <search>
        /// TAS, Day, day, DayType, daytype, DayType, description
        /// </search>
        public static DayType DayType(Day Day)
        {
            return new DayType(Day.pDay.dayType);
        }

        /// <summary>
        /// Sets Day Type of TAS Day
        /// </summary>
        /// <param name="Day">Day</param>
        /// <param name="DayType">Day Type</param>
        /// <returns name="Day">Day</returns>
        /// <search>
        /// TAS, Day, day, DayType, daytype, DayType, description, SetDayType, Set Day Type, setdaytype
        /// </search>
        public static Day SetDayType(Day Day, DayType DayType)
        {
            Day.pDay.dayType = DayType.pDayType;
            return Day;
        }
    }
}
