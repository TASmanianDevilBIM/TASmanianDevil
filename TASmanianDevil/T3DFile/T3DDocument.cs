using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;

namespace T3DFile
{
    /// <summary>
    /// TAS T3DDocument
    /// </summary>
    public class T3DDocument : IDisposable
    {
        static private TAS3D.T3DDocument pT3DDocument;
        static private bool pSave;

        internal T3DDocument(string FilePath, bool Save)
        {
            pSave = Save;

            pT3DDocument = GetT3DDocument(pSave);
            if (pT3DDocument == null)
                pT3DDocument = new TAS3D.T3DDocument();

            pT3DDocument.Open(FilePath);
        }

        private T3DDocument(TAS3D.T3DDocument T3DDocument, bool Save)
        {
            pSave = Save;
            pT3DDocument = T3DDocument;
        }

        private static TAS3D.T3DDocument GetT3DDocument(bool Save)
        {
            TAS3D.T3DDocument aT3DDocument = null;
            try
            {
                object aObject = System.Runtime.InteropServices.Marshal.GetActiveObject("TAS3D.T3DDocument");
                if (aObject != null && aObject is TAS3D.T3DDocument)
                {
                    aT3DDocument = aObject as TAS3D.T3DDocument;
                    if (Save && !string.IsNullOrEmpty(aT3DDocument.filePath))
                        aT3DDocument.Save(aT3DDocument.filePath);
                    aT3DDocument.Close();
                }
            }
            catch
            {

            }

            return aT3DDocument;
        }

