using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Surface Output Spec
    /// </summary>
    public class SurfaceOutputSpec
    {
        private TBD.SurfaceOutputSpec pSurfaceOutputSpec;

        internal SurfaceOutputSpec(TBD.SurfaceOutputSpec SurfaceOutputSpec)
        {
            pSurfaceOutputSpec = SurfaceOutputSpec;
        }
    }
}
