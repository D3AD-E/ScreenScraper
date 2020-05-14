using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class PointData
    {
        public string Name { get; set; }
        public Point gPoint { get; set; }
        public Point wPoint { get; set; }
        public Color PixelColor { get; set; }

        public PointData()
        {
            wPoint = new Point(-1, -1);
        }

        public PointData(PointData other)
        {
            Name = other.Name;
            gPoint = other.gPoint;
            wPoint = other.wPoint;
            PixelColor = other.PixelColor;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
