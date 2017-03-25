using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace T3DFile
{
    /// <summary>
    /// TAS T3DDocument
    /// </summary>
    public class T3DDocument : TASmanianDevil.Document
    {
        private T3DDocument(string FilePath, bool Save)
            : base(FilePath, Save)
        {

        }

        protected override void Close()
        {
            Document.Close();
        }

        protected override string ActiveObjectName
        {
            get
            {
                return "T3D.Document";
            }
        }

        protected override void Create()
        {
            Document = new TAS3D.T3DDocument();
        }

        protected override void Save()
        {
            Document.Save(FilePath);
        }

        protected override void Open()
        {
            Document.Open(FilePath);
        }

        protected static TAS3D.T3DDocument Document
        {
            get
            {
                return Object as TAS3D.T3DDocument;
            }
            set
            {
                Object = value;
            }
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="Save">If true file will be saved</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, T3DDocument, tas, t3ddocument, open t3ddocument, opent3ddocument
        /// </search>
        public static T3DDocument Open(object FilePath, bool Save)
        {
            return new T3DDocument(FilePath.ToString(), Save);
        }

        /// <summary>
        /// Saves TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, T3DDocument, tas, t3ddocument, save t3ddocument, savet3ddocument
        /// </search>
        public static T3DDocument Save(T3DDocument T3DDocument)
        {
            T3DDocument.Save();
            return T3DDocument;
        }

        /// <summary>
        /// Closes TAS T3D Document. READ ME ==============
        /// Option 1 = File will be close when Dynamo is restarted
        /// if you use Dynamo with Revit you need to restart both
        /// Option 2 = when script is done and you confirmed it was saved just 
        /// go to TaskManager and End Process for TAS3D.exe 
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Save">Save file</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, close t3ddocument, closet3ddocument
        /// </search>
        public static bool Close(T3DDocument T3DDocument)
        {
            T3DDocument.Close();
            return true;
        }

        /// <summary>
        /// TAS T3D Document Current Ground Lux
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Value">Current Ground Lux</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, Current Ground Lux, CurrentGroundLux, GetCurrentGroundLux
        /// </search>
        public static double GetCurrentGroundLux(T3DDocument T3DDocument)
        {
            return Document.GetCurrentGroundLux();
        }

        /// <summary>
        /// Gets TAS T3D Document Current Lux Results
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Values">Current Lux Results</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, Current Ground Lux, GetCurrentLuxResults, Get Current Lux Results, getcurrentluxresults
        /// </search>
        public static object GetCurrentLuxResults(T3DDocument T3DDocument, Zone Zone)
        {
            return Document.GetCurrentLuxResults(Zone.pZone);
        }

        /// <summary>
        /// Gets TAS T3D Document Daylight Factor
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Value">Current Lux Results</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, GetDaylightFactor, Get Daylight Factor, getdaylightfactor
        /// </search>
        public static double GetDaylightFactor(T3DDocument T3DDocument, Zone Zone)
        {
            return Document.GetDaylightFactor(Zone.pZone);
        }

        /// <summary>
        /// Gets TAS T3D Document Ground Lux
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Value">Ground Lux</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, GetGroundLux, Get Ground Lux, getgroundlux
        /// </search>
        public static double GetGroundLux(T3DDocument T3DDocument, Zone Zone)
        {
            return Document.GetGroundLux(Zone.pZone);
        }

        /// <summary>
        /// Gets TAS T3D Document Daylight Calculation
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Result">DaylightCalculation</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, DaylightCalculation, Daylight Calculation, daylight calculation
        /// </search>
        public static bool DaylightCalculation(T3DDocument T3DDocument)
        {
            return Document.DaylightCalculation(0);
        }

        /// <summary>
        /// Gets TAS T3D Document Daylight Calculation
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="InitialiseZones">Initialise Zones</param>
        /// <param name="IncludeAllZones">Include All Zones</param>
        /// <param name="Update3DModel">Update 3D Model</param>
        /// <returns name="Result">DaylightCalculation</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, DaylightCalculation, Daylight Calculation, daylight calculation
        /// </search>
        public static bool DaylightCalculation(T3DDocument T3DDocument, bool InitialiseZones, bool IncludeAllZones, bool Update3DModel)
        {
            int aInitialiseZones = 0;
            if (InitialiseZones)
                aInitialiseZones = 1;

            int aIncludeAllZones = 0;
            if (IncludeAllZones)
                aIncludeAllZones = 1;

            int aUpdate3DModel = 0;
            if (Update3DModel)
                aUpdate3DModel = 1;

            return Document.DaylightInitCalculation(aInitialiseZones, aIncludeAllZones, aUpdate3DModel, 0);
        }

        /// <summary>
        /// Daylight Saves Calculation to TAS T3D Document
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Result">Daylight Save Calculation</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, DaylightSaveCalculation, Daylight Save Calculation, daylightsavecalculation
        /// </search>
        public static bool DaylightSaveCalculation(T3DDocument T3DDocument)
        {
            return Document.DaylightSaveCalculation();
        }

        /// <summary>
        /// Gets TAS T3D Document Lux Results
        /// ======== NOT TESTED YET ======
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Value">Lux Results</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, GetLuxResults, Get Lux Results, getluxresults
        /// </search>
        public static object GetLuxResults(T3DDocument T3DDocument, Zone Zone)
        {
            return Document.GetLuxResults(Zone.pZone);
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="Name">Building Name</param>
        /// <param name="Description">Building Description</param>
        /// <param name="FilePath">File Path</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, new tbddocument, newtbddocument
        /// </search>
        public static T3DDocument New(string FilePath, string Name, string Description)
        {
            T3DDocument aT3DDocument = new T3DDocument(FilePath, true);
            Document.Building.name = Name;
            Document.Building.description = Description;

            return aT3DDocument;
        }

        /// <summary>
        /// Exports TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="DayFirst">Day First</param>
        /// <param name="DayLast">Day Last</param>
        /// <param name="DayStep">Day Step</param>
        /// <param name="ZoneSets">Zone Sets</param>
        /// <param name="Merge">Merge</param>
        /// <param name="IncludeExternalZones">Include External Zones</param>
        /// <param name="OutputPath">Output Path</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, export t3ddocument, exportt3ddocument
        /// </search>
        public static bool Export(T3DDocument T3DDocument, int DayFirst, int DayLast, int DayStep, int ZoneSets, int Merge, bool IncludeExternalZones, string OutputPath)
        {
            int aIncludeExternalZones = 0;
            if (IncludeExternalZones)
                aIncludeExternalZones = 1;

            return Document.Export(DayFirst, DayLast, DayStep, ZoneSets, Merge, aIncludeExternalZones, OutputPath, 0);
        }

        /// <summary>
        /// Exports TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="DayFirst">Day First</param>
        /// <param name="DayLast">Day Last</param>
        /// <param name="DayStep">Day Step</param>
        /// <param name="ZoneSets">Zone Sets</param>
        /// <param name="Merge">Merge</param>
        /// <param name="IncludeExternalZones">Include External Zones</param>
        /// <param name="OutputPath">Output Path</param>
        /// <param name="AutoAssignConstructions">Auto Assign Constructions</param>
        /// <param name="AutoAssignsICs">Auto Assigns Internal Conditions</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, export t3ddocument, exportt3ddocument
        /// </search>
        public static bool ExportNew(T3DDocument T3DDocument, int DayFirst, int DayLast, int DayStep, int ZoneSets, int Merge, bool IncludeExternalZones, string OutputPath, int AutoAssignConstructions, int AutoAssignsICs)
        {
            int aIncludeExternalZones = 0;
            if (IncludeExternalZones)
                aIncludeExternalZones = 1;

            return Document.ExportNew(DayFirst, DayLast, DayStep, ZoneSets, Merge, aIncludeExternalZones, OutputPath, AutoAssignConstructions, AutoAssignsICs, 0);
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Building">TAS Building</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, Building, Get Building, tas, t3ddocument, t3ddocument building
        /// </search>
        public static Building Building(T3DDocument T3DDocument)
        {
            return new Building(Document.Building);
        }

        /// <summary>
        /// Adds LW Calculation to TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="WrLWCalculation">Wr LW Calculation</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, Building, WrLWCalculation, Wr LW Calculation, wrlwcalculation, wr lw calculation
        /// </search>
        public static WrLWCalculation AddLWCalculation(T3DDocument T3DDocument)
        {
            return new WrLWCalculation(Document.AddLW_Calculation());
        }

        /// <summary>
        /// Gets CBDM Data from TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Create">Create</param>
        /// <returns name="CBDMData">CBDM Data</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, GetCBDMData, Get CBDM Data, getcbdmdata, get cbdm data
        /// </search>
        public static object GetCBDMData(T3DDocument T3DDocument, int Create)
        {
            return Document.GetCBDMData(Create);
        }

        /// <summary>
        /// Gets Window Data from TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="WindowName">Window Name</param>
        /// <returns name="WindowData">Window Data</returns>
        /// <returns name="Zone">Zone</returns>
        /// <returns name="Window">Window</returns>
        /// <returns name="Area">Area</returns>
        /// <returns name="Orientation">Orientation</returns>
        /// <returns name="Coords">Coords</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, GetWindowData, Get Window Data, getwindowdata, get window data
        /// </search>
        [MultiReturn(new[] { "WindowData", "Zone", "Window", "Area", "Orientation", "Coords" })]
        public static Dictionary<string, object> GetWindowData(T3DDocument T3DDocument, string WindowName)
        {
            TAS3D.Zone aZone = null;
            TAS3D.window aWindow = null;
            double aArea = double.MinValue;
            double aOrientation = double.MinValue;
            object aCoords = null;
            bool aResult = Document.GetWindowData(WindowName, out aZone, out aWindow, out aArea, out aOrientation, out aCoords);

            return new Dictionary<string, object>
            {
                {"WindowData", aResult},
                {"Zone", new Zone(aZone) },
                {"Window", new Window(aWindow) },
                {"Area", aArea },
                {"Orientation", aOrientation },
                {"Coords", aCoords }
            };

        }

        /// <summary>
        /// Gets Window Factors from TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Names">Names</returns>
        /// <returns name="Factors">Factors</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, GetWindowFactors, Get Window Factors, getwindowfactors
        /// </search>
        [MultiReturn(new[] { "Names", "Factors" })]
        public static Dictionary<string, object> GetWindowFactors(T3DDocument T3DDocument)
        {
            object aNames = null;
            object aFactors = null;
            Document.GetWindowFactors(out aNames, out aFactors);

            return new Dictionary<string, object>
            {
                {"Names", aNames},
                {"Factors", aFactors },
            };

        }

        /// <summary>
        /// Gets Window Results from TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Names">Names</returns>
        /// <returns name="Points">Points</returns>
        /// <returns name="LuxValues">Lux Values</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, GetWindowFactors, Get Window Results, getwindowresults
        /// </search>
        [MultiReturn(new[] { "Names", "Points", "LuxValues" })]
        public static Dictionary<string, object> GetWindowResults(T3DDocument T3DDocument)
        {
            object aNames = null;
            object aPoints = null;
            object aLuxValues = null;
            Document.GetWindowResults(out aNames, out aPoints, out aLuxValues);

            return new Dictionary<string, object>
            {
                {"Names", aNames},
                {"Points", aPoints },
                {"LuxValues", aLuxValues }
            };

        }

        /// <summary>
        /// Imports GBXML File to TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Path">File Path</param>
        /// <param name="Overwrite">Overwrite</param>
        /// <param name="ReverseIncorrectSurfaces">Reverse Incorrect Surfaces</param>
        /// <param name="ZonesFromSpaces">ZonesFromSpaces</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <returns name="Succeeded">Succeeded</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, ImportGBXML, Import GBXML, import gbxml
        /// </search>
        [MultiReturn(new[] { "T3DDocument", "Succeeded"})]
        public static Dictionary<string, object> ImportGBXML(T3DDocument T3DDocument, string Path, bool Overwrite, bool ReverseIncorrectSurfaces, bool ZonesFromSpaces)
        {
            bool aSucceeded = false;

            int aOverwrite = 0;
            if (Overwrite)
                aOverwrite = 1;

            int aReverseIncorrectSurfaces = 0;
            if (ReverseIncorrectSurfaces)
                aReverseIncorrectSurfaces = 1;

            int aZonesFromSpaces = 0;
            if (ZonesFromSpaces)
                aZonesFromSpaces = 1;

            try
            {
                if (Document.ImportGBXML(Path, aOverwrite, aReverseIncorrectSurfaces, aZonesFromSpaces))
                    aSucceeded = true;
            }
            catch
            {
                aSucceeded = false;
            }

            return new Dictionary<string, object>
            {
                {"T3DDocument", T3DDocument},
                {"Succeeded", aSucceeded }
            };
        }

        /// <summary>
        /// Check if is sun up for TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Day">Day</param>
        /// <param name="Hour">Hour</param>
        /// <param name="Minutes">Minutes</param>
        /// <returns name="IsSunUp">Is Sun Up</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, issunup, IsSunUp, is sun up, Is Sun Up
        /// </search>
        public static bool IsSunUp(T3DDocument T3DDocument, int Day, int Hour, int Minutes)
        {
            return Document.IsSunUp(Day, Hour, Minutes);
        }

        /// <summary>
        /// Check if is sun up for TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <param name="WrLWCalculation">Wr LW Calculation</param>
        /// <param name="Results">Array of results</param>
        /// <param name="GroundLux">Ground Lux</param>
        /// <returns name="Result">Result of operation</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, set lux results, SetLuxResults, Set Lux Results, setluxresults
        /// </search>
        public static bool SetLuxResults(T3DDocument T3DDocument, Zone Zone, WrLWCalculation WrLWCalculation, object Results, double GroundLux)
        {
            return Document.SetLuxResults(Zone.pZone, WrLWCalculation.pWrLWCalculation, Results, GroundLux);
        }

        /// <summary>
        /// Set process idle for TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Value">Value</param>
        /// <returns name="Result">Result of operation</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, set process idle, SetProcessIdle, Set Process Idle, setprocessidle
        /// </search>
        public static bool SetProcessIdle(T3DDocument T3DDocument, string Value)
        {
            return Document.SetProcessIdle(Value);
        }

        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return string.Format("{0} [{1}]", GetType(), FilePath);
        }
    }
}