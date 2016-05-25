using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{
    /// <summary>
    /// TAS T3D Element
    /// </summary>
    public class Element
    {
        private TAS3D.Element pElement;

        internal Element(TAS3D.Element Element)
        {
            pElement = Element;
        }

        /// <summary>
        /// Gets Element Name
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Name">Element Name</returns>
        /// <search>
        /// TAS, Element, Name, Get Element Name, getelementname, name
        /// </search>
        public static string Name(Element Element)
        {
            return Element.pElement.name;
        }

        /// <summary>
        /// Sets Element Name
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Name">TAS3D Element Name</param>
        /// <returns name="Name">Element Name</returns>
        /// <search>
        /// TAS, Element, Name, Set Element Name, setelementname, name, SetName, Set Name
        /// </search>
        public static Element SetName(Element Element, string Name)
        {
            Element.pElement.name = Name;
            return Element;
        }

        /// <summary>
        /// Gets Element BE Type
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="BEType">Element BE Type</returns>
        /// <search>
        /// TAS, Element, BE Type, Get Element BE Type, getelementbetype, betype
        /// </search>
        public static int BEType(Element Element)
        {
            return Element.pElement.BEType;
        }

        /// <summary>
        /// Sets Element BE Type
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="BEType">TAS3D Element BEType</param>
        /// <returns name="Element">TAS3D Element</returns>
        /// <search>
        /// TAS, Element, BE Type, Set Element BE Type, setelementbetype, betype, SetBEType, setbetype
        /// </search>
        public static Element SetBEType(Element Element, int BEType)
        {
            Element.pElement.BEType = BEType;
            return Element;
        }

        /// <summary>
        /// Gets Element Colour
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Colour">Element Colour</returns>
        /// <search>
        /// TAS, Element, Colour, Get Element Colour, getelementcolour, colour, color, Color
        /// </search>
        public static uint Colour(Element Element)
        {
            return Element.pElement.colour;
        }

        ///// <summary>
        ///// Sets Element Colour
        ///// </summary>
        ///// <param name="Element">TAS3D Element</param>
        ///// <param name="Red">Red</param>
        ///// <param name="Green">Green</param>
        ///// <param name="Blue">Blue</param>
        ///// <returns name="Element">Element</returns>
        ///// <search>
        ///// TAS, Element, Colour, Set Element Colour, setelementcolour, colour, color, Color
        ///// </search>
        //public static Element SetColour(Element Element, int Red, int Green, int Blue)
        //{
        //    Element.pElement.colour = Convert.ToUInt64(System.Drawing.Color.FromArgb(Red, Green, Blue).ToArgb());
        //    return Element;
        //}

        /// <summary>
        /// Sets Element Colour
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Colour">Element Colour</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, Colour, Set Element Colour, setelementcolour, colour, color, Color
        /// </search>
        public static Element SetColour(Element Element, uint Colour)
        {
            Element.pElement.colour = Colour;
            return Element;
        }

        /// <summary>
        /// Gets Element Description
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Description">Element Description</returns>
        /// <search>
        /// TAS, Element, Description, Get Element Description, getelementdescription, description
        /// </search>
        public static string Description(Element Element)
        {
            return Element.pElement.description;
        }

        /// <summary>
        /// Sets Element Description
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Description">Element Description</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, Description, Set Element Description, setelementdescription, description, SetDescription, setdescription
        /// </search>
        public static Element SetDescription(Element Element, string Description)
        {
            Element.pElement.description = Description;
            return Element;
        }

        /// <summary>
        /// Gets Element Ground
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Ground">Element Ground</returns>
        /// <search>
        /// TAS, Element, Ground, Get Element Ground, getelementground, ground
        /// </search>
        public static bool Ground(Element Element)
        {
            return Element.pElement.ground;
        }

        /// <summary>
        /// Sets Element Ground
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Ground">TAS3D Element Ground</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, Ground, Set Element Ground, setelementground, ground
        /// </search>
        public static Element SetGround(Element Element, bool Ground)
        {
            Element.pElement.ground = Ground;
            return Element;
        }

        /// <summary>
        /// Gets Element Ground
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="GUID">Element GUID</returns>
        /// <search>
        /// TAS, Element, GUID, Get Element GUID, getelementguid, guid
        /// </search>
        public static string GUID(Element Element)
        {
            return Element.pElement.GUID;
        }

        /// <summary>
        /// Gets Element Internal Shadows
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="InternalShadows">Element Internal Shadows</returns>
        /// <search>
        /// TAS, Element, InternalShadows, Get Element Internal Shadows, getelementinternalshadows, internalshadows
        /// </search>
        public static bool InternalShadows(Element Element)
        {
            return Element.pElement.internalShadows;
        }

        /// <summary>
        /// Sets Element Internal Shadows
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="InternalShadows">Element Internal Shadows</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, InternalShadows, Set Element Internal Shadows, setelementinternalshadows, internalshadows
        /// </search>
        public static Element SetInternalShadows(Element Element, bool InternalShadows)
        {
            Element.pElement.internalShadows = InternalShadows;
            return Element;
        }

        /// <summary>
        /// Is Element Preset
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="IsPreset">Is Element Preset</returns>
        /// <search>
        /// TAS, Element, IsPreset, Get Element Is Preset, getelementispreset, ispreset
        /// </search>
        public static bool IsPreset(Element Element)
        {
            return Element.pElement.isPreset;
        }

        /// <summary>
        /// Is Element Used
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="IsUsed">Is Element Used</returns>
        /// <search>
        /// TAS, Element, IsUsed, Get Element Is Used, getelementisused, isused, Is Used, is used
        /// </search>
        public static int IsUsed(Element Element)
        {
            return Element.pElement.isUsed;
        }

        /// <summary>
        /// Gets Element Secondary Element
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Element">Secondary Element</returns>
        /// <search>
        /// TAS, Element, SecondaryElement, Get Element Secondary Element, getelementsecondaryelement, Secondary Element, secondary element
        /// </search>
        public static Element SecondaryElement(Element Element)
        {
            if (Element.pElement.secondaryElement != null)
                return new Element(Element.pElement.secondaryElement);
            return null;
        }

        /// <summary>
        /// Gets Element Secondary Proportion
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Proportion">Element Secondary Proportion</returns>
        /// <search>
        /// TAS, Element, SecondaryProportion, Get Element Secondary Proportion, getelementsecondaryproportion, secondaryproportion
        /// </search>
        public static double SecondaryProportion(Element Element)
        {
            return Element.pElement.secondaryProportion;
        }

        /// <summary>
        /// Gets Element Transparency
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Transparent">Element Transparency</returns>
        /// <search>
        /// TAS, Element, Transparent, Get Element Transparent, getelementtransparent, transparent
        /// </search>
        public static bool Transparent(Element Element)
        {
            return Element.pElement.transparent;
        }

        /// <summary>
        /// Sets Element Transparency
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Transparent">TAS3D Element Transparent</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, Transparent, Set Element Transparent, setelementtransparent, transparent
        /// </search>
        public static Element SetTransparent(Element Element, bool Transparent)
        {
            Element.pElement.transparent = Transparent;
            return Element;
        }

        /// <summary>
        /// Gets Element Width
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Width">Element Width</returns>
        /// <search>
        /// TAS, Element, Width, Get Element Width, getelementwidth, width
        /// </search>
        public static double Width(Element Element)
        {
            return Element.pElement.width;
        }

        /// <summary>
        /// Sets Element Width
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Width">TAS3D Element Width</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, Width, Set Element Width, setelementwidth, width, SetWidth, Set Width
        /// </search>
        public static Element SetWidth(Element Element, double Width)
        {
            Element.pElement.width = Width;
            return Element;
        }

        /// <summary>
        /// Gets Element Zone Floor Area
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Area">Zone Floor Area</returns>
        /// <search>
        /// TAS, Element, ZoneFloorArea, Zone Floor Area, zonefloorarea, zone floor area
        /// </search>
        public static bool ZoneFloorArea(Element Element)
        {
            return Element.pElement.zoneFloorArea;
        }

        /// <summary>
        /// Sets Element Zone Floor Area
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="ZoneFloorArea">Element Zone Floor Area</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, ZoneFloorArea, Zone Floor Area, zonefloorarea, zone floor area, set, SetZoneFloorArea
        /// </search>
        public static Element SetZoneFloorArea(Element Element, bool ZoneFloorArea)
        {
            Element.pElement.zoneFloorArea = ZoneFloorArea;
            return Element;
        }

        /// <summary>
        /// Sets Secondary Element
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="SecondaryElement">Secondary Element</param>
        /// <param name="Proportion">Secondary Element Proportion</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, SetSecondaryElement, setsecondaryelement, Set Secondary Element, set secondary element
        /// </search>
        public static Element SetSecondaryElement(Element Element, Element SecondaryElement, double Proportion)
        {
            Element.pElement.SetSecondaryElement(SecondaryElement.pElement, Proportion);
            return Element;
        }

        /// <summary>
        /// Deletes Element
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="GUID">GUID of deleted Element</returns>
        /// <search>
        /// TAS, Element, Delete, delete, element
        /// </search>
        public static string Delete(Element Element)
        {
            string pResult = Element.pElement.GUID;
            Element.pElement.Delete();
            return pResult;
        }

        /// <summary>
        /// Gets Element Null (Ghost)
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <returns name="Null">Element Null</returns>
        /// <search>
        /// TAS, Element, Null, Get Element Null, getelementnull, null, ghost
        /// </search>
        public static bool Null(Element Element)
        {
            return Element.pElement.ghost;
        }

        /// <summary>
        /// Sets Element Null (Ghost)
        /// </summary>
        /// <param name="Element">TAS3D Element</param>
        /// <param name="Null">Element Null (Ghost)</param>
        /// <returns name="Element">Element</returns>
        /// <search>
        /// TAS, Element, Null, Set Element Null, setelementnull, null, ghost
        /// </search>
        public static Element SetNull(Element Element, bool Null)
        {
            Element.pElement.ghost = Null;
            return Element;
        }
    }
}
