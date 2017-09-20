using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS TBD Substitute Element
    /// </summary>
    public class SubstituteElement
    {
        internal TBD.SubstituteElement pSubstituteElement;

        internal SubstituteElement(TBD.SubstituteElement SubstituteElement)
        {
            pSubstituteElement = SubstituteElement;
        }

        /// <summary>
        /// Gets TAS T3D Substitute Element Name
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <returns name="Name">Substitute Element Name</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, Name, name
        /// </search>
        public static string Name(SubstituteElement SubstituteElement)
        {
            return SubstituteElement.pSubstituteElement.name;
        }

        /// <summary>
        /// Sets TAS T3D Substitute Element Name
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <param name="Name">TAS TBD Substitute Element Name</param>
        /// <returns name="SubstituteElement">Substitute Element</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, Name, name, SetName, Set Name, setname
        /// </search>
        public static SubstituteElement SetName(SubstituteElement SubstituteElement, string Name)
        {
            SubstituteElement.pSubstituteElement.name = Name;
            return SubstituteElement;
        }

        /// <summary>
        /// Gets TAS T3D Substitute Element Description
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <returns name="Description">Substitute Element Description</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, Description, description
        /// </search>
        public static string Description(SubstituteElement SubstituteElement)
        {
            return SubstituteElement.pSubstituteElement.description;
        }

        /// <summary>
        /// Sets TAS T3D Substitute Element Description
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <param name="Description">TAS TBD Substitute Description</param>
        /// <returns name="Description">Substitute Element Description</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, Description, description, SetDescription, Set Description
        /// </search>
        public static SubstituteElement SetDescription(SubstituteElement SubstituteElement, string Description)
        {
            SubstituteElement.pSubstituteElement.description = Description;
            return SubstituteElement;
        }

        /// <summary>
        /// Gets TAS T3D Substitute Element Description
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <param name="Index">TAS TBD Substitute Element Index</param>
        /// <returns name="Description">Substitute Element Description</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, GetBuildingElement, getbuildingelement
        /// </search>
        public static BuildingElement GetBuildingElement(SubstituteElement SubstituteElement, int Index)
        {
            return new BuildingElement(SubstituteElement.pSubstituteElement.GetBuildingElement(Index));
        }

        /// <summary>
        /// Gets all TAS TBD Substitute Element Day Types
        /// </summary>
        /// <param name="SubstituteElement">Substitute Element</param>
        /// <returns name="DayTypes">Day Type List</returns>
        /// <search>
        /// TAS, TBD, SubstituteElement, Substitute Element, DayTypes, GetDayTypes, Day Types
        /// </search>
        public static List<BuildingElement> BuildingElements(SubstituteElement SubstituteElement)
        {
            List<BuildingElement> aBuildingElementList = new List<BuildingElement>();

            int aIndex = 0;
            TBD.buildingElement aBuildingElement = SubstituteElement.pSubstituteElement.GetBuildingElement(aIndex);
            while (aBuildingElement != null)
            {
                aBuildingElementList.Add(new BuildingElement(aBuildingElement));
                aIndex++;
                aBuildingElement = SubstituteElement.pSubstituteElement.GetBuildingElement(aIndex);
            }
            return aBuildingElementList;
        }

        /// <summary>
        /// Gets TAS T3D Substitute Element Day Type
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <param name="Index">Index</param>
        /// <returns name="Name">Substitute Element Name</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, DayType, Day Type, daytype, GetDayType, Get Day Type, getdaytype
        /// </search>
        public static DayType GetDayType(SubstituteElement SubstituteElement, int Index)
        {
            return new DayType(SubstituteElement.pSubstituteElement.GetDayType(Index));
        }

        /// <summary>
        /// Gets all TAS TBD Substitute Element Day Types
        /// </summary>
        /// <param name="SubstituteElement">Substitute Element</param>
        /// <returns name="DayTypes">Day Type List</returns>
        /// <search>
        /// TAS, TBD, SubstituteElement, Substitute Element, DayTypes, GetDayTypes, Day Types
        /// </search>
        public static List<DayType> DayTypes(SubstituteElement SubstituteElement)
        {
            List<DayType> aDayTypeList = new List<DayType>();

            int aIndex = 0;
            TBD.dayType aDayType = SubstituteElement.pSubstituteElement.GetDayType(aIndex);
            while (aDayType != null)
            {
                aDayTypeList.Add(new DayType(aDayType));
                aIndex++;
                aDayType = SubstituteElement.pSubstituteElement.GetDayType(aIndex);
            }
            return aDayTypeList;
        }

        /// <summary>
        /// Gets TAS T3D Substitute Element Profile
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <returns name="Profile">Substitute Element Profile</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, Profile, profile, GetProfile, Get Profile, getprofile
        /// </search>
        public static Profile GetProfile(SubstituteElement SubstituteElement)
        {
            return new Profile(SubstituteElement.pSubstituteElement.GetProfile());
        }

        /// <summary>
        /// Gets TAS T3D Substitute Element of Substitute Element
        /// </summary>
        /// <param name="SubstituteElement">TAS TBD Substitute Element</param>
        /// <returns name="BuildingElement">Building Element</returns>
        /// <search>
        /// TAS, SubstituteElement, substituteelement, Substitute Element, GetSubstituteElement, Get Substitute Element
        /// </search>
        public static BuildingElement GetSubstituteElement(SubstituteElement SubstituteElement)
        {
            return new BuildingElement(SubstituteElement.pSubstituteElement.GetSubstituteElement());
        }
    }
}
