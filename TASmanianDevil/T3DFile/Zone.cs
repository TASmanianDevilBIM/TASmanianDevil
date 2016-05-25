using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{
    /// <summary>
    /// TAS T3D Zone
    /// </summary>
    public class Zone
    {
        internal TAS3D.Zone pZone;

        internal Zone(TAS3D.Zone Zone)
        {
            pZone = Zone;
        }

        /// <summary>
        /// Gets TAS 3D Zone Name
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Name">Zone Name</returns>
        /// <search>
        /// TAS, Zone, zone, Zone, zone, name, Name
        /// </search>
        public static string Name(Zone Zone)
        {
            return Zone.pZone.name;
        }

        /// <summary>
        /// Sets TAS 3D Zone Name
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Name">Zone Name</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, zone, Zone, name, Name
        /// </search>
        public static Zone SetName(Zone Zone, string Name)
        {
            Zone.pZone.name = Name;
            return Zone;
        }

        /// <summary>
        /// Gets TAS 3D Zone Description
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, description, Description
        /// </search>
        public static string Description(Zone Zone)
        {
            return Zone.pZone.description;
        }

        /// <summary>
        /// Sets TAS 3D Zone Description
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Description">Zone Description</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, zone, Zone, description, Description
        /// </search>
        public static Zone SetDescription(Zone Zone, string Description)
        {
            Zone.pZone.description = Description;
            return Zone;
        }

        /// <summary>
        /// Gets TAS 3D Zone external
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="External">External</returns>
        /// <search>
        /// TAS, Zone, zone, external, External
        /// </search>
        public static bool External(Zone Zone)
        {
            return Zone.pZone.external;
        }

        /// <summary>
        /// Sets TAS 3D Zone External
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="External">Zone External</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, zone, Zone, external, External
        /// </search>
        public static Zone SetExternal(Zone Zone, bool External)
        {
            Zone.pZone.external = External;
            return Zone;
        }

        /// <summary>
        /// Gets TAS 3D Zone GUID
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="GUID">GUID</returns>
        /// <search>
        /// TAS, Zone, zone, GUID
        /// </search>
        public static string GUID(Zone Zone)
        {
            return Zone.pZone.GUID;
        }

        /// <summary>
        /// Check is zone is used
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="IsUsed">IsUsed</returns>
        /// <search>
        /// TAS, Zone, zone, IsUsed, Is Used
        /// </search>
        public static int IsUsed(Zone Zone)
        {
            return Zone.pZone.isUsed;
        }

        /// <summary>
        /// Gets ZoneSet of the Zone
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="ZoneSet">ZoneSet</returns>
        /// <search>
        /// TAS, Zone, zone, ZoneSet, zoneset
        /// </search>
        public static ZoneSet ZoneSet(Zone Zone)
        {
            return new ZoneSet(Zone.pZone.zoneSet);
        }

        /// <summary>
        /// Sets ZoneSet for the Zone
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="ZoneSet">TAS ZoneSet</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, ZoneSet, zoneset, SetZoneSet
        /// </search>
        public static Zone SetZoneSet(Zone Zone, ZoneSet ZoneSet)
        {
            Zone.pZone.zoneSet = ZoneSet.pZoneSet;
            return Zone;
        }

        /// <summary>
        /// Gets Zone Colour
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Colour">Colour</returns>
        /// <search>
        /// TAS, Zone, zone, ZoneSet, zoneset, Colour
        /// </search>
        public static uint Colour(Zone Zone)
        {
            return Zone.pZone.colour;
        }

        /// <summary>
        /// Sets Zone Colour
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Colour">TAS Zone Colour</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, ZoneSet, zoneset, Colour, SetColour
        /// </search>
        public static Zone SetColour(Zone Zone, uint Colour)
        {
            Zone.pZone.colour = Colour;
            return Zone;
        }

    }
}
