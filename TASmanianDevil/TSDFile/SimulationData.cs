using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS Simulation Data
    /// </summary>
    public class SimulationData
    {
        private TSD.SimulationData pSimulationData;

        internal SimulationData(TSD.SimulationData SimulationData)
        {
            pSimulationData = SimulationData;
        }

        /// <summary>
        /// Gets TAS Cooling Design Data
        /// </summary>
        /// <param name="SimulationData">TSD Simulation Data</param>
        /// <param name="Index">Data Index</param>
        /// <returns name="CoolingDesignData">TAS Cooling Design Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Building, tas, tsddocument, tsddocument Cooling Design Data, coolingdesigndata
        /// </search>
        public static CoolingDesignData CoolingDesignData(SimulationData SimulationData, int Index)
        {
            return new CoolingDesignData(SimulationData.pSimulationData.GetCoolingDesignData(Index));
        }

        /// <summary>
        /// Gets TAS Heating Design Data
        /// </summary>
        /// <param name="SimulationData">TSD Simulation Data</param>
        /// <param name="Index">Data Index</param>
        /// <returns name="HeatingDesignData">TAS Heating Design Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Building, tas, tsddocument, tsddocument Heating Design Data, heatingdesigndata
        /// </search>
        public static HeatingDesignData HeatingDesignData(SimulationData SimulationData, int Index)
        {
            return new HeatingDesignData(SimulationData.pSimulationData.GetHeatingDesignData(Index));
        }

        /// <summary>
        /// Gets TAS Building Data
        /// </summary>
        /// <param name="SimulationData">TSD Simulation Data</param>
        /// <returns name="BuildingData">TAS Cooling Design Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, BuildingData, Get Building, tas, tsddocument, tsddocument BuildingData, buildingdata
        /// </search>
        public static BuildingData BuildingData(SimulationData SimulationData)
        {
            return new BuildingData(SimulationData.pSimulationData.GetBuildingData());
        }

        /// <summary>
        /// Gets Simulation Data Buliding Path
        /// </summary>
        /// <param name="SimulationData">TSD Simulation Data</param>
        /// <returns name="Path">Building Path</returns>
        /// <search>
        /// TAS, TBDDocument, tbddocument, SimulationData, Simulation Data, simulationdata, simulation data, BuildingPath, Building Path, building path, buildingpath
        /// </search>
        public static string BuildingPath(SimulationData SimulationData)
        {
            return SimulationData.pSimulationData.buildingPath;
        }

        /// <summary>
        /// Gets Simulation Data First Day
        /// </summary>
        /// <param name="SimulationData">TSD Simulation Data</param>
        /// <returns name="FirstDay">First Day</returns>
        /// <search>
        /// TAS, TBDDocument, tbddocument, SimulationData, Simulation Data, simulationdata, simulation data, First Day, FirstDay, first day, firstday
        /// </search>
        public static int FirstDay(SimulationData SimulationData)
        {
            return SimulationData.pSimulationData.firstDay;
        }

        /// <summary>
        /// Gets Simulation Data Last Day
        /// </summary>
        /// <param name="SimulationData">TSD Simulation Data</param>
        /// <returns name="LastDay">Last Day</returns>
        /// <search>
        /// TAS, TBDDocument, tbddocument, SimulationData, Simulation Data, simulationdata, simulation data, Last Day, LastDay, last day, lastday
        /// </search>
        public static int LastDay(SimulationData SimulationData)
        {
            return SimulationData.pSimulationData.lastDay;
        }
    }
}
