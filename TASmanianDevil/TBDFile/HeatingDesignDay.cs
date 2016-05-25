using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Heating Design Day
    /// </summary>
    public class HeatingDesignDay
    {
        private TBD.HeatingDesignDay pHeatingDesignDay;

        internal HeatingDesignDay(TBD.HeatingDesignDay HeatingDesignDay)
        {
            pHeatingDesignDay = HeatingDesignDay;
        }

        /// <summary>
        /// TBD Heating Design Day Description
        /// </summary>
        /// <param name="HeatingDesignDay">Heating Design Day</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, HeatingDesignDay, Description, HeatingDesignDay, description, Heating Design Day, Heating design day
        /// </search>
        public static string Description(HeatingDesignDay HeatingDesignDay)
        {
            return HeatingDesignDay.pHeatingDesignDay.description;
        }

        /// <summary>
        /// TBD Heating Design Day Name
        /// </summary>
        /// <param name="HeatingDesignDay">Heating Design Day</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, HeatingDesignDay, Name, HeatingDesignDay, name, Heating Design Day, Heating design day
        /// </search>
        public static string Name(HeatingDesignDay HeatingDesignDay)
        {
            return HeatingDesignDay.pHeatingDesignDay.name;
        }

        /// <summary>
        /// TBD Heating Design Day GUID
        /// </summary>
        /// <param name="HeatingDesignDay">Heating Design Day</param>
        /// <returns name="GUID">GUID</returns>
        /// <search>
        /// TAS, HeatingDesignDay, GUID, HeatingDesignDay, guid, Heating Design Day, Heating design day
        /// </search>
        public static string GUID(HeatingDesignDay HeatingDesignDay)
        {
            return HeatingDesignDay.pHeatingDesignDay.GUID;
        }

        /// <summary>
        /// Gets Design Day from Heating Design Day
        /// </summary>
        /// <param name="HeatingDesignDay">Heating Design Day</param>
        /// <param name="Index">Design Day Index</param>
        /// <returns name="DesignDay">Design Day</returns>
        /// <search>
        /// TAS, HeatingDesignDay, Design Day, HeatingDesignDay, design day, Heating Design Day, Heating design day, getdesignday, get design day
        /// </search>
        public static DesignDay GetDesignDay(HeatingDesignDay HeatingDesignDay, int Index)
        {
            return new DesignDay(HeatingDesignDay.pHeatingDesignDay.GetDesignDay(Index));
        }

        /// <summary>
        /// gets Design Days from Heating Design Day 
        /// </summary>
        /// <param name="HeatingDesignDay">Heating Design Day</param>
        /// <returns name="DesignDays">Design Day List</returns>
        /// <search>
        /// TAS, HeatingDesignDay, Design Day, HeatingDesignDay, design day, Heating Design Day, Heating design day, designdays, design days
        /// </search>
        public static List<DesignDay> DesignDays(HeatingDesignDay HeatingDesignDay)
        {
            List<DesignDay> aDesignDayList = new List<DesignDay>();

            int aIndex = 0;
            TBD.DesignDay aDesignDay = HeatingDesignDay.pHeatingDesignDay.GetDesignDay(aIndex);
            while (aDesignDay != null)
            {
                aDesignDayList.Add(new DesignDay(aDesignDay));
                aIndex++;
                aDesignDay = HeatingDesignDay.pHeatingDesignDay.GetDesignDay(aIndex);
            }
            return aDesignDayList;
        }
    }
}
