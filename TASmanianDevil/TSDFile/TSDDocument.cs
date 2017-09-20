using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS TSDDocument
    /// </summary>
    public class TSDDocument : Generic.Document
    {
        internal TSDDocument(string FilePath, bool Save)
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
                return "TSD.Document";
            }
        }

        protected override void Create()
        {
            Document = new TSD.TSDDocument();
        }

        protected override void Save()
        {
            Document.save();
        }

        protected override void Open()
        {
            Document.open(FilePath);
        }

        protected static TSD.TSDDocument Document
        {
            get
            {
                return Object as TSD.TSDDocument;
            }
            set
            {
                Object = value;
            }
        }

        /// <summary>
        /// Opens TAS TSD Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="Save">If true file will be saved</param>
        /// <returns name="TSDDocument">TSD Document</returns>
        /// <search>
        /// TAS, TSDDocument, tas, tsddocument, open tsddocument, opentsddocument
        /// </search>
        public static TSDDocument Open(object FilePath, bool Save = false)
        {
            return new TSDDocument(FilePath.ToString(), Save);
        }

        /// <summary>
        /// Gets TAS Simulation Data
        /// </summary>
        /// <param name="TSDDocument">TSD Document</param>
        /// <returns name="SimulationData">TAS Simulation Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, SimulationData, Get Building, tas, tsddocument, tsddocument simulation data, simulationdata
        /// </search>
        public static SimulationData SimulationData(TSDDocument TSDDocument)
        {
            return new SimulationData(Document.SimulationData);
        }

        /// <summary>
        /// Close TAS TSD Document. READ ME ==============
        /// Option 1 = File will be close when Dynamo is restarted
        /// if you use Dynamo with Revit you need to restart both
        /// Option 2 = when script is done and you confirmed it was saved just 
        /// go to TaskManager and End Process for TSD.exe 
        /// </summary>
        /// <param name="TSDDocument">TSD Document</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, TSDDocument, tas, TSDDdocument, close tsddocument, closetsddocument
        /// </search>
        public static bool Close(TSDDocument TSDDocument)
        {
            Document.close();
            return true;
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="Path">Building Name</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, new tbddocument, newtbddocument
        /// </search>
        public static TSDDocument New(string Path)
        {
            TSDDocument aTSDDocument = new TSDDocument(FilePath, true);
            Document.SimulationData.buildingPath = Path;
            return aTSDDocument;
        }

        /// <summary>
        /// Saves TAS TBD Document
        /// </summary>
        /// <param name="TSDDocument">TSDDocument</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, save tbddocument, savetbddocument
        /// </search>
        public static bool Save(TSDDocument TSDDocument)
        {
            TSDDocument.Save();
            return true;
        }
    }
}
