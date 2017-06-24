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
        /// TAS Building Element BE Type
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <returns name="BuildingElementType">Building Element Type</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, BE Type, BEType, betype, be type, BuildingElementType, Building Element Type, building element type
        /// </search>
        public static BuildingElementType BuildingElementType(BuildingElement BuildingElement)
        {
            int aInt = BuildingElement.pBuildingElement.BEType;
            return (BuildingElementType)aInt;
        }

        /// <summary>
        /// Sets TAS Building Element Building Element Type
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="BuildingElementType">Building Element Type</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, BuildingElement, Building Element, BE Type, BEType, betype, be type, SetBuildingElementType, Set Building Element Type
        /// </search>
        public static BuildingElement SetBuildingElementType(BuildingElement BuildingElement, BuildingElementType BuildingElementType)
        {
            BuildingElement.pBuildingElement.BEType = (int)BuildingElementType;
            return BuildingElement;
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
        /// TAS Building Element U Value. For detailed U value information refer to Construction U value
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Decimals">Decimals</param>
        /// <returns name="U value">U value</returns>
        /// <search>
        /// TAS, BuildingElement, Get U Value, getuvalue, Building Element, U, u value
        /// </search>
        public static double U(BuildingElement BuildingElement, int Decimals = 2)
        {
            TBD.Construction aConstruction = BuildingElement.pBuildingElement.GetConstruction();
            if (aConstruction == null)
                return -1;

            object aObject = aConstruction.GetUValue();
            List<float> aValueList = Generic.Functions.GetList(aObject);
            switch((BuildingElementType)BuildingElement.pBuildingElement.BEType)
            {
                case TBDFile.BuildingElementType.Ceiling:
                    return Math.Round(aValueList[4], Decimals);
                case TBDFile.BuildingElementType.CurtainWall:
                    return Math.Round(aValueList[6], Decimals);
                case TBDFile.BuildingElementType.DoorElement:
                    return Math.Round(aValueList[0], Decimals);
                case TBDFile.BuildingElementType.ExposedFloor:
                    return Math.Round(aValueList[2], Decimals);
                case TBDFile.BuildingElementType.ExternalWall:
                    return Math.Round(aValueList[0], Decimals);
                case TBDFile.BuildingElementType.FrameELement:
                    return Math.Round(aValueList[0], Decimals);
                case TBDFile.BuildingElementType.Glazing:
                    return Math.Round(aValueList[6], Decimals);
                case TBDFile.BuildingElementType.InternalFloor:
                    return Math.Round(aValueList[5], Decimals);
                case TBDFile.BuildingElementType.InternallWall:
                    return Math.Round(aValueList[3], Decimals);
                case TBDFile.BuildingElementType.NoBEType:
                    return -1;
                case TBDFile.BuildingElementType.NullElement:
                    return -1;
                case TBDFile.BuildingElementType.RaisedFloor:
                    return Math.Round(aValueList[5], Decimals);
                case TBDFile.BuildingElementType.RoofElement:
                    return Math.Round(aValueList[1], Decimals);
                case TBDFile.BuildingElementType.RoofLight:
                    return Math.Round(aValueList[6], Decimals);
                case TBDFile.BuildingElementType.ShadeElement:
                    return -1;
                case TBDFile.BuildingElementType.SlabOnGrade:
                    return Math.Round(aValueList[2], Decimals);
                case TBDFile.BuildingElementType.SolarPanel:
                    return -1;
                case TBDFile.BuildingElementType.UndergroundCeiling:
                    return Math.Round(aValueList[2], Decimals);
                case TBDFile.BuildingElementType.UndergroundSlab:
                    return Math.Round(aValueList[2], Decimals);
                case TBDFile.BuildingElementType.UndergroundWall:
                    return Math.Round(aValueList[0], Decimals);
                case TBDFile.BuildingElementType.VehicleDoor:
                    return Math.Round(aValueList[0], Decimals);
            }
            return -1;
        }

        /// <summary>
        /// TAS Building Element G Value. For detailed glazing value information refer to Construction glazing values
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Decimals">Decimals</param>
        /// <returns name="G value">G value</returns>
        /// <search>
        /// TAS, BuildingElement, Get G Value, getgvalue, Building Element, G, g value
        /// </search>
        public static double G(BuildingElement BuildingElement, int Decimals = 2)
        {
            TBD.Construction aConstruction = BuildingElement.pBuildingElement.GetConstruction();
            if (aConstruction == null)
                return 0;

            TBD.ConstructionTypes aConstructionTypes = aConstruction.type;
            if (aConstructionTypes == TBD.ConstructionTypes.tcdTransparentConstruction)
            {
                object aObject = aConstruction.GetGlazingValues();
                List<float> aValueList = Generic.Functions.GetList(aObject);
                return Math.Round(aValueList[5], Decimals);
            }
            return 0;
        }

        /// <summary>
        /// TAS Building Element Lighting Transmittance Value.
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Decimals">Decimals</param>
        /// <returns name="LT value">Lighting Trasmittance value</returns>
        /// <search>
        /// TAS, BuildingElement, Get LT Value, getltvalue, Building Element, LT, lt value, lighting Transmittace, lightingtransmittance
        /// </search>
        public static double LT(BuildingElement BuildingElement, int Decimals = 2)
        {
            TBD.Construction aConstruction = BuildingElement.pBuildingElement.GetConstruction();
            if (aConstruction == null)
                return 0;

            TBD.ConstructionTypes aConstructionTypes = aConstruction.type;
            if (aConstructionTypes == TBD.ConstructionTypes.tcdTransparentConstruction)
            {
                object aObject = aConstruction.GetGlazingValues();
                List<float> aValueList = Generic.Functions.GetList(aObject);
                return Math.Round(aValueList[0], Decimals);
            }
            return 0;
        }

        /// <summary>
        /// TAS Building Element Construction
        /// </summary>
        /// <param name="BuildingElement">Building Element</param>
        /// <param name="Construction">Construction</param>
        /// <returns name="Index">Index</returns>
        /// <search>
        /// TAS, BuildingElement, Get Construction, Building Element, set construction, setconstruction
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
        /// Gets Building Element Zone Surfaces
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

    /// <summary>
    /// TAS TBD Building Element Type
    /// </summary>  
    public enum BuildingElementType
    {
        /// <summary>Ceiling</summary>
        Ceiling = 8,
        /// <summary>Curtain Wall</summary>
        CurtainWall = 16,
        /// <summary>Door Element</summary>
        DoorElement = 14,
        /// <summary>Exposed Floor</summary>
        ExposedFloor = 19,
        /// <summary>External Wall</summary>
        ExternalWall = 2,
        /// <summary>Frame Element</summary>
        FrameELement = 15,
        /// <summary>Glazing</summary>
        Glazing = 12,
        /// <summary>Internal Floor</summary>
        InternalFloor = 4,
        /// <summary>Internal Wall</summary>
        InternallWall = 1,
        /// <summary>No Building Element Type</summary>
        NoBEType = 0,
        /// <summary>Null Element</summary>
        NullElement = 17,
        /// <summary>Raised Floor</summary>
        RaisedFloor = 10,
        /// <summary>Roof Element</summary>
        RoofElement = 3,
        /// <summary>Roof Light</summary>
        RoofLight = 13,
        /// <summary>Shade Element</summary>
        ShadeElement = 5,
        /// <summary>Slab On Grade</summary>
        SlabOnGrade = 11,
        /// <summary>Solar Panel</summary>
        SolarPanel = 18,
        /// <summary>Underground Ceiling</summary>
        UndergroundCeiling = 9,
        /// <summary>Underground Slab</summary>
        UndergroundSlab = 7,
        /// <summary>Underground Wall</summary>
        UndergroundWall = 6,
        /// <summary>Vehicle Door</summary>
        VehicleDoor = 20,
    }
}
