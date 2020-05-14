using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class Proc
    {
        public string Name { get; set; }
        public IntPtr hWnd { get; set; }
        public Proc()
        {
            hWnd = IntPtr.Zero;
            Name = "";
        }
        public override string ToString()
        {
            string toFormat = "Process: {0}, hwnd: {1}";
            toFormat = String.Format(toFormat, Name, hWnd);
            return toFormat;
        }
    }
}
