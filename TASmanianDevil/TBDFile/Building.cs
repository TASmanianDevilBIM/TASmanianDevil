using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Building
    /// </summary>
    public class Building
    {
        private TBD.Building pBuilding;
        private string pName;
        private string pGUID;

        internal Building(TBD.Building Building)
        {
            pBuilding = Building;
            pName = pBuilding.name;
            pGUID = pBuilding.GUID;
        }

        /// <summary>
        /// Gets TAS Building zones
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Zones">Zone List</returns>
        /// <search>
        /// TAS, Building, Zones, Get Zones, tas, builidng, zones, get zones
        /// </search>
        public static List<Zone> Zones(Building Building)
        {
            List<Zone> aZoneList = new List<Zone>();

            int aIndex = 0;
            TBD.zone aZone = Building.pBuilding.GetZone(aIndex);
            while (aZone != null)
            {
                aZoneList.Add(new Zone(aZone));
                aIndex++;
                aZone = Building.pBuilding.GetZone(aIndex);
            }
            return aZoneList;
        }

        /// <summary>
        /// Gets TAS Building Internal Conditions
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="InternalConditions">Building Internal Conditions</returns>
        /// <search>
        /// TAS, Building, Zones, Get Internal Conditions, tas, builidng, zones, get internalcondition, InternalCondition, internalcondition
        /// </search>
        public static List<InternalCondition> InternalConditions(Building Building)
        {
            List<InternalCondition> aZoneList = new List<InternalCondition>();

            int aIndex = 0;
            TBD.InternalCondition aInternalCondition = Building.pBuilding.GetIC(aIndex);
            while (aInternalCondition != null)
            {
                aZoneList.Add(new InternalCondition(aInternalCondition));
                aIndex++;
                aInternalCondition = Building.pBuilding.GetIC(aIndex);
            }
            return aZoneList;
        }

        /// <summary>
        /// Gets TAS Building Internal Conditions
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Index</param>
        /// <returns name="InternalCondition">Building Internal Condition</returns>
        /// <search>
        /// TAS, Building, Zones, Get Internal Condition, tas, builidng, zones, get internalcondition, InternalCondition, internalcondition
        /// </search>
        public static InternalCondition GetInternalCondition(Building Building, int Index)
        {
            return new InternalCondition( Building.pBuilding.GetIC(Index));
        }

        /// <summary>
        /// Gets TBD TAS Building Zone (starting from 0)
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">zone index</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Building, Zone, Get Zone tas, builidng, zone, get zone
        /// </search>
        public static Zone GetZone(Building Building, int Index)
        {
            return new Zone(Building.pBuilding.GetZone(Index));
        }

        /// <summary>
        /// Gets TAS Building zone
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="GUID">zone Guid</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Building, Zone, Get Zone tas, builidng, zone, get zone
        /// </search>
        public static Zone GetZone(Building Building, string GUID)
        {
            return new Zone(Building.pBuilding.FindZone(GUID));
        }

        /// <summary>
        /// Gets Building Element
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Index</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, Building, Zone, Get Building Element, getbuildingelement, GetBuildingElement
        /// </search>
        public static BuildingElement GetBuildingElement(Building Building, int Index)
        {
            return new BuildingElement(Building.pBuilding.GetBuildingElement(Index));
        }

        /// <summary>
        /// Gets Building Elemnts
        /// </summary>
        /// <param name="Building">Building</param>
        /// <returns name="Building Element">Building Element List</returns>
        /// <search>
        /// TAS, Building, Building Element, BuildingElements
        /// </search>
        public static List<BuildingElement> BuildingElements(Building Building)
        {
            List<BuildingElement> aBuildingElementList = new List<BuildingElement>();

            int aIndex = 0;
            TBD.buildingElement aBuildingElement = Building.pBuilding.GetBuildingElement(aIndex);
            while (aBuildingElement != null)
            {
                aBuildingElementList.Add(new BuildingElement(aBuildingElement));
                aIndex++;
                aBuildingElement = Building.pBuilding.GetBuildingElement(aIndex);
            }
            return aBuildingElementList;
        }

        /// <summary>
        /// Adds Building Element to the builidng
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, Building, AddBuildingElement, Add Building Element
        /// </search>
        public static BuildingElement AddBuildingElement(Building Building)
        {
            return new BuildingElement(Building.pBuilding.AddBuildingElement());
        }

        /// <summary>
        /// Gets TAS Building description
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Description">Zone description</returns>
        /// <search>
        /// TAS, Building, Zone, Get Zone Description, builidng, zone, get zone description 
        /// </search>
        public static string Description(Building Building)
        {
            return Building.pBuilding.description;
        }

        /// <summary>
        /// Adds Cooling Design Day to the building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="CoolingDesignDay">Cooling Design Day</returns>
        /// <search>
        /// TAS, Building, AddCoolingDesignDay, Add Cooling Design Day
        /// </search>
        public static CoolingDesignDay AddCoolingDesignDay(Building Building)
        {
            return new CoolingDesignDay(Building.pBuilding.AddCoolingDesignDay());
        }

        /// <summary>
        /// Adds Heating Design Day to the building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="HeatingDesignDay">Heating Design Day</returns>
        /// <search>
        /// TAS, Building, AddHeatingDesignDay, Add Heating Design Day
        /// </search>
        public static HeatingDesignDay AddHeatingDesignDay(Building Building)
        {
            return new HeatingDesignDay(Building.pBuilding.AddHeatingDesignDay());
        }

        /// <summary>
        /// Adds TAS Building zone group
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Name">Name</param>
        /// <param name="Description">Description</param>
        /// <returns name="ZoneGroup">Zone Group</returns>
        /// <search>
        /// TAS, Building, Zone Group, Add Zone Group, tas, builidng, zone group, add zone group
        /// </search>
        public static ZoneGroup AddZoneGroup(Building Building, string Name, string Description = "")
        {
            TBD.ZoneGroup aZoneGroup = Building.pBuilding.AddZoneGroup();
            aZoneGroup.name = Name;
            aZoneGroup.description = Description;

            return new ZoneGroup(aZoneGroup);
        }

        /// <summary>
        /// Removes TAS Building zone group
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Index</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, Building, Zone Group, Remove Zone Group, tas, builidng, zone group, remove zone group, removezonegroup
        /// </search>
        public static int RemoveZoneGroup(Building Building, int Index)
        {
            return Building.pBuilding.RemoveZoneGroup(Index);
        }

        /// <summary>
        /// Gets TAS Building zone group
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Index</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, Building, Zone Group, Get Zone Group, tas, builidng, zone group, get zone group, GetZoneGroup
        /// </search>
        public static ZoneGroup GetZoneGroup(Building Building, int Index)
        {
            return new ZoneGroup(Building.pBuilding.GetZoneGroup(Index));
        }

        /// <summary>
        /// Gets All TAS Building zone groups
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="ZoneGroups">Zone Group List</returns>
        /// <search>
        /// TAS, Building, Zone Group, Get Zone Group, tas, builidng, zone group, get zone group, GetZoneGroup
        /// </search>
        public static List<ZoneGroup> ZoneGroups(Building Building)
        {
            List<ZoneGroup> aZoneGroupList = new List<ZoneGroup>();

            int aIndex = 0;
            TBD.ZoneGroup aZoneGroup = Building.pBuilding.GetZoneGroup(aIndex);
            while (aZoneGroup != null)
            {
                aZoneGroupList.Add(new ZoneGroup(aZoneGroup));
                aIndex++;
                aZoneGroup = Building.pBuilding.GetZoneGroup(aIndex);
            }
            return aZoneGroupList;
        }

        /// <summary>
        /// Adds TAS Building zone group
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Name">Name</param>
        /// <param name="Description">Description</param>
        /// <returns name="InternalCondition">Internal Condition</returns>
        /// <search>
        /// TAS, Building, Internal Condition, Add Internal Condition, tas, builidng, internal condition, add internal condition
        /// </search>
        public static InternalCondition AddInternalCondition(Building Building, string Name, string Description)
        {
            TBD.InternalCondition aInternalCondition = Building.pBuilding.AddIC(null);
            aInternalCondition.name = Name;
            aInternalCondition.description = Description;

            return new InternalCondition(aInternalCondition);
        }

        /// <summary>
        /// Gets TAS Building Cooling Design Day
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Day index</param>
        /// <returns name="CoolingDesignDay">Cooling Design Day</returns>
        /// <search>
        /// TAS, Building, GetCoolingDesignDay, Get Cooling Design Day
        /// </search>
        public static CoolingDesignDay GetCoolingDesignDay(Building Building, int Index)
        {
            return new CoolingDesignDay(Building.pBuilding.GetCoolingDesignDay(Index));
        }

        /// <summary>
        /// Gets Building Heating Design Day
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Day index</param>
        /// <returns name="HeatingDesignDay">Heating Desig nDay</returns>
        /// <search>
        /// TAS, Building, HeatingDesignDay, Heating Design Day, GetHeatingDesignDay
        /// </search>
        public static HeatingDesignDay GetHeatingDesignDay(Building Building, int Index)
        {
            return new HeatingDesignDay(Building.pBuilding.GetHeatingDesignDay(Index));
        }

        /// <summary>
        /// Gets TAS Building Peak Cooling
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="PeakCooling">Peak Cooling</returns>
        /// <search>
        /// TAS, Building, building, Peak Cooling, peak cooling, peakcooling, PeakCooling
        /// </search>
        public static float PeakCooling(Building Building)
        {
            return Building.pBuilding.peakCooling;
        }

        /// <summary>
        /// Gets TAS Building Peak Heating
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="PeakCooling">Peak Heating</returns>
        /// <search>
        /// TAS, Building, building, Peak Heating, peak heating, peakheating, PeakHeating
        /// </search>
        public static float PeakHeating(Building Building)
        {
            return Building.pBuilding.peakCooling;
        }

        /// <summary>
        /// Gets TAS Building constructions
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Constructions">Construction List</returns>
        /// <search>
        /// TAS, Building, Get Constructions, tas, builidng, constructions, get constructions
        /// </search>
        public static List<Construction> Constructions(Building Building)
        {
            List<Construction> aConstructionList = new List<Construction>();

            int aIndex = 0;
            TBD.Construction aConstruction = Building.pBuilding.GetConstruction(aIndex);
            while (aConstruction != null)
            {
                aConstructionList.Add(new Construction(aConstruction));
                aIndex++;
                aConstruction = Building.pBuilding.GetConstruction(aIndex);
            }
            return aConstructionList;
        }

        /// <summary>
        /// Gets TAS Building construction
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">construction index</param>
        /// <returns name="Construction">Construction</returns>
        /// <search>
        /// TAS, Building, Construction, Get Construction, tas, builidng, construction, get construction
        /// </search>
        public static Construction GetConstruction(Building Building, int Index)
        {
            return new Construction(Building.pBuilding.GetConstruction(Index));
        }

        /// <summary>
        /// Duplicates TAS Building Construction
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Construction">Building Construction to be copied</param>
        /// <returns name="Construction">Construction</returns>
        /// <search>
        /// TAS, Building, AddConstruction, Add Construction
        /// </search>
        public static Construction DuplicateConstruction(Building Building, Construction Construction)
        {
            return new Construction(Building.pBuilding.AddConstruction(Construction.pConstruction));
        }

        /// <summary>
        /// Adds TAS Building Construction
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Construction">Construction</returns>
        /// <search>
        /// TAS, Building, AddConstruction, Add Construction
        /// </search>
        public static Construction AddConstruction(Building Building)
        {
            return new Construction(Building.pBuilding.AddConstruction(null));
        }

        /// <summary>
        /// Removes Internal Condition from the building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Internal Condition index</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Building, Internal Condition, Remove Internal Condition, tas, builidng, internal condition, remove internal condition, removeinternal condition removeic
        /// </search>
        public static Building RemoveInternalCondition(Building Building, int Index)
        {
            Building.pBuilding.RemoveIC(Index);
            return Building;
        }

        /// <summary>
        /// Duplicates Aperture Type to Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="ApertureType">Base Aperture Type to be copied</param>
        /// <returns name="ApertureType">Aperture Type</returns>
        /// <search>
        /// TAS, Building, builidng, ApertureType, Aperture Type, AddApertureType, Add Aperture Type
        /// </search>
        public static ApertureType DuplicateApertureType(Building Building, ApertureType ApertureType)
        {
            return new ApertureType(Building.pBuilding.AddApertureType(ApertureType.pApertureType));
        }

        /// <summary>
        /// Adds Aperture Type to Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="ApertureType">Aperture Type</returns>
        /// <search>
        /// TAS, Building, builidng, ApertureType, Aperture Type, AddApertureType, Add Aperture Type
        /// </search>
        public static ApertureType AddApertureType(Building Building)
        {
            return new ApertureType(Building.pBuilding.AddApertureType(null));
        }

        /// <summary>
        /// Gets Aperture Type to Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">Aperture Type Index</param>
        /// <returns name="ApertureType">Aperture Type</returns>
        /// <search>
        /// TAS, Building, builidng, ApertureType, Aperture Type, GetApertureType, Get Aperture Type
        /// </search>
        public static ApertureType GetApertureType(Building Building, int Index)
        {
            return new ApertureType(Building.pBuilding.GetApertureType(Index));
        }

        /// <summary>
        /// Gets All TAS Building Aperture Types
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="ApertureTypes">Zone Aperture Type List</returns>
        /// <search>
        /// TAS, Building, tas, builidng, ApertureTypes, Aperture Types
        /// </search>
        public static List<ApertureType> ApertureTypes(Building Building)
        {
            List<ApertureType> aApertureTypeList = new List<ApertureType>();

            int aIndex = 0;
            TBD.ApertureType aApertureType = Building.pBuilding.GetApertureType(aIndex);
            while (aApertureType != null)
            {
                aApertureTypeList.Add(new ApertureType(aApertureType));
                aIndex++;
                aApertureType = Building.pBuilding.GetApertureType(aIndex);
            }
            return aApertureTypeList;
        }

        /// <summary>
        /// Clears Design Days of the building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, Building, ClearDesignDays, Clear Design Days
        /// </search>
        public static int ClearDesignDays(Building Building)
        {
            return Building.pBuilding.ClearDesignDays();
        }

        /// <summary>
        /// Gets TAS Building description
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Schedule">Building Schedule</returns>
        /// <search>
        /// TAS, Building, Schedule, AddSchedule, Add Schedule
        /// </search>
        public static Schedule AddSchedule(Building Building)
        {
            return new Schedule(Building.pBuilding.AddSchedule());
        }

        /// <summary>
        /// Adds TAS Building Surface Output Spec
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="SurfaceOutputSpec">Building Surface Output Spec</returns>
        /// <search>
        /// TAS, Building, SurfaceOutputSpec, AddSurfaceOutputSpec, addsurfaceoutputspec, Add Surface Output Spec, add surface output spec
        /// </search>
        public static SurfaceOutputSpec AddSurfaceOutputSpec(Building Building)
        {
            return new SurfaceOutputSpec(Building.pBuilding.AddSurfaceOutputSpec());
        }

        /// <summary>
        /// Gets Controls from Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Building, Controls, controls, building controls, 
        /// </search>
        public static Controls Controls(Building Building)
        {
            return new Controls(Building.pBuilding.GetControls());
        }

        /// <summary>
        /// Gets General Details from Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="GeneralDetails">Building General Details</returns>
        /// <search>
        /// TAS, Building, GeneralDetails, General Details, generaldetails, generaldetails
        /// </search>
        public static GeneralDetails GeneralDetails(Building Building)
        {
            return new GeneralDetails(Building.pBuilding.GetGeneralDetails());
        }

        /// <summary>
        /// Gets Substitute Element from Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">TAS Building Index</param>
        /// <returns name="SubstituteElement">Building Substitute Element</returns>
        /// <search>
        /// TAS, Building, SubstituteElement, Substitute Element, Get Substitute Element
        /// </search>
        public static SubstituteElement GetSubstituteElement(Building Building, int Index)
        {
            return new SubstituteElement(Building.pBuilding.GetSubstituteElement(Index));
        }

        /// <summary>
        /// Gets calendar for the Building
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Calendar">TBD Calendar</returns>
        /// <search>
        /// TAS, Building, builidng, Calendar, calendar
        /// </search>
        public static Calendar Calendar(Building Building)
        {
            return new Calendar(Building.pBuilding.GetCalendar());
        }

        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return string.Format("{0} [{1} : {2}]", GetType(), pName, pGUID);
        }
    }
}
