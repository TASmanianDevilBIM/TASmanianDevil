using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{
    /// <summary>
    /// TAS T3D Window
    /// </summary>
    public class Window
    {
        internal TAS3D.window pWindow;

        internal Window(TAS3D.window Window)
        {
            pWindow = Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Name
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Name">Window Name</returns>
        /// <search>
        /// TAS, Window, window, name, Name
        /// </search>
        public static string Name(Window Window)
        {
            return Window.pWindow.name;
        }

        /// <summary>
        /// Sets TAS 3D Window Name
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Name">Zone Name</param>
        /// <returns name="Window">Zone Name</returns>
        /// <search>
        /// TAS, Window, window, name, Name
        /// </search>
        public static Window SetName(Window Window, string Name)
        {
            Window.pWindow.name = Name;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window colour
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Colour">Window Colour</returns>
        /// <search>
        /// TAS, Window, window, colour, Colour
        /// </search>
        public static uint Colour(Window Window)
        {
            return Window.pWindow.colour;
        }

        /// <summary>
        /// Sets TAS 3D Window colour
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Colour">Window Colour</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, window, SetColour, setcolour, set colour
        /// </search>
        public static Window SetColour(Window Window, uint Colour)
        {
            Window.pWindow.colour = Colour;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Width
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Width">Window Width</returns>
        /// <search>
        /// TAS, Window, window, Width, width
        /// </search>
        public static double Width(Window Window)
        {
            return Window.pWindow.width;
        }

        /// <summary>
        /// Sets TAS 3D Window Width
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Width">Window Width</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, Window, Width, width, SetWidth, Set Width, setwidth
        /// </search>
        public static Window SetWidth(Window Window, double Width)
        {
            Window.pWindow.width = Width;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Height
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Height">Window Height</returns>
        /// <search>
        /// TAS, Window, window, Height, height
        /// </search>
        public static double Height(Window Window)
        {
            return Window.pWindow.height;
        }

        /// <summary>
        /// Sets TAS 3D Window Height
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Height">Window Height</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, Window, Height, height, SetHeight, Set Height, setheight
        /// </search>
        public static Window SetHeight(Window Window, double Height)
        {
            Window.pWindow.height = Height;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Level
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Level">Window Level</returns>
        /// <search>
        /// TAS, Window, window, Level, level
        /// </search>
        public static double Level(Window Window)
        {
            return Window.pWindow.level;
        }

        /// <summary>
        /// Sets TAS 3D Window Level
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Level">Window Level</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, Window, Level, level, SetLevel, Set Level, setlevel
        /// </search>
        public static Window SetLevel(Window Window, double Level)
        {
            Window.pWindow.level = Level;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Internal Shadows
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Value">Internal Shadows</returns>
        /// <search>
        /// TAS, Window, window, InternalShadows, Internal Shadows, internal shadows, internalshadows
        /// </search>
        public static bool InternalShadows(Window Window)
        {
            return Window.pWindow.internalShadows;
        }

        /// <summary>
        /// Sets TAS 3D Window Internal Shadows
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="InternalShadows">TAS Window Internal Shadows</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, window, InternalShadows, Internal Shadows, internal shadows, internalshadows, SetInternalShadows, Set Internal Shadows
        /// </search>
        public static Window SetInternalShadows(Window Window, bool InternalShadows)
        {
            Window.pWindow.internalShadows = InternalShadows;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Transparency
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Value">Transparent</returns>
        /// <search>
        /// TAS, Window, window, Transparent, transparent
        /// </search>
        public static bool Transparent(Window Window)
        {
            return Window.pWindow.transparent;
        }

        /// <summary>
        /// Sets TAS 3D Window Transparency
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Transparent">Window Transparent</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, window, Transparent, transparent, SetTransparent Set Transparent
        /// </search>
        public static Window SetTransparent(Window Window, bool Transparent)
        {
            Window.pWindow.transparent = Transparent;
            return Window;
        }

        /// <summary>
        /// Gets Window is percentage frame
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Value">Is Percentage Frame</returns>
        /// <search>
        /// TAS, Window, window, IsPercFrame, Is Perc Frame, is percent frame, Is Percentage Frame, IsPercentageFrame
        /// </search>
        public static bool IsPercentageFrame(Window Window)
        {
            return Window.pWindow.isPercFrame;
        }

        /// <summary>
        /// Sets Window is percentage frame
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="IsPercentageFrame">Is Percentage Frame</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, window, IsPercFrame, Is Perc Frame, is percent frame, SetIsPercFrame, Set Is Percent Frame, IsPercentageFrame, SetIsPercentageFrame
        /// </search>
        public static Window SetIsPercentageFrame(Window Window, bool IsPercentageFrame)
        {
            Window.pWindow.isPercFrame = IsPercentageFrame;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Frame Width
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Width">Window Frame Width</returns>
        /// <search>
        /// TAS, Window, window, Width, width, FrameWidth, Frame Width
        /// </search>
        public static double FrameWidth(Window Window)
        {
            return Window.pWindow.frameWidth;
        }

        /// <summary>
        /// Sets TAS 3D Window Width
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Width">Window Frame Width</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, Window, Width, width, SetHeight, Set Width, setwidth
        /// </search>
        public static Window SetFrameWidth(Window Window, double Width)
        {
            Window.pWindow.frameWidth = Width;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Frame Depth
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Depth">Window Frame Depth</returns>
        /// <search>
        /// TAS, Window, window, Depth, depth, FrameDepth, Frame Depth
        /// </search>
        public static double FrameDepth(Window Window)
        {
            return Window.pWindow.frameDepth;
        }

        /// <summary>
        /// Sets TAS 3D Window Depth
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="Depth">Window Frame Depth</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, Window, Depth, depth, SetFrameDepth, SetFrameDepth, Set Frame Depth
        /// </search>
        public static Window SetFrameDepth(Window Window, double Depth)
        {
            Window.pWindow.frameDepth = Depth;
            return Window;
        }

        /// <summary>
        /// Gets TAS 3D Window Frame Percentage
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <returns name="Width">Window Frame Percentage</returns>
        /// <search>
        /// TAS, Window, window, Percentage, FramePercentage
        /// </search>
        public static double FramePercentage(Window Window)
        {
            return Window.pWindow.framePerc;
        }

        /// <summary>
        /// Gets TAS 3D Window Frame Percentage
        /// </summary>
        /// <param name="Window">TAS Window</param>
        /// <param name="FramePercentage">Window Frame Percentage</param>
        /// <returns name="Window">Window</returns>
        /// <search>
        /// TAS, Window, window, Percentage, FramePercentage, SetFramePercentage, Set Frame Percentage
        /// </search>
        public static Window SetFramePercentage(Window Window, double FramePercentage)
        {
            Window.pWindow.framePerc = FramePercentage;
            return Window;
        }

    }
}