        private static void ExecutionEvents_GraphPostExecution(Dynamo.Session.IExecutionSession IExecutionSession)
        {
            pT3DDocument = GetT3DDocument(pSave);
            if (pT3DDocument != null)
            {
                if (pSave && pT3DDocument.filePath != null)
                    pT3DDocument.Save(pT3DDocument.filePath);
                pT3DDocument.Close();
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
        public static T3DDocument Open(object FilePath, bool Save = false)
        {
            //Dynamo.Events.ExecutionEvents.GraphPostExecution -= ExecutionEvents_GraphPostExecution;
            //Dynamo.Events.ExecutionEvents.GraphPostExecution += ExecutionEvents_GraphPostExecution;

            return new T3DDocument(FilePath.ToString(), Save);
        }

        /// <summary>
        /// Saves TAS T3D Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, T3DDocument, tas, t3ddocument, save t3ddocument, savet3ddocument
        /// </search>
        public static T3DDocument Save(T3DDocument T3DDocument, object FilePath)
        {
            T3DDocument.pT3DDocument.Save(FilePath.ToString());
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
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, close t3ddocument, closet3ddocument
        /// </search>
        public static bool Close(T3DDocument T3DDocument)
        {
            T3DDocument.pT3DDocument.Close();
            T3DDocument.pT3DDocument = null;
            T3DDocument = null;
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
            return T3DDocument.pT3DDocument.GetCurrentGroundLux();
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
            return T3DDocument.pT3DDocument.GetCurrentLuxResults(Zone.pZone);
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
            return T3DDocument.pT3DDocument.GetDaylightFactor(Zone.pZone);
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
            return T3DDocument.pT3DDocument.GetGroundLux(Zone.pZone);
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
            return T3DDocument.pT3DDocument.DaylightCalculation(0);
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
        public static bool DaylightCalculation(T3DDocument T3DDocument, int InitialiseZones, int IncludeAllZones, int Update3DModel)
        {
            return T3DDocument.pT3DDocument.DaylightInitCalculation(InitialiseZones, IncludeAllZones, Update3DModel, 0);
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
            return T3DDocument.pT3DDocument.DaylightSaveCalculation();
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
            return T3DDocument.pT3DDocument.GetLuxResults(Zone.pZone);
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="Name">Building Name</param>
        /// <param name="Description">Building Description</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, t3ddocument, new t3ddocument, newt3ddocument
        /// </search>
        public static T3DDocument New(string Name, string Description)
        {
            Dynamo.Events.ExecutionEvents.GraphPostExecution -= ExecutionEvents_GraphPostExecution;
            Dynamo.Events.ExecutionEvents.GraphPostExecution += ExecutionEvents_GraphPostExecution;

            pT3DDocument = GetT3DDocument(false);
            if (pT3DDocument == null)
                pT3DDocument = new TAS3D.T3DDocument();

            pT3DDocument.Building.name = Name;
            pT3DDocument.Building.description = Description;
            return new T3DDocument(pT3DDocument, false);
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
            Dynamo.Events.ExecutionEvents.GraphPostExecution -= ExecutionEvents_GraphPostExecution;
            Dynamo.Events.ExecutionEvents.GraphPostExecution += ExecutionEvents_GraphPostExecution;

            pT3DDocument = GetT3DDocument(true);
            if (pT3DDocument == null)
                pT3DDocument = new TAS3D.T3DDocument();

            pT3DDocument.Building.name = Name;
            pT3DDocument.Building.description = Description;
            pT3DDocument.filePath = FilePath;
            return new T3DDocument(pT3DDocument, true);
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
        public static bool Export(T3DDocument T3DDocument, int DayFirst, int DayLast, int DayStep, int ZoneSets, int Merge, int IncludeExternalZones, string OutputPath)
        {
            return T3DDocument.pT3DDocument.Export(DayFirst, DayLast, DayStep, ZoneSets, Merge, IncludeExternalZones, OutputPath, 0);
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
        public static bool ExportNew(T3DDocument T3DDocument, int DayFirst, int DayLast, int DayStep, int ZoneSets, int Merge, int IncludeExternalZones, string OutputPath, int AutoAssignConstructions, int AutoAssignsICs)
        {
            return T3DDocument.pT3DDocument.ExportNew(DayFirst, DayLast, DayStep, ZoneSets, Merge, IncludeExternalZones, OutputPath, AutoAssignConstructions, AutoAssignsICs, 0);
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
            return new Building(T3DDocument.pT3DDocument.Building);
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
            return new WrLWCalculation(T3DDocument.pT3DDocument.AddLW_Calculation());
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
            return T3DDocument.pT3DDocument.GetCBDMData(Create);
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
            bool aResult = T3DDocument.pT3DDocument.GetWindowData(WindowName, out aZone, out aWindow, out aArea, out aOrientation, out aCoords);

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
        [MultiReturn(new[] { "Names", "Factors"})]
        public static Dictionary<string, object> GetWindowFactors(T3DDocument T3DDocument)
        {
            object aNames = null;
            object aFactors = null;
            T3DDocument.pT3DDocument.GetWindowFactors(out aNames, out aFactors);

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
            T3DDocument.pT3DDocument.GetWindowResults(out aNames, out aPoints, out aLuxValues);

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
        ///  <param name="ZonesFromSpaces">ZonesFromSpaces</param>
        /// <returns name="Result">Boolean result of operation</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, ImportGBXML, Import GBXML, import gbxml
        /// </search>
        public static bool ImportGBXML(T3DDocument T3DDocument, string Path, int Overwrite, int ReverseIncorrectSurfaces, int ZonesFromSpaces)
        {
            return T3DDocument.pT3DDocument.ImportGBXML(Path, Overwrite, ReverseIncorrectSurfaces, ZonesFromSpaces);
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
            return T3DDocument.pT3DDocument.IsSunUp(Day, Hour, Minutes);
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
            return T3DDocument.pT3DDocument.SetLuxResults(Zone.pZone, WrLWCalculation.pWrLWCalculation, Results, GroundLux);
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
            return T3DDocument.pT3DDocument.SetProcessIdle(Value);
        }

        void IDisposable.Dispose()
        {
            if (pT3DDocument != null)
            {
                pT3DDocument.Close();
                pT3DDocument = null;
            }

        }
    }
}