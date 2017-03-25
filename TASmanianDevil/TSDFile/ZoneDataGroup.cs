using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{

    /// <summary>
    /// TAS TSD Zone Data Group
    /// </summary>
    public class ZoneDataGroup
    {
        private TSD.ZoneDataGroup pZoneDataGroup;

        internal ZoneDataGroup(TSD.ZoneDataGroup ZoneDataGroup)
        {
            pZoneDataGroup = ZoneDataGroup;
        }

        public static int ZoneCount(ZoneDataGroup ZoneDataGroup)
        {
            return ZoneDataGroup.pZoneDataGroup.zoneCount;
        }

        public static string Name(ZoneDataGroup ZoneDataGroup)
        {
            return ZoneDataGroup.pZoneDataGroup.name;
        }

        public static string Description(ZoneDataGroup ZoneDataGroup)
        {
            return ZoneDataGroup.pZoneDataGroup.description;
        }

        public static ZoneData GetZoneData(ZoneDataGroup ZoneDataGroup, int Index = 1)
        {
            return new ZoneData(ZoneDataGroup.pZoneDataGroup.GetZoneData(Index));
        }

        public static List<ZoneData> GetZonesData(ZoneDataGroup ZoneDataGroup)
        {
            List<ZoneData> aZoneDataGroupList = new List<ZoneData>();

            int aIndex = 1;
            TSD.ZoneData aZoneData = ZoneDataGroup.pZoneDataGroup.GetZoneData(aIndex);
            while (aZoneData != null)
            {
                aZoneDataGroupList.Add(new ZoneData(aZoneData));
                aIndex++;
                aZoneData = ZoneDataGroup.pZoneDataGroup.GetZoneData(aIndex);
            }
            return aZoneDataGroupList;
        }

    }
}
