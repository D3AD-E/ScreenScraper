using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    class WindowParser
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindoprocName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);

        public Point GetUpperPoint(string procName)
        {
            Point point = new Point();
            IntPtr hWnd = FindWindow(procName, null);
            if (hWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                GetWindowRect(hWnd, out rect);
                point.X = rect.Left;
                point.Y = rect.Top;
            }
            return point;
        }

        public Point GetUpperPoint(IntPtr hWnd)
        {
            Point point = new Point();
            if (hWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                GetWindowRect(hWnd, out rect);
                point.X = rect.Left;
                point.Y = rect.Top;
            }
            return point;
        }

        public Rectangle GetWindowBorders(IntPtr hWnd)
        {
            Rectangle rectangle = new Rectangle();
            if (hWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                GetWindowRect(hWnd, out rect);
                rectangle = Convert(rect);
            }
            return rectangle;
        }

        public bool isPointInBorders(Point point, IntPtr hWnd)
        {
            Rectangle rectangle = GetWindowBorders(hWnd);
            return rectangle.Contains(point);
        }

        private Rectangle Convert(RECT toConvert)
        {
            Rectangle rectangle = new Rectangle
            {
                X = toConvert.Left,
                Y = toConvert.Top,
                Width = toConvert.Right - toConvert.Left,
                Height = toConvert.Bottom - toConvert.Top
            };

            return rectangle;
        }

        public Color GetColorAtPoint(Point location)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        public Point GetCursorPos()
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            return cursor;
        }

        public bool isWindowOnForeground(string procName)
        {
            IntPtr hWnd = FindWindow(procName, null);
            if (hWnd != IntPtr.Zero)
            {
                return IsIconic(hWnd);
            }
            return false;
        }
        public bool isWindowOnForeground(IntPtr hWnd)
        {
            if (hWnd != IntPtr.Zero)
            {
                return IsIconic(hWnd);
            }
            return false;
        }

        public bool doesWindowExist(string procName)
        {
            IntPtr hWnd = FindWindow(procName, null);
            return (hWnd != IntPtr.Zero);
        }
        public bool doesWindowExist(IntPtr hwnd)
        {
            return (IsWindow(hwnd));
        }

        public IntPtr getFocusedWindow()
        {
            return GetForegroundWindow();
        }
        public string getWindowTitle(IntPtr hwnd)
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);

            if (GetWindowText(hwnd, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        public IntPtr getOwnWindow()
        {
            return Process.GetCurrentProcess().MainWindowHandle;
        }
    }
}
