using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{
    /// <summary>
    /// TAS T3D Building
    /// </summary>
    public class Building
    {
        private TAS3D.Building pBuilding;
        
        internal Building(TAS3D.Building Building)
        {
            pBuilding = Building;
        }

        /// <summary>
        /// Gets TAS T3D Building description XX
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Description">Building description</returns>
        /// <search>
        /// TAS, Building, Zone, Get Zone Description, builidng, zone, get zone description 
        /// </search>
        public static string Description(Building Building)
        {
            return Building.pBuilding.description;
        }

        /// <summary>
        /// Gets TAS T3D Building Zone
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Index">TAS T3D Building Zone Index</param>
        /// <returns name="Zone">Building Zone</returns>
        /// <search>
        /// TAS, Building, Zone, Get Building Zone, getbuildingzone, zoneset, GetZone, getzone
        /// </search>
        public static Zone GetZone(Building Building, int Index)
        {
            return new Zone(Building.pBuilding.GetZone(Index));
        }

        /// <summary>
        /// Sets TAS T3D Building description
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Description">Building Description</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Building, Zone, Set Zone Description, builidng, zone, set zone description, SetDescription, setdescription
        /// </search>
        public static Building SetDescription(Building Building, string Description)
        {
            Building.pBuilding.description = Description;
            return Building;
        }

        /// <summary>
        /// Gets TAS T3D Building GUID
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="GUID">Building GUID</returns>
        /// <search>
        /// TAS, Building, GUID, Get Building GUID, getbuildingguid, guid
        /// </search>
        public static string GUID(Building Building)
        {
            return Building.pBuilding.GUID;
        }

        /// <summary>
        /// Gets TAS T3D Building Name
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Name">Building Name</returns>
        /// <search>
        /// TAS, Building, Name, Get Building Name, getbuildingname, name
        /// </search>
        public static string Name(Building Building)
        {
            return Building.pBuilding.name;
        }

        /// <summary>
        /// Sets TAS T3D Building Name
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Name">Name</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Building, Name, Set Building Name, setbuildingname, name, SetName, setname
        /// </search>
        public static Building SetName(Building Building, string Name)
        {
            Building.pBuilding.name = Name;
            return Building;
        }

        /// <summary>
        /// Gets TAS T3D Building North Angle
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Angle">Building North Angle</returns>
        /// <search>
        /// TAS, Building, North Angle, Get Building North Angle, getbuildingnorthangle, northangle, NorthAngle, northangle
        /// </search>
        public static double NorthAngle(Building Building)
        {
            return Building.pBuilding.northAngle;
        }

        /// <summary>
        /// Sets TAS T3D Building North Angle
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="NorthAngle">North Angle</param>
        /// <returns name="Angle">Building North Angle</returns>
        /// <search>
        /// TAS, Building, North Angle, Set Building North Angle, setbuildingnorthangle, northangle, NorthAngle, northangle
        /// </search>
        public static Building SetNorthAngle(Building Building, double NorthAngle)
        {
            Building.pBuilding.northAngle = NorthAngle;
            return Building;
        }

        /// <summary>
        /// Gets TAS T3D Building Time Zone
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="TimeZone">Building Time Zone</returns>
        /// <search>
        /// TAS, Building, TimeZone, Get Building TimeZone, getbuildingtimezone, Time Zone, time zone, timezone
        /// </search>
        public static double TimeZone(Building Building)
        {
            return Building.pBuilding.timeZone;
        }

        /// <summary>
        /// Gets TAS T3D Building Latitude
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Latitude">Building Latitude</returns>
        /// <search>
        /// TAS, Building, Latitude, Get Building Latitude, getbuildinglatitude, latitude
        /// </search>
        public static double Latitude(Building Building)
        {
            return Building.pBuilding.latitude;
        }

        /// <summary>
        /// Sets TAS T3D Building Latitude
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Latitude">Building Latitude</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Building, Latitude, Set Building Latitude, setbuildinglatitude, latitude, SetLatitude, setlatitude
        /// </search>
        public static Building SetLatitude(Building Building, double Latitude)
        {
            Building.pBuilding.latitude = Latitude;
            return Building;
        }

        /// <summary>
        /// Gets TAS T3D Building Longitude
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Latitude">Building Latitude</returns>
        /// <search>
        /// TAS, Building, Longitude, Get Building Longitude, getbuildinglongitude, longitude
        /// </search>
        public static double Longitude(Building Building)
        {
            return Building.pBuilding.longitude;
        }

        /// <summary>
        /// Sets TAS T3D Building Longitude
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Longitude">Building Longitude</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Building, Longitude, Set Building Longitude, setbuildinglongitude, longitude
        /// </search>
        public static Building SetLongitude(Building Building, double Longitude)
        {
            Building.pBuilding.longitude = Longitude;
            return Building;
        }

        /// <summary>
        /// Gets TAS T3D Building Year
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Year">Building Year</returns>
        /// <search>
        /// TAS, Building, Year, Get Building Year, getbuildingyear, year
        /// </search>
        public static int Year(Building Building)
        {
            return Building.pBuilding.year;
        }

        /// <summary>
        /// Gets TAS T3D Building Element
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Index">TAS T3D Building Element Index</param>
        /// <returns name="Element">Building Element</returns>
        /// <search>
        /// TAS, Building, Element, Get Building Element, getbuildingelement, element, GetElement, getelement
        /// </search>
        public static Element GetElement(Building Building, int Index)
        {
            return new Element(Building.pBuilding.GetElement(Index + 1));
        }

        /// <summary>
        /// Gets TAS T3D Building Elements
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Elements">Building Elements</returns>
        /// <search>
        /// TAS, Building, Elements, Get Building Elements, getbuildingelements, elements, GetElements, getelements
        /// </search>
        public static List<Element> Elements(Building Building)
        {
            List<Element> aElementList = new List<Element>();

            int aIndex = 1;
            TAS3D.Element aElement = Building.pBuilding.GetElement(aIndex);
            while (aElement != null)
            {
                aElementList.Add(new Element(aElement));
                aIndex++;
                aElement = Building.pBuilding.GetElement(aIndex);
            }
            return aElementList;
        }

        /// <summary>
        /// Gets TAS T3D Building Name
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Name">Windows Name</param>
        /// <param name="OpeningType">Opening Type</param>
        /// <param name="Colour">Windows Colour</param>
        /// <param name="Height">Windows Height</param>
        /// <param name="Width">Windows Width</param>
        /// <param name="Level">Windows Level</param>
        /// <returns name="Window">Building Window</returns>
        /// <search>
        /// TAS, Building, Name, AddWindow, Window, addwindow, Add Window
        /// </search>
        public static Window AddWindow(Building Building, string Name, int OpeningType, uint Colour, double Height, double Width, double Level)
        {
            return new Window(Building.pBuilding.AddWindow(Name, OpeningType, Colour, Height, Width, Level));
        }

        /// <summary>
        /// Gets TAS T3D Building Window
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Index">TAS T3D Building Window Index</param>
        /// <returns name="Window">Building Window</returns>
        /// <search>
        /// TAS, Building, Window, Get Building Window, getbuildingwindow, window, GetWindow, getwindow
        /// </search>
        public static Window GetWindow(Building Building, int Index)
        {
            return new Window(Building.pBuilding.GetWindow(Index + 1));
        }

        /// <summary>
        /// Gets TAS T3D Building Windows
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Windows">Building Windows</returns>
        /// <search>
        /// TAS, Building, Windows, Get Building Windows, getbuildingwindows, Windows, GetWindows, getWindows
        /// </search>
        public static List<Window> Windows(Building Building)
        {
            List<Window> aWindowList = new List<Window>();

            int aIndex = 1;
            TAS3D.window aWindow = Building.pBuilding.GetWindow(aIndex);
            while (aWindow != null)
            {
                aWindowList.Add(new Window(aWindow));
                aIndex++;
                aWindow = Building.pBuilding.GetWindow(aIndex);
            }
            return aWindowList;
        }

        /// <summary>
        /// Adds new Zone Set to building
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Name">Zone Set Name</param>
        /// <param name="Description">Zone Set Description</param>
        /// <param name="NumberOfZones">Zone Set Number Of Zones</param>
        /// <returns name="ZoneSet">Zone Set</returns>
        /// <search>
        /// TAS, Building, AddZoneSet, builidng, zone, addzoneset
        /// </search>
        public static ZoneSet AddZoneSet(Building Building, string Name, string Description, int NumberOfZones)
        {
            return new ZoneSet(Building.pBuilding.AddZoneSet(Name, Description, NumberOfZones));
        }

        /// <summary>
        /// Gets TAS T3D Building Zone Set
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <param name="Index">TAS T3D Building Zone Set Index</param>
        /// <returns name="ZoneSet">Building Zone Set</returns>
        /// <search>
        /// TAS, Building, ZoneSet, Get Building Zone Set, getbuildingzoneset, zoneset, GetZoneSet, getzoneset
        /// </search>
        public static ZoneSet GetZoneSet(Building Building, int Index)
        {
            return new ZoneSet(Building.pBuilding.GetZoneSet(Index + 1));
        }

        /// <summary>
        /// Gets TAS T3D Building Zone Sets
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="ZoneSets">Building Zone Sets</returns>
        /// <search>
        /// TAS, Building, ZoneSets, Get Building ZoneSets, getbuildingzonesets, zonesets, Getzonesets, Zone Sets, Zone Sets, zone sets
        /// </search>
        public static List<ZoneSet> ZoneSets(Building Building)
        {
            List<ZoneSet> aZoneSetList = new List<ZoneSet>();

            int aIndex = 1;
            TAS3D.zoneSet aZoneSet = Building.pBuilding.GetZoneSet(aIndex);
            while (aZoneSet != null)
            {
                aZoneSetList.Add(new ZoneSet(aZoneSet));
                aIndex++;
                aZoneSet = Building.pBuilding.GetZoneSet(aIndex);
            }
            return aZoneSetList;
        }

        /// <summary>
        /// Gets TAS T3D Building Zone Sets
        /// </summary>
        /// <param name="Building">TAS T3D Building</param>
        /// <returns name="Zones">Building Zone Sets</returns>
        /// <search>
        /// TAS, Building, Zones, Get Building ZoneSets, getbuildingzones, zones, Getzones, Zones
        /// </search>
        public static IEnumerable<Zone> Zones(Building Building)
        {
            List<Zone> aZoneList = new List<Zone>();

            int aIndex = 1;
            TAS3D.Zone aZone = Building.pBuilding.GetZone(aIndex);
            while (aZone != null)
            {
                aZoneList.Add(new Zone(aZone));
                aIndex++;
                aZone = Building.pBuilding.GetZone(aIndex);
            }
            return aZoneList;
        }

        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return string.Format("{0} [{1} : {2}]", GetType(), pBuilding.name, pBuilding.GUID);
        }
    }
}
