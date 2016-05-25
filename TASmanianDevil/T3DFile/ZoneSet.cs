using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{
    /// <summary>
    /// TAS T3D Zone Set
    /// </summary>
    public class ZoneSet
    {
        internal TAS3D.zoneSet pZoneSet;

        internal ZoneSet(TAS3D.zoneSet ZoneSet)
        {
            pZoneSet = ZoneSet;
        }

        /// <summary>
        /// Adds Zone to s Zone Set
        /// </summary>
        /// <param name="ZoneSet">TAS Building</param>
        /// <param name="Name">TAS Zone Name</param>
        /// <param name="Description">TAS Zone Description</param>
        /// <returns name="Zone">TAS Zone</returns>
        /// <search>
        /// TAS, ZoneSet, Zone, Add Zone Description, zoneset, zone, add zone 
        /// </search>
        public static Zone AddZone(ZoneSet ZoneSet, string Name, string Description)
        {
            TAS3D.Zone aZone = ZoneSet.pZoneSet.AddZone();
            aZone.name = Name;
            aZone.description = Description;
            return new Zone(aZone);
        }

        /// <summary>
        /// Gets TAS Zone Set Name
        /// </summary>
        /// <param name="ZoneSet">TAS Zone Set</param>
        /// <returns name="Name">Zone Set Name</returns>
        /// <search>
        /// TAS, ZoneSet, zoneset, Zone Set, zone set, name, Name
        /// </search>
        public static string Name(ZoneSet ZoneSet)
        {
            return ZoneSet.pZoneSet.name;
        }

        /// <summary>
        /// Deletes Zone Set
        /// </summary>
        /// <param name="ZoneSet">TAS Zone Set</param>
        /// <returns name="Name">Zone Set Name</returns>
        /// <search>
        /// TAS, ZoneSet, Delete, zoneset, Zone Set, zone set, delete
        /// </search>
        public static string Delete(ZoneSet ZoneSet)
        {
            string aResult = ZoneSet.pZoneSet.name;
            ZoneSet.pZoneSet.Delete();
            return aResult;
        }

        /// <summary>
        /// Gets TAS Zone Set Description
        /// </summary>
        /// <param name="ZoneSet">TAS Zone Set</param>
        /// <returns name="Description">Zone Set Description</returns>
        /// <search>
        /// TAS, ZoneSet, zoneset, Zone Set, zone set, Description, description
        /// </search>
        public static string Description(ZoneSet ZoneSet)
        {
            return ZoneSet.pZoneSet.description;
        }

        /// <summary>
        /// Gets TAS Zone Set Number Of Zones
        /// </summary>
        /// <param name="ZoneSet">TAS Zone Set</param>
        /// <returns name="Count">Zone Set Number Of Zones</returns>
        /// <search>
        /// TAS, ZoneSet, zoneset, Zone Set, zone set, NumOfZones, numofzones, Number Of Zones, number of zones
        /// </search>
        public static int NumOfZones(ZoneSet ZoneSet)
        {
            return ZoneSet.pZoneSet.numOfZones;
        }

        /// <summary>
        /// Gets TAS Zone Set Name
        /// </summary>
        /// <param name="ZoneSet">TAS Zone Set</param>
        /// <returns name="ReadOnly">If Zone Set is read only then true</returns>
        /// <search>
        /// TAS, ZoneSet, zoneset, Zone Set, zone set, ReadOnly, readonly, Read Only, read only
        /// </search>
        public static bool ReadOnly(ZoneSet ZoneSet)
        {
            return ZoneSet.pZoneSet.readOnly;
        }

        /// <summary>
        /// Gets TAS Zone Set Zones
        /// </summary>
        /// <param name="ZoneSet">TAS Zone Set</param>
        /// <returns name="Zones">Zone Set Zones</returns>
        /// <search>
        /// TAS, ZoneSet, zoneset, Zone Set, zone set, Zones, zones
        /// </search>
        public static List<Zone> Zones(ZoneSet ZoneSet)
        {
            List<Zone> aZoneList = new List<Zone>();

            int aIndex = 0;
            TAS3D.Zone aZone = ZoneSet.pZoneSet.GetZone(aIndex);
            while (aZone != null)
            {
                aZoneList.Add(new Zone(aZone));
                aIndex++;
                aZone = ZoneSet.pZoneSet.GetZone(aIndex);
            }
            return aZoneList;
        }

        /// <summary>
        /// Gets TAS Building Zone Set
        /// </summary>
        /// <param name="ZoneSet">TAS ZoneSet</param>
        /// <param name="Index">TAS Zone Index</param>
        /// <returns name="Zone">Building Zone</returns>
        /// <search>
        /// TAS, Builidng, Zone, Get Building Zone, getbuildingzone, zone, GetZone, getzone
        /// </search>
        public static Zone GetZone(ZoneSet ZoneSet, int Index)
        {
            return new Zone(ZoneSet.pZoneSet.GetZone(Index));
        }
    }
}
