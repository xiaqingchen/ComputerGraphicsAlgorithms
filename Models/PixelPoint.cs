using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphicsAlgorithms.Models
{
    public struct PixelPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PixelPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
