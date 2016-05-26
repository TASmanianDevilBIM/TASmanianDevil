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

		// From here
        /// <summary>
        /// Gets TAS Building description
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Description">Building description</returns>
        /// <search>
        /// TAS, Builidng, Zone, Get Zone Description, builidng, zone, get zone description 
        /// </search>
        public static string Description(Building Building)
        {
            return Building.pBuilding.description;
        }
		// To here

        /// <summary>
        /// Sets TAS Building description
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Description">Building Description</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Builidng, Zone, Set Zone Description, builidng, zone, set zone description, SetDescription, setdescription
        /// </search>
        public static Building SetDescription(Building Building, string Description)
        {
            Building.pBuilding.description = Description;
            return Building;
        }

        /// <summary>
        /// Gets TAS Building GUID
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="GUID">Building GUID</returns>
        /// <search>
        /// TAS, Builidng, GUID, Get Building GUID, getbuildingguid, guid
        /// </search>
        public static string GUID(Building Building)
        {
            return Building.pBuilding.GUID;
        }

        /// <summary>
        /// Gets TAS Building Name
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Name">Building Name</returns>
        /// <search>
        /// TAS, Builidng, Name, Get Building Name, getbuildingname, name
        /// </search>
        public static string Name(Building Building)
        {
            return Building.pBuilding.name;
        }

        /// <summary>
        /// Sets TAS Building Name
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Name">Name</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Builidng, Name, Set Building Name, setbuildingname, name, SetName, setname
        /// </search>
        public static Building SetName(Building Building, string Name)
        {
            Building.pBuilding.name = Name;
            return Building;
        }

        /// <summary>
        /// Gets TAS Building North Angle
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Angle">Building North Angle</returns>
        /// <search>
        /// TAS, Builidng, North Angle, Get Building North Angle, getbuildingnorthangle, northangle, NorthAngle, northangle
        /// </search>
        public static double NorthAngle(Building Building)
        {
            return Building.pBuilding.northAngle;
        }

        /// <summary>
        /// Sets TAS Building North Angle
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="NorthAngle">North Angle</param>
        /// <returns name="Angle">Building North Angle</returns>
        /// <search>
        /// TAS, Builidng, North Angle, Set Building North Angle, setbuildingnorthangle, northangle, NorthAngle, northangle
        /// </search>
        public static Building SetNorthAngle(Building Building, double NorthAngle)
        {
            Building.pBuilding.northAngle = NorthAngle;
            return Building;
        }

        /// <summary>
        /// Gets TAS Building Time Zone
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="TimeZone">Building Time Zone</returns>
        /// <search>
        /// TAS, Builidng, TimeZone, Get Building TimeZone, getbuildingtimezone, Time Zone, time zone, timezone
        /// </search>
        public static double TimeZone(Building Building)
        {
            return Building.pBuilding.timeZone;
        }

        /// <summary>
        /// Gets TAS Building Latitude
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Latitude">Building Latitude</returns>
        /// <search>
        /// TAS, Builidng, Latitude, Get Building Latitude, getbuildinglatitude, latitude
        /// </search>
        public static double Latitude(Building Building)
        {
            return Building.pBuilding.latitude;
        }

        /// <summary>
        /// Sets TAS Building Latitude
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Latitude">Building Latitude</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Builidng, Latitude, Set Building Latitude, setbuildinglatitude, latitude, SetLatitude, setlatitude
        /// </search>
        public static Building SetLatitude(Building Building, double Latitude)
        {
            Building.pBuilding.latitude = Latitude;
            return Building;
        }

        /// <summary>
        /// Gets TAS Building Longitude
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Latitude">Building Latitude</returns>
        /// <search>
        /// TAS, Builidng, Longitude, Get Building Longitude, getbuildinglongitude, longitude
        /// </search>
        public static double Longitude(Building Building)
        {
            return Building.pBuilding.longitude;
        }

        /// <summary>
        /// Sets TAS Building Longitude
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Longitude">Building Longitude</param>
        /// <returns name="Building">Building</returns>
        /// <search>
        /// TAS, Builidng, Longitude, Set Building Longitude, setbuildinglongitude, longitude
        /// </search>
        public static Building SetLongitude(Building Building, double Longitude)
        {
            Building.pBuilding.longitude = Longitude;
            return Building;
        }

        /// <summary>
        /// Gets TAS Building Year
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Year">Building Year</returns>
        /// <search>
        /// TAS, Builidng, Year, Get Building Year, getbuildingyear, year
        /// </search>
        public static int Year(Building Building)
        {
            return Building.pBuilding.year;
        }

        /// <summary>
        /// Gets TAS Building Element
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">TAS Building Element Index</param>
        /// <returns name="Element">Building Element</returns>
        /// <search>
        /// TAS, Builidng, Element, Get Building Element, getbuildingelement, element, GetElement, getelement
        /// </search>
        public static Element GetElement(Building Building, int Index)
        {
            return new Element(Building.pBuilding.GetElement(Index + 1));
        }

        /// <summary>
        /// Gets TAS Building Elements
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Elements">Building Elements</returns>
        /// <search>
        /// TAS, Builidng, Elements, Get Building Elements, getbuildingelements, elements, GetElements, getelements
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
        /// Gets TAS Building Name
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Name">Windows Name</param>
        /// <param name="OpeningType">Opening Type</param>
        /// <param name="Colour">Windows Colour</param>
        /// <param name="Height">Windows Height</param>
        /// <param name="Width">Windows Width</param>
        /// <param name="Level">Windows Level</param>
        /// <returns name="Window">Building Window</returns>
        /// <search>
        /// TAS, Builidng, Name, AddWindow, Window, addwindow, Add Window
        /// </search>
        public static Window AddWindow(Building Building, string Name, int OpeningType, uint Colour, double Height, double Width, double Level)
        {
            return new Window(Building.pBuilding.AddWindow(Name, OpeningType, Colour, Height, Width, Level));
        }

        /// <summary>
        /// Gets TAS Building Window
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">TAS Building Window Index</param>
        /// <returns name="Window">Building Window</returns>
        /// <search>
        /// TAS, Builidng, Window, Get Building Window, getbuildingwindow, window, GetWindow, getwindow
        /// </search>
        public static Window GetWindow(Building Building, int Index)
        {
            return new Window(Building.pBuilding.GetWindow(Index + 1));
        }

        /// <summary>
        /// Gets TAS Building Windows
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Windows">Building Windows</returns>
        /// <search>
        /// TAS, Builidng, Windows, Get Building Windows, getbuildingwindows, Windows, GetWindows, getWindows
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
        /// <param name="Building">TAS Building</param>
        /// <param name="Name">Zone Set Name</param>
        /// <param name="Description">Zone Set Description</param>
        /// <param name="NumberOfZones">Zone Set Number Of Zones</param>
        /// <returns name="ZoneSet">Zone Set</returns>
        /// <search>
        /// TAS, Builidng, AddZoneSet, builidng, zone, addzoneset
        /// </search>
        public static ZoneSet AddZoneSet(Building Building, string Name, string Description, int NumberOfZones)
        {
            return new ZoneSet(Building.pBuilding.AddZoneSet(Name, Description, NumberOfZones));
        }

        /// <summary>
        /// Gets TAS Building Zone Set
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">TAS Building Zone Set Index</param>
        /// <returns name="ZoneSet">Building Zone Set</returns>
        /// <search>
        /// TAS, Builidng, ZoneSet, Get Building Zone Set, getbuildingzoneset, zoneset, GetZoneSet, getzoneset
        /// </search>
        public static ZoneSet GetZoneSet(Building Building, int Index)
        {
            return new ZoneSet(Building.pBuilding.GetZoneSet(Index + 1));
        }

        /// <summary>
        /// Gets TAS Building Zone Sets
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="ZoneSets">Building Zone Sets</returns>
        /// <search>
        /// TAS, Builidng, ZoneSets, Get Building ZoneSets, getbuildingzonesets, zonesets, Getzonesets, Zone Sets, Zone Sets, zone sets
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
        /// Gets TAS Building Zone
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <param name="Index">TAS Building Zone Index</param>
        /// <returns name="Zone">Building Zone</returns>
        /// <search>
        /// TAS, Builidng, Zone, Get Building Zone, getbuildingzone, zoneset, GetZone, getzone
        /// </search>
        public static Zone GetZone(Building Building, int Index)
        {
            return new Zone(Building.pBuilding.GetZone(Index));
        }

        

        /// <summary>
        /// Gets TAS Building Zone Sets
        /// </summary>
        /// <param name="Building">TAS Building</param>
        /// <returns name="Zones">Building Zone Sets</returns>
        /// <search>
        /// TAS, Builidng, Zones, Get Building ZoneSets, getbuildingzones, zones, Getzones, Zones
        /// </search>
        public static List<Zone> Zones(Building Building)
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

        
    }
}
