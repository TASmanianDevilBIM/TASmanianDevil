using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;

namespace T3DFile
{
    /// <summary>
    /// TAS T3D Zone
    /// </summary>
    public class Zone
    {
        private string pName = string.Empty;
        private string pGUID = string.Empty;

        internal TAS3D.Zone pZone;

        internal Zone(TAS3D.Zone Zone)
        {
            pZone = Zone;
            pName = pZone.name;
            pGUID = pZone.GUID;
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
            return Zone.pZone.name;   // when I connect zones returns list of Names
        }

        /// <summary>
        /// Gets TAS 3D Zone Name and Boolean
        /// </summary>
        /// <param name="Zones">TAS Zone</param>
        /// <returns name="Zone">Zone Name</returns>
        /// <returns name="HasZones">True/False</returns>
        /// <search>
        /// TAS, T3D, zone, Zone, zone, name, Name
        /// </search>
        [MultiReturn(new[] { "Zone", "HasZones" })]
        public static Dictionary<string, object> Names(List<Zone> Zones)
        {
            List<string> aNameList = new List<string>();
            foreach (Zone aZone in Zones)
            {
                aNameList.Add(aZone.pZone.name);
            }
            return new Dictionary<string, object>
            {
                { "Zone", aNameList },
                { "HasZones", aNameList.Count != 0 ? true : false }
            };
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
            Zone.pName = Name;
            return Zone;
        }

        /// <summary>
        /// Delete TAS 3D Zone
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Succeeded">Succeeded</returns>
        /// <search>
        /// TAS, zone, Zone, Delete, delete
        /// </search>
        public static bool Delete(Zone Zone)
        {
            Zone.pZone.Delete();
            return true;
        }

        /// <summary>
        /// Gets TAS 3D Zone Description
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <returns name="Description">Description</returns>
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
        /// <returns name="IsUsed">Is Used</returns>
        /// <search>
        /// TAS, Zone, zone, IsUsed, Is Used
        /// </search>
        public static bool IsUsed(Zone Zone)
        {
            if (Zone.pZone.isUsed == 1)
                return true;
            else
                return false;
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
        public static DSCore.Color Color(Zone Zone)
        {
            return Generic.Utils.UIntRGBToColor(Zone.pZone.colour);
        }

        /// <summary>
        /// Sets Zone Colour
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="Color">TAS Zone Color</param>
        /// <returns name="Zone">Zone</returns>
        /// <search>
        /// TAS, Zone, zone, ZoneSet, zoneset, Colour, SetColour, Set Color, setcolor
        /// </search>
        public static Zone SetColor(Zone Zone, DSCore.Color Color)
        {
            Zone.pZone.colour = Generic.Utils.ColorToUIntRGB(Color);
            return Zone;
        }

        /// <summary>
        /// Adds Tag to Zone
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="strTag">String Tag</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, ZoneTag, Tag, Add Tag Description, addtag, tag, add tag 
        /// </search>
        public static bool AddTag(Zone Zone, string strTag)
        {
            ///   return new Zone(Zone.pZone.AddTag(StrTag));

            bool aResult = Zone.pZone.AddTag(strTag);
            ///TAS3D.Zone aZone = Zone.pZone.AddTag(strTag);
            return aResult;
        }

        /// <summary>
        /// Gets TAS Zone Tag
        /// </summary>
        /// <param name="Zone">TAS Zone </param>
        /// <returns name="Tag">Tag Name</returns>
        /// <search>
        /// TAS, Zone Tag, Tag, Tag, tag
        /// </search>
        public static List<string> GetTags(Zone Zone)
        {
            object aObject = Zone.pZone.GetTags();
            return (aObject as string[]).ToList();
        }

        /// <summary>
        /// Remove Tags
        /// </summary>
        /// <param name="Zone">TAS Zone</param>
        /// <param name="strTag">TAS Tag</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, Tag, Delete,  Tag, tag, delete
        /// </search>
        public static bool RemoveTag(Zone Zone, string strTag)
        {
            bool aResult = Zone.pZone.RemoveTag(strTag);
            return aResult;
        }

        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return string.Format("{0} [{1} : {2}]", GetType(), pName, pGUID);
        }
    }
}
