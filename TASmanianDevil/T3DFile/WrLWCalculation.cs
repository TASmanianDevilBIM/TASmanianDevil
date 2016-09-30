using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{

    /// <summary>
    /// TAS T3D WrLWCalculation
    /// </summary>
    public class WrLWCalculation
    {
        internal TAS3D.WrLW_Calculation pWrLWCalculation;

        internal WrLWCalculation(TAS3D.WrLW_Calculation WrLWCalculation)
        {
            pWrLWCalculation = WrLWCalculation;
        }
    }
}
