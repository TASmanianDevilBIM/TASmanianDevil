using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Design Day
    /// </summary>
    public class DesignDay
    {
        private TBD.DesignDay pDesignDay;

        internal DesignDay(TBD.DesignDay DesignDay)
        {
            pDesignDay = DesignDay;
        }

        /// <summary>
        /// TAS Design Day description
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <returns name="Desription">Design Day Description</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Desription, Design Day Descriprion, designdaydescriprion, 
        /// </search>
        public static string Desription(DesignDay DesignDay)
        {
            return DesignDay.pDesignDay.description;
        }

        /// <summary>
        /// TAS Design Day Name
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <returns name="Desription">Design Day Name</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Name, Design Day Name, designdayname, 
        /// </search>
        public static string Name(DesignDay DesignDay)
        {
            return DesignDay.pDesignDay.name;
        }

        /// <summary>
        /// TAS Design Day Repetitions
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <returns name="Repetitions">Repetitions</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Name, Design Day Name, designdayname, 
        /// </search>
        public static int Repetitions(DesignDay DesignDay)
        {
            return DesignDay.pDesignDay.repetitions;
        }

        /// <summary>
        /// TAS Design Day year day
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <returns name="YearDay">Year Day</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Year Day, Design Day Year Day, designdayyearday, 
        /// </search>
        public static int YearDay(DesignDay DesignDay)
        {
            return DesignDay.pDesignDay.yearDay;
        }

        /// <summary>
        /// Weather Day of Design Day
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <returns name="WeatherDay">Weather Day</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Year Day, Design Day Year Day, designdayyearday, 
        /// </search>
        public static WeatherDay GetWeatherDay(DesignDay DesignDay)
        {
            return new WeatherDay(DesignDay.pDesignDay.GetWeatherDay());
        }

        /// <summary>
        /// Gets Day Type of Design Day
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <returns name="DayType">Day Type</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Day Type, Design Day Name, designdaydaytype, DayType, daytype, getdaytype
        /// </search>
        public static DayType GetDayType(DesignDay DesignDay)
        {
            return new DayType(DesignDay.pDesignDay.GetDayType());
        }

        /// <summary>
        /// Sets Day Type of Design Day
        /// </summary>
        /// <param name="DesignDay">Design Day</param>
        /// <param name="DayType">Day Type</param>
        /// <returns name="DesignDay">Design Day</returns>
        /// <search>
        /// TAS, DesignDay, designday, Design Day, designday, Day Type, Design Day Name, designdaydaytype, DayType, daytype, setdaytype
        /// </search>
        public static int SetDayType(DesignDay DesignDay, DayType DayType)
        {
            return DesignDay.pDesignDay.SetDayType(DayType.pDayType);
        }
    }
}
