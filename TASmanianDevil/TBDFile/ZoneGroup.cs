using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Zone Group
    /// </summary>
    public class ZoneGroup
    {
        private TBD.ZoneGroup pZoneGroup;

        internal ZoneGroup(TBD.ZoneGroup ZoneGroup)
        {
            pZoneGroup = ZoneGroup;
        }

        /// <summary>
        /// Insert Zone to Group
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Interger">Interger</returns>
        /// <search>
        /// TAS, InsertZone, insertzone, ZoneGroup, zone group
        /// </search>
        public static int InsertZone(ZoneGroup ZoneGroup, Zone Zone)
        {
            return ZoneGroup.pZoneGroup.InsertZone(Zone.pZone);
        }

        /// <summary>
        /// Zone Group Description
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <returns name="Description">Zone Group Description</returns>
        /// <search>
        /// TAS, Zone Group, Description, zone group, description
        /// </search>
        public static string Description(ZoneGroup ZoneGroup)
        {
            return ZoneGroup.pZoneGroup.description;
        }

        /// <summary>
        /// Set Zone Group Description
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Description">Description</param>
        /// <returns name="ZoneGroup">Zone Group</returns>
        /// <search>
        /// TAS, Zone Group, Description, zone group, description, SetDescription
        /// </search>
        public static ZoneGroup SetDescription(ZoneGroup ZoneGroup, string Description)
        {
            ZoneGroup.pZoneGroup.description = Description;
            return ZoneGroup;
        }

        /// <summary>
        /// Zone Group Cooling Design Factor
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <returns name="Factor">Cooling Design Factor</returns>
        /// <search>
        /// TAS, Zone Group, Cooling Design Factor, zone group, cooling design factor, coolingdesignfactor
        /// </search>
        public static float CoolingDesignFactor(ZoneGroup ZoneGroup)
        {
            return ZoneGroup.pZoneGroup.coolingDesignFactor;
        }

        /// <summary>
        /// Set Zone Group Cooling Design Factor
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Value">Cooling Design Factor Value</param>
        /// <returns name="Factor">Cooling Design Factor</returns>
        /// <search>
        /// TAS, Zone Group, Cooling Design Factor, zone group, cooling design factor, coolingdesignfactor, SetCoolingDesignFactor
        /// </search>
        public static ZoneGroup SetCoolingDesignFactor(ZoneGroup ZoneGroup, float Value)
        {
            ZoneGroup.pZoneGroup.coolingDesignFactor = Value;
            return ZoneGroup;
        }

        /// <summary>
        /// Gets group from Zone Group
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Index">Zone Index</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone Group, Zone, zone group, zone, getzone
        /// </search>
        public static Zone GetZone(ZoneGroup ZoneGroup, int Index)
        {
            return new Zone(ZoneGroup.pZoneGroup.GetZone(Index));
        }

        /// <summary>
        /// Gets TAS Zone Group zones
        /// </summary>
        /// <param name="ZoneGroup">TAS Zone Group</param>
        /// <returns name="Zones">Zone List</returns>
        /// <search>
        /// TAS, ZoneGroup, Zones, Get Zones, tas, builidng, zones, get zones
        /// </search>
        public static List<Zone> Zones(ZoneGroup ZoneGroup)
        {
            List<Zone> aZoneList = new List<Zone>();

            int aIndex = 0;
            TBD.zone aZone = ZoneGroup.pZoneGroup.GetZone(aIndex);
            while (aZone != null)
            {
                aZoneList.Add(new Zone(aZone));
                aIndex++;
                aZone = ZoneGroup.pZoneGroup.GetZone(aIndex);
            }
            return aZoneList;
        }

        /// <summary>
        /// Zone Group Heating Design Factor
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <returns name="Factor">Heating Design Factor</returns>
        /// <search>
        /// TAS, Zone Group, Heating Design Factor, zone group, heating design factor
        /// </search>
        public static float HeatingDesignFactor(ZoneGroup ZoneGroup)
        {
            return ZoneGroup.pZoneGroup.heatingDesignFactor;
        }

        /// <summary>
        /// Set Zone Group Heating Design Factor
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Value">Heating Design Factor Value</param>
        /// <returns name="ZoneGroup">Zone Group</returns>
        /// <search>
        /// TAS, Zone Group, Heating Design Factor, zone group, heating design factor, SetHeatingDesignFactor
        /// </search>
        public static ZoneGroup SetHeatingDesignFactor(ZoneGroup ZoneGroup, float Value)
        {
            ZoneGroup.pZoneGroup.heatingDesignFactor = Value;
            return ZoneGroup;
        }

        /// <summary>
        /// Zone Group Name
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <returns name="Name">Zone Group Name</returns>
        /// <search>
        /// TAS, Zone Group, Name, zone group, name
        /// </search>
        public static string Name(ZoneGroup ZoneGroup)
        {
            return ZoneGroup.pZoneGroup.name;
        }

        /// <summary>
        /// Set Zone Group Name
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Name">Name</param>
        /// <returns name="Name">Zone Group Name</returns>
        /// <search>
        /// TAS, Zone Group, Name, zone group, name, SetName
        /// </search>
        public static ZoneGroup SetName(ZoneGroup ZoneGroup, string Name)
        {
            ZoneGroup.pZoneGroup.name = Name;
            return ZoneGroup;
        }

        ///// <summary>
        ///// Zone Group Peak Cooling
        ///// </summary>
        ///// <param name="ZoneGroup">TAS ZoneGroup</param>
        ///// <returns name="PeakCooling">Zone Group Peak Cooling</returns>
        ///// <search>
        ///// TAS, Zone Group, Peeak Cooling, zone group, peak cooling, peakcooling
        ///// </search>
        //public static float PeakCooling(ZoneGroup ZoneGroup)
        //{
        //    return ZoneGroup.pZoneGroup.peakCooling;
        //}

        ///// <summary>
        ///// Set Zone Group Peak Cooling
        ///// </summary>
        ///// <param name="ZoneGroup">TAS ZoneGroup</param>
        ///// <param name="Value">Peak Cooling Value</param>
        ///// <returns name="ZoneGroup">Zone Group</returns>
        ///// <search>
        ///// TAS, Zone Group, Peeak Cooling, zone group, peak cooling, peakcooling, SetPeakCooling
        ///// </search>
        //public static ZoneGroup SetPeakCooling(ZoneGroup ZoneGroup, float Value)
        //{
        //    ZoneGroup.pZoneGroup.peakCooling = Value;
        //    return ZoneGroup;
        //}

        ///// <summary>
        ///// Zone Group Peak Heating
        ///// </summary>
        ///// <param name="ZoneGroup">TAS ZoneGroup</param>
        ///// <returns name="PeakHeating">Zone Group Peak Heating</returns>
        ///// <search>
        ///// TAS, Zone Group, Peak Heating, zone group, peak heating, peakheating
        ///// </search>
        //public static float PeakHeating(ZoneGroup ZoneGroup)
        //{
        //    return ZoneGroup.pZoneGroup.peakHeating;
        //}

        ///// <summary>
        ///// Set Zone Group Peak Heating
        ///// </summary>
        ///// <param name="ZoneGroup">TAS ZoneGroup</param>
        ///// <param name="Value">Peak Heating Value</param>
        ///// <returns name="ZoneGroup">Zone Group</returns>
        ///// <search>
        ///// TAS, Zone Group, Peak Heating, zone group, peak heating, peakheating, SetPeakHeating
        ///// </search>
        //public static ZoneGroup SetPeakHeating(ZoneGroup ZoneGroup, float Value)
        //{
        //    ZoneGroup.pZoneGroup.peakHeating = Value;
        //    return ZoneGroup;
        //}

        /// <summary>
        /// Zone Group Type
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <returns name="Type">Zone Group Type</returns>
        /// <search>
        /// TAS, Zone Group, Type, zone group, type
        /// </search>
        public static int Type(ZoneGroup ZoneGroup)
        {
            return ZoneGroup.pZoneGroup.type;
        }

        /// <summary>
        /// Set Zone Group Type
        /// </summary>
        /// <param name="ZoneGroup">TAS ZoneGroup</param>
        /// <param name="Value">Type Value</param>
        /// <returns name="ZoneGroup">Zone Group</returns>
        /// <search>
        /// TAS, Zone Group, Type, zone group, type, SetType
        /// </search>
        public static ZoneGroup SetType(ZoneGroup ZoneGroup, int Value)
        {
            ZoneGroup.pZoneGroup.type = Value;
            return ZoneGroup;
        }
    }
}
