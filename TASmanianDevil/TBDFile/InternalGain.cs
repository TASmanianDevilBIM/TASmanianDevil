using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Internal Gain
    /// </summary>
    public class InternalGain
    {
        private TBD.InternalGain pInternalGain;

        internal InternalGain(TBD.InternalGain InternalGain)
        {
            pInternalGain = InternalGain;
        }

        /// <summary>
        /// Internal Gain Description
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, Internal Gain, Description, InternalGain
        /// </search>
        public static string Description(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.description;
        }

        /// <summary>
        /// Sets Internal Gain Description
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Description">Internal Gain Description</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, Description, InternalGain, SetDescription
        /// </search>
        public static InternalGain SetDescription(InternalGain InternalGain, string Description)
        {
            InternalGain.pInternalGain.description = Description;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Activity ID
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="ID">Activity ID</returns>
        /// <search>
        /// TAS, Internal Gain, Activity ID, InternalGain, activityID, activityid
        /// </search>
        public static int ActivityID(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.activityID;
        }

        /// <summary>
        /// Ssts Internal Gain Activity ID
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="ActivityID">ActivityID</param>
        /// <returns name="ID">Activity ID</returns>
        /// <search>
        /// TAS, Internal Gain, Activity ID, InternalGain, activityID, activityid, SetActivityID
        /// </search>
        public static InternalGain SetActivityID(InternalGain InternalGain, int ActivityID)
        {
            InternalGain.pInternalGain.activityID = ActivityID;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Domestic Hot Water
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="DomesticHotWater">Domestic Hot Water</returns>
        /// <search>
        /// TAS, Internal Gain, Domestic Hot Water, InternalGain
        /// </search>
        public static float DomesticHotWater(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.domesticHotWater;
        }

        /// <summary>
        /// Sets Internal Gain Domestic Hot Water
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Domestic Hot Water Value</param>
        /// <returns name="InternalGain">InternalGain</returns>
        /// <search>
        /// TAS, Internal Gain, Domestic Hot Water, InternalGain
        /// </search>
        public static InternalGain SetDomesticHotWater(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.domesticHotWater = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Equipment Rad Prop
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Value">Equipment Rad Prop</returns>
        /// <search>
        /// TAS, Internal Gain, Equipment Rad Prop, InternalGain, equipmentradprop
        /// </search>
        public static float EquipmentRadProp(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.equipmentRadProp;
        }

        /// <summary>
        /// Sets Internal Gain Equipment Rad Prop
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Equipment Rad Prop Value</param>
        /// <returns name="Value">Equipment Rad Prop</returns>
        /// <search>
        /// TAS, Internal Gain, Equipment Rad Prop, InternalGain, equipmentradprop, SetEquipmentRadProp
        /// </search>
        public static InternalGain SetEquipmentRadProp(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.equipmentRadProp = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Equipment View Coefficient
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Coefficient">EquipmentViewCoefficient</returns>
        /// <search>
        /// TAS, Internal Gain, Description, InternalGain
        /// </search>
        public static float EquipmentViewCoefficient(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.equipmentViewCoefficient;
        }

        /// <summary>
        /// Sets Internal Gain Equipment View Coefficient
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Equipment View Coefficient Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, Description, InternalGain, SetEquipmentViewCoefficient, SetEquipmentViewCoefficient
        /// </search>
        public static InternalGain SetEquipmentViewCoefficient(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.equipmentViewCoefficient = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Freash Air Rate
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Rate">Freash Air Rate</returns>
        /// <search>
        /// TAS, Internal Gain, Freash Air Rate, InternalGain
        /// </search>
        public static float FreashAirRate(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.freshAirRate;
        }

        /// <summary>
        /// Sets Fresh Air Rate
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Internal Gain Fresh Air Rate Value</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Internal Gain, SetFreshAirRate, InternalGain
        /// </search>
        public static InternalGain SetFreshAirRate(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.freshAirRate = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Profile
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Index">Profile Index</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Internal Gain, Profile, InternalGain, getprofile, get profile
        /// </search>
        public static Profile GetProfile(InternalGain InternalGain, int Index)
        {
            return new Profile(InternalGain.pInternalGain.GetProfile(Index));
        }

        /// <summary>
        /// Gets Profiles from Internal Gain
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Profiles">Profile List</returns>
        /// <search>
        /// TAS, Internal Gain, internal gains, Profiles, Get Profiles, tas, Internal Gain, zones, get zones
        /// </search>
        public static List<Profile> Profiles(InternalGain InternalGain)
        {
            List<Profile> aProfileList = new List<Profile>();

            int aIndex = 0;
            TBD.profile aProfile = InternalGain.pInternalGain.GetProfile(aIndex);
            while (aProfile != null)
            {
                aProfileList.Add(new Profile(aProfile));
                aIndex++;
                aProfile = InternalGain.pInternalGain.GetProfile(aIndex);
            }
            return aProfileList;
        }

        /// <summary>
        /// Internal Gain Lighting Rad Prop
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Value">Lighting Rad Prop</returns>
        /// <search>
        /// TAS, Internal Gain, LightingRadProp, InternalGain, Lighting Rad Prop
        /// </search>
        public static float LightingRadProp(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.lightingRadProp;
        }

        /// <summary>
        /// Set Internal Gain Lighting Rad Prop
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Lighting Rad Prop Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, LightingRadProp, InternalGain, Lighting Rad Prop, SetLightingRadProp
        /// </search>
        public static InternalGain SetLightingRadProp(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.lightingRadProp = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Lighting View Coefficient
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Coefficient">LightingViewCoefficient</returns>
        /// <search>
        /// TAS, Internal Gain, LightingViewCoefficient, InternalGain, Lighting View Coefficient
        /// </search>
        public static float LightingViewCoefficient(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.lightingViewCoefficient;
        }

        /// <summary>
        /// Sets Internal Gain Lighting View Coefficient
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Lighting View Coefficient Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, LightingViewCoefficient, InternalGain, Lighting View Coefficient, SetLightingViewCoefficient
        /// </search>
        public static InternalGain SetLightingViewCoefficient(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.lightingViewCoefficient = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Name
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Internal Gain, Name, InternalGain
        /// </search>
        public static string Name(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.name;
        }

        /// <summary>
        /// Sets Internal Gain Name
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Name">Internal Gain Name</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, Name, InternalGain, SetName
        /// </search>
        public static InternalGain SetName(InternalGain InternalGain, string Name)
        {
            InternalGain.pInternalGain.name = Name;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Occupant Rad Prop
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Value">Occupant Rad Prop</returns>
        /// <search>
        /// TAS, Internal Gain, OccupantRadProp, InternalGain, Occupant Rad Prop
        /// </search>
        public static float OccupantRadProp(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.occupantRadProp;
        }

        /// <summary>
        /// Sets Internal Gain Occupant Rad Prop
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Occupant Rad Prop Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, OccupantRadProp, InternalGain, Occupant Rad Prop, SetOccupantRadProp
        /// </search>
        public static InternalGain SetOccupantRadProp(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.occupantRadProp = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Occupant View Coefficient
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="Coefficient">Occupant View Coefficient</returns>
        /// <search>
        /// TAS, Internal Gain, Occupant View Coefficient, InternalGain, OccupantViewCoefficient
        /// </search>
        public static float OccupantViewCoefficient(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.occupantViewCoefficient;
        }

        /// <summary>
        /// Sets Internal Gain Occupant View Coefficient
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Occupant View Coefficient Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, Occupant View Coefficient, InternalGain, OccupantViewCoefficient, SetOccupantViewCoefficient
        /// </search>
        public static InternalGain SetOccupantViewCoefficient(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.occupantViewCoefficient = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Person Gain
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="PersonGain">Person Gain</returns>
        /// <search>
        /// TAS, Internal Gain, PersonGain, InternalGain, Person Gain
        /// </search>
        public static float PersonGain(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.personGain;
        }

        /// <summary>
        /// Sets Internal Gain Person Gain
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Person Gain Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, PersonGain, InternalGain, Person Gain, SetPersonGain
        /// </search>
        public static InternalGain SetPersonGain(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.personGain = Value;
            return InternalGain;
        }

        /// <summary>
        /// Internal Gain Target Illuminance
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <returns name="TargetIlluminance">Target Illuminance</returns>
        /// <search>
        /// TAS, Internal Gain, TargetIlluminance, InternalGain, Target Illuminance
        /// </search>
        public static float TargetIlluminance(InternalGain InternalGain)
        {
            return InternalGain.pInternalGain.targetIlluminance;
        }

        /// <summary>
        /// Sets Internal Gain Target Illuminance
        /// </summary>
        /// <param name="InternalGain">TAS Internal Gain</param>
        /// <param name="Value">Target Illuminance Value</param>
        /// <returns name="InternalGain">Internal Gain</returns>
        /// <search>
        /// TAS, Internal Gain, TargetIlluminance, InternalGain, Target Illuminance, SetTargetIlluminance
        /// </search>
        public static InternalGain SetTargetIlluminance(InternalGain InternalGain, float Value)
        {
            InternalGain.pInternalGain.targetIlluminance = Value;
            return InternalGain;
        }
    }
}
