using System;

namespace Generic
{
    /// <summary>
    /// A library info
    /// </summary>
    public static class Info
    {
        private static string pVersion = "0.0.1";

        /// <summary>
        /// Returns version of libary
        /// </summary>
        /// <returns name="LibraryVersion">Library Version</returns>
        /// <search>
        /// TASmanianDevil, Library Version, Info, library version, info
        /// </search>
        public static string LibraryVersion()
        {
            return "TASmanianDevil ver 0.9.0/t TASmanianDevil is a free and open source plugin for/t Dynamo to help engineers and designers using TAS to/t perform thermal and daylight simulation./t TASmanianDevil is plugin for Dynamo./t It was  build and tested on Dynamo (ver 9.2) with/t Revit 2015 (Build 20160220_0715(x64)) and/t TAS (9.3.3 build 8176). It can be used without Revit/t and it help automate and control processes from/t Dynamo environment.";
        }

        /// <summary>
        /// Returns authors of libary
        /// </summary>
        /// <returns name="LibraryVersion">Library authors</returns>
        /// <search>
        /// TASmanianDevil, Library Authors, Info, library authors, info
        /// </search>
        public static string LibraryAuthors()
        {
            return "Please conntact me:/t TASmanianDevilBIM @gmail/t www.facebook.com/t TASmanianDevilBIM";
        }

        /// <summary>
        /// Returns Agreement Info
        /// </summary>
        /// <returns name="Agreement">Agreement</returns>
        /// <search>
        /// TASmanianDevil, Agreement
        /// </search>
        public static string Agreement()
        {
            return @"Copyright (C) 2016, Michal Dengusiak/t This program is free software; you can/t redistribute it and/or modify it under the terms/t of the GNU General Public License as published by/t  the Free Software Foundation; either version 3/t of the License, or (at your option) any late/t version. This program is distributed in the hope/t  that it will be useful, but WITHOUT ANY WARRANTY;/t without even the implied warranty of/t MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE./t  See the GNU General Public License for more details./t You should have received a copy of the GNU General/t  Public License along with this program; if not,/t see <http://www.gnu.org/licenses>. Additional/t  permission under GNU GPL version 3 section 7:/t TASmanianDevil uses the Revit and Dynamo libraries,/t  which come with/for Revit 2015. TASmanianDevil/t  depends fundamentally on the use of Dynamo, and/t  so Dynamocommon, and all associated libraries/t  are assumed to be ""System Libraries"" as defined/t  by the GPL, and thus areexcluded from this/t  license.TASmanianDevil uses TAS, which is subject/t  to its own licensing condition. TAS software/t  (http://edsl.net/main/) developed by the EDSL.";
        }
    }
}
