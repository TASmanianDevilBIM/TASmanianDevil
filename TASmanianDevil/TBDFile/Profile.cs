using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Profile
    /// </summary>
    public class Profile
    {
        private TBD.profile pProfile;

        internal Profile(TBD.profile Profile)
        {
            pProfile = Profile;
        }

        /// <summary>
        /// Profile Name
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Name">Profile Name</returns>
        /// <search>
        /// TAS, Profile, Name, profile, name
        /// </search>
        public static string Name(Profile Profile)
        {
            return Profile.pProfile.name;
        }

        /// <summary>
        /// Profile Profiles
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Profiles">Profiles</returns>
        /// <search>
        /// TAS, Profile, Profiles, profile, Profiles
        /// </search>
        public static Profiles Profiles(Profile Profile)
        {
            return (Profiles)(int)Profile.pProfile.profile;
        }

        /// <summary>
        /// Sets Profile Profiles
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Profiles">Profiles</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, Profiles, profile, Profiles, SetProfiles
        /// </search>
        public static Profile SetProfiles(Profile Profile, Profiles Profiles)
        {
            Profile.pProfile.profile = (TBD.Profiles)(int)Profiles;
            return Profile; 
        }

        /// <summary>
        /// Profile Type
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="ProfileType">Profile Type</returns>
        /// <search>
        /// TAS, Profile, Type, profile, type
        /// </search>
        public static ProfileType ProfileType(Profile Profile)
        {
            return (ProfileType)(int)Profile.pProfile.type;
        }

        /// <summary>
        /// Profile Type
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="ProfileType">Profile Type</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, Type, profile, type, SetProfileType
        /// </search>
        public static Profile SetProfileType(Profile Profile, ProfileType ProfileType)
        {
            Profile.pProfile.type = (TBD.ProfileTypes)(int)ProfileType;
            return Profile;
        }

        /// <summary>
        /// Sets Profile Name
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Name">Name</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, Name, profile, name, SetName
        /// </search>
        public static Profile SetName(Profile Profile, string Name)
        {
            Profile.pProfile.name = Name;
            return Profile; 
        }

        /// <summary>
        /// Profile Description
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Description">Profile Description</returns>
        /// <search>
        /// TAS, Profile, Description, profile, description
        /// </search>
        public static string Description(Profile Profile)
        {
            return Profile.pProfile.description;
        }

        /// <summary>
        /// Sets Profile Description
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Description">Profile Description</param>
        /// <returns name="Description">Profile Description</returns>
        /// <search>
        /// TAS, Profile, Description, profile, description, SetDescription
        /// </search>
        public static Profile SetDescription(Profile Profile, string Description)
        {
            Profile.pProfile.description = Description;
            return Profile;
        }

        /// <summary>
        /// Profile Factor
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Factor">Profile Factor</returns>
        /// <search>
        /// TAS, Profile, Factor, profile, factor
        /// </search>
        public static float Factor(Profile Profile)
        {
            return Profile.pProfile.factor;
        }

        /// <summary>
        /// Sets Profile Factor
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Value">Factor Value</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, Factor, profile, factor, SetFactor
        /// </search>
        public static Profile SetFactor(Profile Profile, float Value)
        {
            Profile.pProfile.factor = Value;
            return Profile;
        }

        /// <summary>
        /// Profile Function
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Function">Profile Function</returns>
        /// <search>
        /// TAS, Profile, Function, profile, function
        /// </search>
        public static string Function(Profile Profile)
        {
            return Profile.pProfile.function;
        }

        /// <summary>
        /// Sets Profile Function
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Function">Profile Function</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, Function, profile, function, SetFunction
        /// </search>
        public static Profile SetFunction(Profile Profile, string Function)
        {
            Profile.pProfile.function = Function;
            return Profile;
        }

        /// <summary>
        /// Profile Function
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="FindMax">Find Max</param>
        /// <returns name="Value">Extreme Value</returns>
        /// <search>
        /// TAS, Profile, GetExtremeValue, profile, Extreme Value, Get Extreme Value
        /// </search>
        public static float GetExtremeValue(Profile Profile, bool FindMax)
        {
            return Profile.pProfile.GetExtremeValue(FindMax);
        }

        /// <summary>
        /// Get Yearly Values of Profile
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Values">Yearly Values</returns>
        /// <search>
        /// TAS, Profile, Yearly Values, profile, GetYearlyValues
        /// </search>
        public static object GetYearlyValues(Profile Profile)
        {
            return Profile.pProfile.GetYearlyValues();
        }

        /// <summary>
        /// Profile Hourly Values
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Index">Index</param> 
        /// <returns name="HourlyValues">HourlyValues</returns>
        /// <search>
        /// TAS, Profile, HourlyValues, profile, Hourly Values, hourlyvalues
        /// </search>
        public static float HourlyValues(Profile Profile, int Index)
        {
            return Profile.pProfile.hourlyValues[Index];
        }

        /// <summary> 
        /// Profile Setback Value
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Value">Setback Value</returns>
        /// <search>
        /// TAS, Profile, Setback Value, profile, SetbackValue
        /// </search>
        public static float SetbackValue(Profile Profile)
        {
            return Profile.pProfile.setbackValue;
        }

        /// <summary>
        /// Sets Profile Setback Value
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Value">Setback Value</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, Setback Value, profile, SetbackValue, SetSetbackValue
        /// </search>
        public static Profile SetSetbackValue(Profile Profile, float Value)
        {
            Profile.pProfile.setbackValue = Value;
            return Profile;
        }

        /// <summary>
        /// Profile Units
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Units">Profile Units</returns>
        /// <search>
        /// TAS, Profile, Units, profile, units
        /// </search>
        public static string Units(Profile Profile)
        {
            return Profile.pProfile.units;
        }

        /// <summary>
        /// Sets Profile Units
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Units">Profile Units</param>
        /// <returns name="Units">Profile Units</returns>
        /// <search>
        /// TAS, Profile, Units, profile, units, SetUnits
        /// </search>
        public static Profile SetUnits(Profile Profile, string Units)
        {
            Profile.pProfile.units = Units;
            return Profile;
        }

        /// <summary>
        /// Profile Use Daylight Adjustment
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Value">Use Daylight Adjustment Value</returns>
        /// <search>
        /// TAS, Profile, UseDaylightAdjustment, profile, Use Daylight Adjustment
        /// </search>
        public static int UseDaylightAdjustment(Profile Profile)
        {
            return Profile.pProfile.useDaylightAdjustment;
        }

        /// <summary>
        /// SetsProfile Use Daylight Adjustment
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Value">Profile Use Daylight Adjustment value</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Profile, UseDaylightAdjustment, profile, Use Daylight Adjustment
        /// </search>
        public static Profile SetUseDaylightAdjustment(Profile Profile, int Value)
        {
            Profile.pProfile.useDaylightAdjustment = Value;
            return Profile;
        }

        /// <summary>
        /// Profile Value
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Value">Profile Value</returns>
        /// <search>
        /// TAS, Profile, Value, profile, value
        /// </search>
        public static float Value(Profile Profile)
        {
            return Profile.pProfile.value;
        }

        /// <summary>
        /// Sets Profile Value
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Value">Value</param>
        /// <returns name="Value">Profile Value</returns>
        /// <search>
        /// TAS, Profile, Value, profile, value
        /// </search>
        public static Profile SetValue(Profile Profile, float Value)
        {
            Profile.pProfile.value = Value;
            return Profile; 
        }

        /// <summary>
        /// Profile Yearly Values
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Index">Index</param>
        /// <returns name="YearlyValues">Profile Values</returns>
        /// <search>
        /// TAS, Profile, YearlyValues, profile, Yearly Values, yearly values, yearlyvalues
        /// </search>
        public static float YearlyValues(Profile Profile, int Index)
        {
            return Profile.pProfile.yearlyValues[Index];
        }

        /// <summary>
        /// Sets Profile Yearly Values
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Index">Index</param>
        /// <param name="Value">Yearly Values</param>
        /// <returns name="YearlyValues">Profile Values</returns>
        /// <search>
        /// TAS, Profile, YearlyValues, profile, Yearly Values, yearly values, yearlyvalues, SetYearlyValues
        /// </search>
        public static Profile SetYearlyValues(Profile Profile, int Index, float Value)
        {
            Profile.pProfile.yearlyValues[Index] = Value;
            return Profile; 
        }

        /// <summary>
        /// Profile Schedule
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <returns name="Schedule">Profile Schedule</returns>
        /// <search>
        /// TAS, Profile, Schedule, profile, schedule
        /// </search>
        public static Schedule Schedule(Profile Profile)
        {
            return new Schedule(Profile.pProfile.schedule);
        }

        /// <summary>
        /// Set Profile Schedule
        /// </summary>
        /// <param name="Profile">Profile</param>
        /// <param name="Schedule">Schedule</param>
        /// <returns name="Schedule">Profile Schedule</returns>
        /// <search>
        /// TAS, Profile, Schedule, profile, schedule, SetSchedule
        /// </search>
        public static Profile SetSchedule(Profile Profile, Schedule Schedule)
        {
            Profile.pProfile.schedule = Schedule.pSchedule;
            return Profile;
        }
    }

    /// <summary>
    /// TAS Profiles
    /// </summary>
    public enum Profiles
    {
        /// <summary>tic UL</summary>
        ticUL = 1,
        /// <summary>tic LL</summary>
        ticLL = 2,
        /// <summary>tic HC</summary>
        ticHC = 3,
        /// <summary>tic CC</summary>
        ticCC = 4,
        /// <summary>tic HUL</summary>
        ticHUL = 5,
        /// <summary>tic HLL</summary>
        ticHLL = 6,
        /// <summary>tic I</summary>
        ticI = 7,
        /// <summary>tic V</summary>
        ticV = 8,
        /// <summary>tic LG</summary>
        ticLG = 9,
        /// <summary>tic OSG</summary>
        ticOSG = 10,
        /// <summary>tic OLG</summary>
        ticOLG = 11,
        /// <summary>tic ESG</summary>
        ticESG = 12,
        /// <summary>tic ELG</summary>
        ticELG = 13,
        /// <summary>tbd FS proportion</summary>
        tbdFSproportion = 14,
        /// <summary>tbd SE proportion</summary>
        tbdSEproportion = 15,
        /// <summary>tbd AT opening</summary>
        tbdATopening = 16,
        /// <summary>tbd IZAM air Movement</summary>
        tbdIZAMairMovement = 17,
        /// <summary>tic COG</summary>
        ticCOG = 18,
        /// <summary>tic ASG</summary>
        ticASG = 19,
        /// <summary>tic ALG</summary>
        ticALG = 20,
        /// <summary>tbd Ext Pollutant</summary>
        tbdExtPollutant = 21
    }

    /// <summary>
    /// TAS Profile Types
    /// </summary>
    public enum ProfileType
    {
        /// <summary>tic Value Profile</summary>
        ticValueProfile = 1,
        /// <summary>tic Hourly Profile</summary>
        ticHourlyProfile = 2,
        /// <summary>tic Yearly Profile</summary>
        ticYearlyProfile = 3,
        /// <summary>tic Function Profile</summary>
        ticFunctionProfile = 4,
        /// <summary>tic Yearly Function Profile</summary>
        ticYearlyFunctionProfile = 5,
        /// <summary>tic Hourly Function Profile</summary>
        ticHourlyFunctionProfile = 6
    }
}
