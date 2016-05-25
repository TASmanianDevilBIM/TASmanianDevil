using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Building Element
    /// </summary>
    public class BuildingElement
    {
        private TBD.buildingElement pBuildingElement;

        internal BuildingElement(TBD.buildingElement BuildingElement)
        {
            pBuildingElement = BuildingElement;
        }

        /// <summary>
        /// TAS Building Element Name
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, BuildingElement, Name, name, Building Element
        /// </search>
        public static string Name(BuildingElement BuildingElement)
        {
            return BuildingElement.pBuildingElement.name;
        }

        /// <summary>
        /// Sets TAS Building Element Name
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Name">Name</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, BuildingElement, Name, name, Building Element, SetName
        /// </search>
        public static BuildingElement SetName(BuildingElement BuildingElement, string Name)
        {
            BuildingElement.pBuildingElement.name = Name;
            return BuildingElement;
        }

        /// <summary>
        /// TAS Building Element Width
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="Width">Width</returns>
        /// <search>
        /// TAS, BuildingElement, Width, width, Building Element
        /// </search>
        public static double Width(BuildingElement BuildingElement)
        {
            return BuildingElement.pBuildingElement.width;
        }

        /// <summary>
        /// Sets TAS Building Element Width
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Width">Building Element Width</param>
        /// <returns name="Width">Width</returns>
        /// <search>
        /// TAS, BuildingElement, Width, width, Building Element, SetWidth, Set Width, setwidth
        /// </search>
        public static BuildingElement SetWidth(BuildingElement BuildingElement, float Width)
        {
            BuildingElement.pBuildingElement.width = Width;
            return BuildingElement;
        }

        /// <summary>
        /// TAS Building Element Description
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, BuildingElement, Description, description, Building Element
        /// </search>
        public static string Description(BuildingElement BuildingElement)
        {
            return BuildingElement.pBuildingElement.description;
        }

        /// <summary>
        /// TAS Building Element GUID
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="GUID">GUID</returns>
        /// <search>
        /// TAS, BuildingElement, GUID, guid, Building Element
        /// </search>
        public static string GUID(BuildingElement BuildingElement)
        {
            return BuildingElement.pBuildingElement.GUID;
        }

        /// <summary>
        /// TAS Building Element Ground
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="Ground">Ground</returns>
        /// <search>
        /// TAS, BuildingElement, Ground, ground, Building Element
        /// </search>
        public static int Ground(BuildingElement BuildingElement)
        {
            return BuildingElement.pBuildingElement.ground;
        }

        /// <summary>
        /// Sets TAS Building Element Ground
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Ground">Building Element Ground</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, BuildingElement, Ground, ground, Building Element, SetGround, set ground
        /// </search>
        public static BuildingElement SetGround(BuildingElement BuildingElement, int Ground)
        {
            BuildingElement.pBuildingElement.ground = Ground;
            return BuildingElement;
        }

        /// <summary>
        /// TAS Building Element Construction
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="Construction">Construction</returns>
        /// <search>
        /// TAS, BuildingElement, GetConstruction, getconstruction, Building Element
        /// </search>
        public static Construction Construction(BuildingElement BuildingElement)
        {
            return new Construction(BuildingElement.pBuildingElement.GetConstruction());
        }

        /// <summary>
        /// Sets Building Element Construction
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Construction">Construction</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, BuildingElement, Construction, construction, Building Element, SetConstruction, setconstruction
        /// </search>
        public static int SetConstruction(BuildingElement BuildingElement, Construction Construction)
        {
            return BuildingElement.pBuildingElement.AssignConstruction(Construction.pConstruction);
        }

        /// <summary>
        /// Assign Aparture Type to building element
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="ApertureType">Aperture Type</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, AssignApertureType, Assign Aperture Type
        /// </search>
        public static int AssignApertureType(BuildingElement BuildingElement, ApertureType ApertureType)
        {
            return BuildingElement.pBuildingElement.AssignApertureType(ApertureType.pApertureType);
        }

        /// <summary>
        /// Remove Aparture Type from building element
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Index">Aperture Type Index</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, RemoveApertureType, Remove Aperture Type
        /// </search>
        public static int RemoveApertureType(BuildingElement BuildingElement, int Index)
        {
            return BuildingElement.pBuildingElement.RemoveApertureType(Index);
        }

        /// <summary>
        /// Gets Builidng Element Zone Surfaces
        /// </summary>
        /// <param name="BuildingElement">TAS Building Element</param>
        /// <returns name="ZoneSurfaces">Zone Surface List</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, buildingelement, building element, ZoneSurfaces, Zone Surfaces, zonesurfaces, zone surfaces
        /// </search>
        public static List<ZoneSurface> ZoneSurfaces(BuildingElement BuildingElement)
        {
            List<ZoneSurface> aZoneSurfaceList = new List<ZoneSurface>();

            int aIndex = 0;
            TBD.zoneSurface aZoneSurface = BuildingElement.pBuildingElement.zoneSurfaces(aIndex);
            while (aZoneSurface != null)
            {
                aZoneSurfaceList.Add(new ZoneSurface(aZoneSurface));
                aIndex++;
                aZoneSurface = BuildingElement.pBuildingElement.zoneSurfaces(aIndex);
            }
            return aZoneSurfaceList;
        }

        /// <summary>
        /// TAS Building Element Aperture Type
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Index">Aperture Type Index</param>
        /// <returns name="ApertureType">Aperture Type</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, ApertureType, Aperture Type, GetApertureType, Get Aperture Type, getaperturetype, GetApertureType
        /// </search>
        public static ApertureType GetApertureType(BuildingElement BuildingElement, int Index)
        {
            return new ApertureType(BuildingElement.pBuildingElement.GetApertureType(Index));
        }

        /// <summary>
        /// Gets TAS Building Element Aperture Types
        /// </summary>
        /// <param name="BuildingElement">TAS Building Element</param>
        /// <returns name="ApertureTypes">Aperture Type List</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, buildingelement, building element, ApertureTypes, Aperture Types, aperturetypes, aperture types
        /// </search>
        public static List<ApertureType> ApertureTypes(BuildingElement BuildingElement)
        {
            List<ApertureType> aApertureTypeList = new List<ApertureType>();

            int aIndex = 0;
            TBD.ApertureType aApertureType = BuildingElement.pBuildingElement.GetApertureType(aIndex);
            while (aApertureType != null)
            {
                aApertureTypeList.Add(new ApertureType(aApertureType));
                aIndex++;
                aApertureType = BuildingElement.pBuildingElement.GetApertureType(aIndex);
            }
            return aApertureTypeList;
        }

        /// <summary>
        /// TAS Building Element Null
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="Null">Null Building Element</returns>
        /// <search>
        /// TAS, BuildingElement, Null, null, Building Element
        /// </search>
        public static int Null(BuildingElement BuildingElement)
        {
            return BuildingElement.pBuildingElement.ghost;
        }

        /// <summary>
        /// Sets TAS Building Element Null
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Value">Building Element Null</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, BuildingElement, Null, null, Building Element, SetNull, Set Null, setnull, set null
        /// </search>
        public static BuildingElement SetNull(BuildingElement BuildingElement, int Value)
        {
            BuildingElement.pBuildingElement.ghost = Value;
            return BuildingElement;
        }
    }
}
