using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS TBDDocument
    /// </summary>
    public class TBDDocument : TASmanianDevil.Document
    {

        internal TBDDocument(string FilePath, bool Save)
            : base(FilePath, Save)
        {
               
        }

        protected override void Close()
        {
            Document.close();
        }

        protected override string ActiveObjectName
        {
            get
            {
                return "TBD.Document";
            }
        }

        protected override void Create()
        {
            Document = new TBD.TBDDocument();
        }

        protected override void Save()
        {
            Document.save();
        }

        protected override void Open()
        {
            Document.open(FilePath);
        }

        protected static TBD.TBDDocument Document
        {
            get
            {
                return Object as TBD.TBDDocument;
            }
            set
            {
                Object = value;
            }
        }

        /// <summary>
        /// End Merge TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, EndMerge, End Merge, endmerge, end merge
        /// </search>
        public static TBDDocument EndMerge(TBDDocument TBDDocument)
        {
            Document.EndMerge();
            return TBDDocument;
        }

        /// <summary>
        /// Imports Shading Data to TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <param name="Path">Path</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, ImportShadingData, Import Shading Data, importshadingdata, import shading data
        /// </search>
        public static TBDDocument ImportShadingData(TBDDocument TBDDocument, string Path)
        {
            Document.ImportShadingData(Path);
            return TBDDocument;
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="Save">If true file will be saved</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, open tbddocument, opentbddocument
        /// </search>
        public static TBDDocument Open(object FilePath, bool Save = false)
        {
            return new TBDDocument(FilePath.ToString(), Save);
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="Name">Building Name</param>
        /// <param name="Description">Building Description</param>
        /// <param name="FilePath">File Path</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, new tbddocument,newtbddocument
        /// </search>
        public static TBDDocument New(string FilePath, string Name, string Description)
        {
            TBDDocument aTBDDocument = new TBDDocument(FilePath, true);
            Document.Building.name = Name;
            Document.Building.description = Description;
            return aTBDDocument;
        }

        /// <summary>
        /// Saves TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, save tbddocument, opentbddocument
        /// </search>
        public static TBDDocument Save(TBDDocument TBDDocument)
        {
            Document.save();
            return TBDDocument;
        }

        /// <summary>
        /// Close TAS TBD Document. READ ME ==============
        /// Option 1 = File will be close when Dynamo is restarted
        /// if you use Dynamo with Revit you need to restart both
        /// Option 2 = when script is done and you confirmed it was saved just 
        /// go to TaskManager and End Process for TBD.exe 
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="integer">integer</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, close tbddocument, closebddocument
        /// </search>
        public static bool Close(TBDDocument TBDDocument)
        {
            TBDDocument.Close();
            return true;
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="Building">TAS Building</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, Building, Get Building, tas, tbddocument, tbddocument building
        /// </search>
        public static Building Building(TBDDocument TBDDocument)
        {
            return new Building(Document.Building);
        }

        /// <summary>
        /// TAS TBD Document sizing
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="Sizing">Sizing</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, Building, sizing, Sizing
        /// </search>
        public static int Sizing(TBDDocument TBDDocument)
        {
            return Document.sizing(0);
        }

        /// <summary>
        /// Simulates TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <param name="StartDay">Start Day</param>
        /// <param name="EndDay">EndDay</param>
        /// <param name="AutoViewResults">Auto View Results</param>
        /// <param name="OutputAperture">Output Aperture</param>
        /// <param name="OutputAll">Output All</param>
        /// <param name="Merge">Merge</param>
        /// <param name="TSDPath">TSD File Path</param>
        /// <param name="WeightingFactors">Weighting Factors</param>
        /// <returns name="Integer">Integer</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, Building, Simulate Building, tas, tbddocument, tbddocument building
        /// </search>
        public static int Simulate(TBDDocument TBDDocument, int StartDay, int EndDay, int AutoViewResults, int OutputAperture, int OutputAll, int Merge, string TSDPath, int WeightingFactors)
        {
            return Document.simulate(StartDay, EndDay, AutoViewResults, OutputAperture, OutputAll, Merge, TSDPath, WeightingFactors, 0);
        }
    }
}
