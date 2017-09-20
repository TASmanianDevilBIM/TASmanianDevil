using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Calendar
    /// </summary>
    public class Calendar
    {
        private TBD.Calendar pCalendar;

        internal Calendar(TBD.Calendar Calendar)
        {
            pCalendar = Calendar;
        }

        /// <summary>
        /// TAS Calendar Description
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <returns name="Description">Calendar Description</returns>
        /// <search>
        /// TAS, Calendar, calendar, Description, description
        /// </search>
        public static string Description(Calendar Calendar)
        {
            return Calendar.pCalendar.description;
        }

        /// <summary>
        /// Sets TAS Calendar Description
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <param name="Description">Description</param>
        /// <returns name="Calendar">Calendar</returns>
        /// <search>
        /// TAS, Calendar, calendar, Description, description, SetDescription, setdescription, Set Description, set description
        /// </search>
        public static Calendar SetDescription(Calendar Calendar, string Description)
        {
            Calendar.pCalendar.description = Description;
            return Calendar;
        }

        /// <summary>
        /// Adds new day type to the calendar
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <returns name="DayType">Day Type</returns>
        /// <search>
        /// TAS, Calendar, calendar, DayType, daytype, AddDayType, Add Day Type, adddaytype, add day type
        /// </search>
        public static DayType AddDayType(Calendar Calendar)
        {
            return new DayType( Calendar.pCalendar.AddDayType());
        }

        /// <summary>
        /// Gets TAS Calendar Day
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <param name="Index">Index</param>
        /// <returns name="Day">Calendar Day</returns>
        /// <search>
        /// TAS, Calendar, calendar, Day, day, GetDay, getday, get day
        /// </search>
        public static Day Day(Calendar Calendar, int Index)
        {
            return new Day(Calendar.pCalendar.days(Index));
        }

        /// <summary>
        /// Get TAS Calendar Day Type (Starting from 1)
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <param name="Index">Index</param>
        /// <returns name="DayType">Calendar Day Type</returns>
        /// <search>
        /// TAS, Calendar, calendar, DayType, Day Type, day type, daytype, GetDayType
        /// </search>
        public static DayType GetDayType(Calendar Calendar, int Index)
        {
            return new DayType(Calendar.pCalendar.dayTypes(Index));
        }

        /// <summary>
        /// Gets all TAS Calendar Day Types
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <returns name="DayType">Calendar Day Type</returns>
        /// <search>
        /// TAS, Calendar, calendar, DayType, Day Type, day type, daytype
        /// </search>
        public static List<DayType> DayTypes(Calendar Calendar)
        {
            List<DayType> aDayTypeList = new List<DayType>();
            int aCount = Calendar.pCalendar.GetDayTypeCount();
            for (int i = 1; i <= aCount; i++)
                aDayTypeList.Add(new DayType(Calendar.pCalendar.dayTypes(i)));
            return aDayTypeList;
        }

        /// <summary>
        /// Gets count of Day Type in TAS Calendar
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <returns name="Count">Day Type Count</returns>
        /// <search>
        /// TAS, Calendar, calendar, DayTypeCount, Day Type Count, daytypecount, day type count
        /// </search>
        public static int DayTypeCount(Calendar Calendar)
        {
            return Calendar.pCalendar.GetDayTypeCount();
        }

        /// <summary>
        /// TAS Calendar Name
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <returns name="Name">Calendar Name</returns>
        /// <search>
        /// TAS, Calendar, calendar, Name, name
        /// </search>
        public static string Name(Calendar Calendar)
        {
            return Calendar.pCalendar.name;
        }

        /// <summary>
        /// Sets TAS Calendar Name
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <param name="Name">Name</param>
        /// <returns name="Calendar">Calendar</returns>
        /// <search>
        /// TAS, Calendar, calendar, Name, name, Setname, setdescription, Set name, set name
        /// </search>
        public static Calendar SetName(Calendar Calendar, string Name)
        {
            Calendar.pCalendar.name = Name;
            return Calendar;
        }

        /// <summary>
        /// Removes TAS Calendar Day Type
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <param name="Index">Index</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, Calendar, calendar, RemoveDayType, Remove Day Type, removedaytype
        /// </search>
        public static int RemoveDayType(Calendar Calendar, int Index)
        {
            return Calendar.pCalendar.RemoveDayType(Index);
        }

        /// <summary>
        /// TAS Calendar Start Day
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <returns name="StartDay">Calendar Start Day</returns>
        /// <search>
        /// TAS, Calendar, calendar, StartDay, Start Day, startday, start day
        /// </search>
        public static int StartDay(Calendar Calendar)
        {
            return Calendar.pCalendar.startDay;
        }

        /// <summary>
        /// Sets TAS Calendar Start Day
        /// </summary>
        /// <param name="Calendar">Calendar</param>
        /// <param name="StartDay">Start Day</param>
        /// <returns name="Calendar">Calendar</returns>
        /// <search>
        /// TAS, Calendar, calendar, StartDay, Start Day, startday, start day, SetStartDay, Set Start Day, setstartday
        /// </search>
        public static Calendar SetStartDay(Calendar Calendar, int StartDay)
        {
            Calendar.pCalendar.startDay = StartDay;
            return Calendar;
        }
    }
}
