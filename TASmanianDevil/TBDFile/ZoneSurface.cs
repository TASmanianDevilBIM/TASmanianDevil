using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Zone Surface
    /// </summary>
    public class ZoneSurface
    {
        private TBD.zoneSurface pZoneSurface;

        internal ZoneSurface(TBD.zoneSurface ZoneSurface)
        {
            pZoneSurface = ZoneSurface;
        }

        /// <summary>
        /// Gets TAS Zone Surface GUID
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="GUID">Zone GUID</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, GUID, guid
        /// </search>
        public static string GUID(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.GUID;
        }

        /// <summary>
        /// Gets TAS Zone Surface Altitude
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Altitude">Zone Altitude</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Altitude, altitude
        /// </search>
        public static float Altitude(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.altitude;
        }

        /// <summary>
        /// Gets TAS Zone Surface Area
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Area">Zone Area</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Area, area
        /// </search>
        public static float Area(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.area;
        }

        /// <summary>
        /// Gets TAS Zone Surface Building Element
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="BuildingElement">Zone Building Element</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, GetBuildingElement, Get Building Element, getbuildingelement, get building element
        /// </search>
        public static BuildingElement GetBuildingElement(ZoneSurface ZoneSurface)
        {
            return new BuildingElement(ZoneSurface.pZoneSurface.buildingElement);
        }

        /// <summary>
        /// Sets TAS Zone Surface Building Element
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <param name="BuildingElement">TAS Building Element</param>
        /// <returns name="ZoneSurface">TAS Zone Surface</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, SetBuildingElement, Set Building Element, setbuildingelement, set building element
        /// </search>
        public static ZoneSurface SetBuildingElement(ZoneSurface ZoneSurface, BuildingElement BuildingElement)
        {
            ZoneSurface.pZoneSurface.buildingElement = BuildingElement.pBuildingElement;
            return ZoneSurface;
        }

        /// <summary>
        /// Gets TAS Zone Surface Inclination
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Inclination">Zone Inclination</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Inclination, inclination
        /// </search>
        public static float Inclination(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.inclination;
        }

        /// <summary>
        /// Gets TAS Zone Surface Inclination
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="InternalArea">Zone Internal Area</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, InternalArea, internal area, internalarea, InternalArea
        /// </search>
        public static float InternalArea(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.internalArea;
        }

        /// <summary>
        /// Gets TAS Link Zone Surface
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="ZoneSurface">Link Zone Surface</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, ZoneSurface, Zone Surface, Link Zone Surface, LinkSurface, linksurface, link surface
        /// </search>
        public static ZoneSurface LinkSurface(ZoneSurface ZoneSurface)
        {
            return new ZoneSurface(ZoneSurface.pZoneSurface.linkSurface);
        }

        /// <summary>
        /// Gets TAS Zone Surface Number
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Number">Zone Surface Number</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Number, number
        /// </search>
        public static int Number(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.number;
        }

        /// <summary>
        /// Gets TAS Zone Surface Orientation
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Orientation">Zone Surface Orientation</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Orientation, orientation
        /// </search>
        public static float Orientation(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.orientation;
        }

        /// <summary>
        /// Gets TAS Zone Surface Reversed
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Reversed">Zone Surface Reversed</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Reversed, reversed
        /// </search>
        public static int Reversed(ZoneSurface ZoneSurface)
        {
            return ZoneSurface.pZoneSurface.reversed;
        }

        /// <summary>
        /// Gets TAS Zone Surface Reversed
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Reversed">Zone Surface Reversed</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Reversed, reversed
        /// </search>
        public static SurfaceType Type(ZoneSurface ZoneSurface)
        {
            return (SurfaceType)(int)ZoneSurface.pZoneSurface.type;
        }

        /// <summary>
        /// Gets TAS Zone Surface Zone
        /// </summary>
        /// <param name="ZoneSurface">TAS Zone Surface</param>
        /// <returns name="Zone">Surface Zone</returns>
        /// <search>
        /// TAS, ZoneSurface, Zone Surface, zonesurface, zone surface, Zone, zone
        /// </search>
        public static Zone Zone(ZoneSurface ZoneSurface)
        {
            return new Zone(ZoneSurface.pZoneSurface.zone);
        }
    }

    /// <summary>
    /// TAS TBD Construction Types
    /// </summary>  
    public enum SurfaceType
    {
        /// <summary>Ground Surface Type</summary>
        Ground = 0,
        /// <summary>Exposed Surface Type</summary>
        Exposed = 1,
        /// <summary>Internal Surface Type</summary>
        Internal = 2,
        /// <summary>Link Surface Type</summary>
        Link = 3,
        /// <summary>Null Link Surface Type</summary>
        NullLink = 4
    }
}
