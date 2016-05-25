using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Schedule
    /// </summary>
    public class Schedule
    {
        internal TBD.schedule pSchedule;

        internal Schedule(TBD.schedule Schedule)
        {
            pSchedule = Schedule;
        }

        /// <summary>
        /// TAS Schedule Name
        /// </summary>
        /// <param name="Schedule">Schedule</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Schedule, Name, name, schedule
        /// </search>
        public static string Name(Schedule Schedule)
        {
            return Schedule.pSchedule.name;
        }

        /// <summary>
        /// Sets Schedule Name
        /// </summary>
        /// <param name="Schedule">Schedule</param>
        /// <param name="Name">Schedule Name</param>
        /// <returns name="Schedule">Schedule</returns>
        /// <search>
        /// TAS, Schedule, Name, name, schedule, SetName
        /// </search>
        public static Schedule SetName(Schedule Schedule, string Name)
        {
            Schedule.pSchedule.name = Name;
            return Schedule;
        }

        /// <summary>
        /// TAS Schedule Description
        /// </summary>
        /// <param name="Schedule">Schedule</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, Schedule, Description, description, schedule
        /// </search>
        public static string Description(Schedule Schedule)
        {
            return Schedule.pSchedule.description;
        }

        /// <summary>
        /// Sets Schedule Description
        /// </summary>
        /// <param name="Schedule">Schedule</param>
        /// <param name="Description">Description</param>
        /// <returns name="Schedule">Schedule</returns>
        /// <search>
        /// TAS, Schedule, Description, description, schedule
        /// </search>
        public static Schedule SetDescription(Schedule Schedule, string Description)
        {
            Schedule.pSchedule.description = Description;
            return Schedule;
        }

        /// <summary>
        /// Sets Schedule Value
        /// </summary>
        /// <param name="Schedule">Schedule</param>
        /// <param name="Index">Index</param>
        /// <param name="Value">Value</param>
        /// <returns name="Schedule">Schedule</returns>
        /// <search>
        /// TAS, Schedule, Value, value, schedule
        /// </search>
        public static Schedule SetValue(Schedule Schedule, int Index, int Value)
        {
            Schedule.pSchedule.values[Index] = Value;
            return Schedule;
        }

        /// <summary>
        /// gets Schedule Value
        /// </summary>
        /// <param name="Schedule">Schedule</param>
        /// <param name="Index">Index</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Schedule, Value, value, schedule
        /// </search>
        public static int Value(Schedule Schedule, int Index)
        {
            return Schedule.pSchedule.values[Index];
        }
    }
}
