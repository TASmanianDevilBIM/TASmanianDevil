using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS IZAM
    /// </summary>
    public class IZAM
    {
        internal TBD.IZAM pIZAM;

        internal IZAM(TBD.IZAM IZAM)
        {
            pIZAM = IZAM;
        }

        /// <summary>
        /// TAS IZAM Description
        /// </summary>
        /// <param name="IZAM">IZAM</param>
        /// <returns name="Description">IZAM Description</returns>
        /// <search>
        /// TAS, IZAM, izam, Description, description
        /// </search>
        public static string Description(IZAM IZAM)
        {
            return IZAM.pIZAM.description;
        }

        /// <summary>
        /// TAS IZAM From Outside
        /// </summary>
        /// <param name="IZAM">IZAM</param>
        /// <returns name="FromOutside">From Outside</returns>
        /// <search>
        /// TAS, IZAM, izam, FromOutside, fromoutside, from outside, From Outside
        /// </search>
        public static int FromOutside(IZAM IZAM)
        {
            return IZAM.pIZAM.fromOutside;
        }

        /// <summary>
        /// TAS IZAM Name
        /// </summary>
        /// <param name="IZAM">IZAM</param>
        /// <returns name="Description">IZAM Name</returns>
        /// <search>
        /// TAS, IZAM, izam, name, Name
        /// </search>
        public static string Name(IZAM IZAM)
        {
            return IZAM.pIZAM.name;
        }
    }
}
