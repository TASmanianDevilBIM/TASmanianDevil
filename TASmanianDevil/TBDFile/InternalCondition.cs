using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Internal Condition
    /// </summary>
    public class InternalCondition
    {
        internal TBD.InternalCondition pInternalCondition;

        internal InternalCondition(TBD.InternalCondition InternalCondition)
        {
            pInternalCondition = InternalCondition;
        }

        /// <summary>
        /// Gets TAS Internal Condition Name
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Name, tas, internalcondition,  get internal condition name
        /// </search>
        public static string Name(InternalCondition InternalCondition)
        {
            return InternalCondition.pInternalCondition.name;
        }

        /// <summary>
        /// Gets TAS Internal Condition Description
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Description, tas, internalcondition,  get internal condition description
        /// </search>
        public static string Description(InternalCondition InternalCondition)
        {
            return InternalCondition.pInternalCondition.description;
        }

        /// <summary>
        /// Gets TAS Internal Condition Zones
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="Zones">Zone List</returns>
        /// <search>
        /// TAS, InternalCondition, Zones, Get Zones, tas, internalcondition, zones, get zones, Internal Condition
        /// </search>
        public static List<Zone> Zones(InternalCondition InternalCondition)
        {
            List<Zone> aZoneList = new List<Zone>();

            int aIndex = 0;
            TBD.zone aZone = InternalCondition.pInternalCondition.GetZone(aIndex);
            while (aZone != null)
            {
                aZoneList.Add(new Zone(aZone));
                aIndex++;
                aZone = InternalCondition.pInternalCondition.GetZone(aIndex);
            }
            return aZoneList;
        }

        /// <summary>
        /// Gets TAS Internal Condition zone
        /// </summary>
        /// <param name="InternalCondition">TAS Building</param>
        /// <param name="Index">zone index</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, InternalCondition, Zone, Get Zone tas, internalcondition, zone, get zone, Internal Condition
        /// </search>
        public static Zone GetZone(InternalCondition InternalCondition, int Index)
        {
            return new Zone(InternalCondition.pInternalCondition.GetZone(Index));
        }

        /// <summary>
        /// Gets Include Solar In MRT for Internal Condition
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="IncludeSolarInMRT">IncludeSolarInMRT</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition IncludeSolarInMRT, tas, internalcondition,  get internal condition Include Solar In MRT, includesolarinmrt
        /// </search>
        public static int IncludeSolarInMRT(InternalCondition InternalCondition)
        {
            return InternalCondition.pInternalCondition.includeSolarInMRT;
        }

        /// <summary>
        /// Sets Include Solar In MRT for Internal Condition
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <param name="Value">Value for Include Solar In MRT parameter</param>
        /// <returns name="InternalCondition">InternalCondition</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition IncludeSolarInMRT, tas, internalcondition,  get internal condition Include Solar In MRT, includesolarinmrt, setincludesolarinmrt
        /// </search>
        public static InternalCondition SetIncludeSolarInMRT(InternalCondition InternalCondition, int Value)
        {
            InternalCondition.pInternalCondition.includeSolarInMRT = Value;
            return InternalCondition;
        }

        /// <summary>
        /// Gets Cooling Emitter for Internal Condition
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Cooling Emitter, tas, internalcondition,  get internal condition cooling emitter, GetCoolingEmitter, getcoolingemitter
        /// </search>
        public static Emitter GetCoolingEmitter(InternalCondition InternalCondition)
        {
            return new Emitter(InternalCondition.pInternalCondition.GetCoolingEmitter());
        }

        /// <summary>
        /// Gets Heating Emitter for Internal Condition
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Heating Emitter, tas, internalcondition,  get internal condition heating emitter, GetheatingEmitter, getheatingemitter
        /// </search>
        public static Emitter GetHeatingEmitter(InternalCondition InternalCondition)
        {
            return new Emitter(InternalCondition.pInternalCondition.GetHeatingEmitter());
        }

        /// <summary>
        /// TAS Internal Condition Day Type
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <param name="Index">Day Type Index</param>
        /// <returns name="DayType">Day Type</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Day Type, tas, internalcondition,  get internal condition day type, DayType, GetDayType
        /// </search>
        public static DayType GetDayType(InternalCondition InternalCondition, int Index)
        {
            return new DayType(InternalCondition.pInternalCondition.GetDayType(Index));
        }

        /// <summary>
        /// Gets TAS Internal Condition Day Types
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="DayTypes">Day Type List</returns>
        /// <search>
        /// TAS, InternalCondition, DayTypes, Day Types
        /// </search>
        public static List<DayType> DayTypes(InternalCondition InternalCondition)
        {
            List<DayType> aDayTypeList = new List<DayType>();

            int aIndex = 1;
            TBD.dayType aDayType = InternalCondition.pInternalCondition.GetDayType(aIndex);
            while (aDayType != null)
            {
                aDayTypeList.Add(new DayType(aDayType));
                aIndex++;
                aDayType = InternalCondition.pInternalCondition.GetDayType(aIndex);
            }
            return aDayTypeList;
        }

        /// <summary>
        /// Sets TAS Internal Condition Day Type
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <param name="DayType">Day Type</param>
        /// <param name="Add">Add</param>
        /// <returns name="DayType">Day Type</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Set Internal Condition Day Type, tas, internalcondition,  set internal condition day type, DayType, SetDayType
        /// </search>
        public static int SetDayType(InternalCondition InternalCondition, DayType DayType, bool Add)
        {
            return InternalCondition.pInternalCondition.SetDayType(DayType.pDayType, Add);
        }

        /// <summary>
        /// Gets TAS Internal Condition Lower Limit
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="LowerLimit">Lower Limit</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Lower Limit, tas, internalcondition,  get internal condition lower limit
        /// </search>
        public static float LowerLimit(InternalCondition InternalCondition)
        {
            return InternalCondition.pInternalCondition.GetLowerLimit();
        }

        /// <summary>
        /// Gets TAS Internal Condition Thermostat
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="Thermostat">Thermostat</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, GetThermostat, tas, internalcondition,  get internal condition thermostat, Thermostat, GetThermostat, getthermostat
        /// </search>
        public static Thermostat GetThermostat(InternalCondition InternalCondition)
        {
            return new Thermostat(InternalCondition.pInternalCondition.GetThermostat());
        }

        /// <summary>
        /// Gets TAS Internal Condition Internal Gain
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Internal Gain, tas, internalcondition,  get internal condition internal gain, internalgain, getinternalgain
        /// </search>
        public static InternalGain GetInternalGain(InternalCondition InternalCondition)
        {
            return new InternalGain(InternalCondition.pInternalCondition.GetInternalGain());
        }

        /// <summary>
        /// Gets TAS Internal Condition Upper Limit
        /// </summary>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <returns name="UpperLimit">Upper Limit</returns>
        /// <search>
        /// TAS, Internal Condition, InternalCondition, Get Internal Condition Upper Limit, tas, internalcondition,  get internal condition Upper Limit,GetUpperLimit
        /// </search>
        public static float UpperLimit(InternalCondition InternalCondition)
        {
            return InternalCondition.pInternalCondition.GetUpperLimit();
        }
    }
}
