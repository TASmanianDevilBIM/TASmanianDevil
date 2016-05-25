using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Zone
    /// </summary>
    public class Zone
    {
        internal TBD.zone pZone;

        internal Zone(TBD.zone Zone)
        {
            pZone = Zone;
        }

        /// <summary>
        /// Zone GUID
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="GUID">Zone GUID</returns>
        /// <search>
        /// TAS, Zone GUID, Get Zone GUID, tas, zone guid, get zone guid
        /// </search>
        public static string GUID(Zone Zone)
        {
            return Zone.pZone.GUID;
        }

        /// <summary>
        /// Zone Number
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Number">Zone Number</returns>
        /// <search>
        /// TAS, Zone Number, Get Zone Number, tas, zone number, get zone number
        /// </search>
        public static int Number(Zone Zone)
        {
            return Zone.pZone.number;
        }

        /// <summary>
        /// Zone Name
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Name">Zone Name</returns>
        /// <search>
        /// TAS, Zone Name, Get Zone Name, tas, zone name, get zone name
        /// </search>
        public static string Name(Zone Zone)
        {
            return Zone.pZone.name;
        }

        /// <summary>
        /// Set Zone Name
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Name">Zone Name</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone Name, Set Zone Name, tas, zone name, set zone name, SetName
        /// </search>
        public static Zone SetName(Zone Zone, string Name)
        {
            Zone.pZone.name = Name;
            return Zone;
        }

        /// <summary>
        /// Zone Floor Area
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Area">Zone Floor Area</returns>
        /// <search>
        /// TAS, Zone Floor Area, Get Zone Floor Area, tas, zone floor area, get zone floor area, zonefloorarea, ZoneFloorArea
        /// </search>
        public static float FloorArea(Zone Zone)
        {
            return Zone.pZone.floorArea;
        }

        /// <summary>
        /// Zone Volume
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Name">Zone Volume</returns>
        /// <search>
        /// TAS, Zone Volume, Get Zone Volume, tas, zone volume, get zone volume
        /// </search>
        public static float Volume(Zone Zone)
        {
            return Zone.pZone.volume;
        }

        /// <summary>
        /// Zone Max Cooling Load
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Load">Zone Max Cooling Load</returns>
        /// <search>
        /// TAS, Zone Max Cooling Load, Get Zone Max Cooling Load, tas, zone max Cooling load, get zone max cooling load, MaxCoolingLoad, maxcoolingload
        /// </search>
        public static float MaxCoolingLoad(Zone Zone)
        {
            return Zone.pZone.maxCoolingLoad;
        }

        /// <summary>
        /// Set Zone Max Cooling Load
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Max Cooling Load Value</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone Max Cooling Load, Set Zone Max Cooling Load, tas, zone max Cooling load, set zone max cooling load, MaxCoolingLoad, maxcoolingload, SetMaxCoolingLoad, setmaxcoolingload
        /// </search>
        public static Zone SetMaxCoolingLoad(Zone Zone, float Value)
        {
            Zone.pZone.maxCoolingLoad = Value;
            return Zone;
        }

        /// <summary>
        /// Zone Max Heating Load
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="MaxHeatingLoad">Load</returns>
        /// <search>
        /// TAS, Zone Max Heating Load, Get Zone Max Heating Load, tas, zone max heating load, get zone max heating load, MaxHeatingLoad, maxheatingload
        /// </search>
        public static float MaxHeatingLoad(Zone Zone)
        {
            return Zone.pZone.maxHeatingLoad;
        }

        /// <summary>
        /// Set Zone Max Heating Load
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Max Heating Load Value</param>
        /// <returns name="MaxHeatingLoad">Load</returns>
        /// <search>
        /// TAS, Zone Max Heating Load, Set Zone Max Heating Load, tas, zone max heating load, set zone max heating load, MaxHeatingLoad, maxheatingload, SetMaxHeatingLoad, setmaxheatingload
        /// </search>
        public static Zone SetMaxHeatingLoad(Zone Zone, float Value)
        {
            Zone.pZone.maxHeatingLoad = Value;
            return Zone;
        }

        /// <summary>
        /// Zone Day Light Factor
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Factor">Zone Day Light Factor</returns>
        /// <search>
        /// TAS, Zone Day Light Factor, Get Zone Day Light Factor, tas, zone day light factor, get zone day light factor, DayLightFactor, daylightfactor
        /// </search>
        public static float DayLightFactor(Zone Zone)
        {
            return Zone.pZone.daylightFactor;
        }

        /// <summary>
        /// Set Zone Day Light Factor
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Day Light Factor</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone Day Light Factor, Set Zone Day Light Factor, tas, zone day light factor, set zone day light factor, DayLightFactor, daylightfactor, SetDayLightFactor, setdaylightfactor
        /// </search>
        public static Zone SetDayLightFactor(Zone Zone, float Value)
        {
            Zone.pZone.daylightFactor = Value;
            return Zone;
        }

        /// <summary>
        /// Zone FacadeLength
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Length">Zone Facade Length</returns>
        /// <search>
        /// TAS, Zone Facade Length, Get Zone Facade Length, tas, zone facade length, get zone facade length, FacadeLength, facadelength
        /// </search>
        public static float FacadeLength(Zone Zone)
        {
            return Zone.pZone.facadeLength;
        }

        /// <summary>
        /// Zone Description
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Name">Zone Description</returns>
        /// <search>
        /// TAS, Zone Description, Get Zone Description, tas, zone description, get zone description
        /// </search>
        public static string Description(Zone Zone)
        {
            return Zone.pZone.description;
        }

        /// <summary>
        /// Set Zone Description
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Description">Zone Description</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone Description, Set Zone Description, tas, zone description, set zone description, SetDescription
        /// </search>
        public static Zone SetDescription(Zone Zone, string Description)
        {
            Zone.pZone.description = Description;
            return Zone;
        }

        /// <summary>
        /// Zone Exposed Perimeter
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Permieter">Zone Exposed Perimeter</returns>
        /// <search>
        /// TAS, Zone Exposed Perimeter, Get Zone Exposed Perimeter, tas, zone exposed perimeter, get zone exposed perimeter, ExposedPerimeter, exposedperimeter
        /// </search>
        public static float ExposedPerimeter(Zone Zone)
        {
            return Zone.pZone.exposedPerimeter;
        }

        /// <summary>
        /// Assigns Internal Condition for Zone
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="InternalCondition">TAS Internal Condition</param>
        /// <param name="Add">Add</param>
        /// <returns name="Integer">Integer</returns>
        /// <search>
        /// TAS, AssignInternalCondition, Zone Assign Internal Condition, tas, assigninternalcondition, 
        /// </search>
        public static int AssignInternalCondition(Zone Zone, InternalCondition InternalCondition, bool Add)
        {
            return Zone.pZone.AssignIC(InternalCondition.pInternalCondition, Add);
        }

        /// <summary>
        /// Zone Size Heating
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Value">Size Heating Value</returns>
        /// <search>
        /// TAS, Zone, zone, Size Heating, size heating, SizeHeating, sizeheating
        /// </search>
        public static int SizeHeating(Zone Zone)
        {
            return Zone.pZone.sizeHeating;
        }

        /// <summary>
        /// Set Zone Size Heating
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">SizeHeating</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, Size Heating, size heating, SizeHeating, sizeheating, SetSizeHeating, setsizeheating
        /// </search>
        public static Zone SetSizeHeating(Zone Zone, int Value)
        {
            Zone.pZone.sizeHeating = Value;
            return Zone;
        }

        /// <summary>
        /// Zone Size Cooling
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Value">Size Cooling Value</returns>
        /// <search>
        /// TAS, Zone, zone, Size Cooling, size cooling, SizeCooling, sizecooling
        /// </search>
        public static int SizeCooling(Zone Zone)
        {
            return Zone.pZone.sizeCooling;
        }

        /// <summary>
        /// Set Zone Size Cooling
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Zone Size Cooling</param>
        /// <returns name="SizeCooling">Size Cooling</returns>
        /// <search>
        /// TAS, Zone, zone, Size Cooling, size cooling, SizeCooling, sizecooling, SetSizeCooling, setsizecooling
        /// </search>
        public static Zone SetSizeCooling(Zone Zone, int Value)
        {
            Zone.pZone.sizeCooling = Value;
            return Zone;
        }

        /// <summary>
        /// Zone Output
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Output">Zone Output</returns>
        /// <search>
        /// TAS, Zone, zone, Output, output, zone output
        /// </search>
        public static int Output(Zone Zone)
        {
            return Zone.pZone.output;
        }

        /// <summary>
        /// Set Zone Output
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Output">Zone Output</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, Output, output, zone output, SetOutput, setoutput
        /// </search>
        public static Zone SetOutput(Zone Zone, int Output)
        {
            Zone.pZone.output = Output;
            return Zone;
        }

        /// <summary>
        /// Zone Fixed Convection Coefficient
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Name">Zone Description</returns>
        /// <search>
        /// TAS, Zone Fixed Convection Coefficient, tas, zone fixed convection coefficient, get zone Fixed Convection Coefficient, FixedConvectionCoefficient, fixedconvectioncoefficient
        /// </search>
        public static float FixedConvectionCoefficient(Zone Zone)
        {
            return Zone.pZone.fixedConvectionCoefficient;
        }

        /// <summary>
        /// Set Zone Fixed Convection Coefficient
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Fixed Convection Coefficient</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone Fixed Convection Coefficient, tas, zone fixed convection coefficient, set zone Fixed Convection Coefficient, SetFixedConvectionCoefficient, setfixedconvectioncoefficient
        /// </search>
        public static Zone SetFixedConvectionCoefficient(Zone Zone, float Value)
        {
            Zone.pZone.fixedConvectionCoefficient = Value;
            return Zone;
        }

        /// <summary>
        /// Gets Zone Surface
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Index">Zone Index</param>
        /// <returns name="ZoneSurface">Zone Surface</returns>
        /// <search>
        /// TAS, Zone Surface, Zone, GetZoneSurface, getzonesurface, get zone surface, Get Zone Surface
        /// </search>
        public static ZoneSurface GetZoneSurface(Zone Zone, int Index)
        {
            return new ZoneSurface(Zone.pZone.GetSurface(Index));
        }

        /// <summary>
        /// Gets TAS Zone surfaces
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Surfaces">Surface List</returns>
        /// <search>
        /// TAS, Zone, Surfaces, ZoneSurfaces, Zone Surfaces, zonesurfaces, zone surfaces, GetZoneSurfaces, getzonesurfaces
        /// </search>
        public static List<ZoneSurface> ZoneSurfaces(Zone Zone)
        {
            List<ZoneSurface> aZoneSurfaceList = new List<ZoneSurface>();

            int aIndex = 0;
            TBD.zoneSurface aZoneSurface = Zone.pZone.GetSurface(aIndex);
            while (aZoneSurface != null)
            {
                aZoneSurfaceList.Add(new ZoneSurface(aZoneSurface));
                aIndex++;
                aZoneSurface = Zone.pZone.GetSurface(aIndex);
            }
            return aZoneSurfaceList;
        }

        /// <summary>
        /// Assigns Zone IZAM
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="IZAM">IZAM</param>
        /// <param name="Add">Add IZAM</param>
        /// <returns name="Output">Zone Output</returns>
        /// <search>
        /// TAS, Zone, zone, AssignIZAM, Assign IZAM, assignizam
        /// </search>
        public static int AssignIZAM(Zone Zone, IZAM IZAM, bool Add)
        {
            return Zone.pZone.AssignIZAM(IZAM.pIZAM, Add);
        }

        /// <summary>
        /// Zone External
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="External">Zone External</returns>
        /// <search>
        /// TAS, Zone, zone, External, external, zone external
        /// </search>
        public static int External(Zone Zone)
        {
            return Zone.pZone.external;
        }

        /// <summary>
        /// Zone External
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Zone External</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, External, external, zone external, SetExternal, setexternal, Set External, set external
        /// </search>
        public static Zone SetExternal(Zone Zone, int Value)
        {
            Zone.pZone.external = Value;
            return Zone;
        }

        /// <summary>
        /// Get Zone Internal Condition
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Index">Internal Condition Index</param>
        /// <returns name="InternalCondition">Zone Internal Condition</returns>
        /// <search>
        /// TAS, Zone, zone, GetInternalCondition, getinternalcondition, Get Internal Condition, getinternalcondition
        /// </search>
        public static InternalCondition GetInternalCondition(Zone Zone, int Index)
        {
            return new InternalCondition(Zone.pZone.GetIC(Index));
        }

        /// <summary>
        /// Gets TAS Zone Internal Conditions
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="InternalConditions">Internal Condition List</returns>
        /// <search>
        /// TAS, Zone, InternalConditions, Internal Conditions, internalconditions, internal conditions
        /// </search>
        public static List<InternalCondition> InternalConditions(Zone Zone)
        {
            List<InternalCondition> aInternalConditionList = new List<InternalCondition>();

            int aIndex = 0;
            TBD.InternalCondition aInternalCondition = Zone.pZone.GetIC(aIndex);
            while (aInternalCondition != null)
            {
                aInternalConditionList.Add(new InternalCondition(aInternalCondition));
                aIndex++;
                aInternalCondition = Zone.pZone.GetIC(aIndex);
            }
            return aInternalConditionList;
        }

        /// <summary>
        /// Zone Wall Floor Area Ratio
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Value">Zone Wall Floor Area Ratio</returns>
        /// <search>
        /// TAS, Zone, zone, WallFloorAreaRatio, Wall Floor Area Ratio, wallfloorarearatio, wall floor area ratio
        /// </search>
        public static float WallFloorAreaRatio(Zone Zone)
        {
            return Zone.pZone.wallFloorAreaRatio;
        }

        /// <summary>
        /// Set Zone Wall Floor Area Ratio
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Value">Wall Floor Area Ratio</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, WallFloorAreaRatio, Wall Floor Area Ratio, wallfloorarearatio, wall floor area ratio, SetWallFloorAreaRatio, Set Wall Floor Area Ratio, set wall floor area ratio
        /// </search>
        public static Zone SetWallFloorAreaRatio(Zone Zone, float Value)
        {
            Zone.pZone.wallFloorAreaRatio = Value;
            return Zone;
        }
    }
}
