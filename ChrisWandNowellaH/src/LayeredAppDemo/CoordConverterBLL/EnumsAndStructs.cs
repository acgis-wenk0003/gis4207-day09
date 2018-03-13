using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordConverterBLL
{
    public enum Quadrant
    {
        N,
        S,
        E,
        W
    }
    public struct DMSCoord
    {
        public int deg;
        public int min;
        public double sec;
        Quadrant quadrant;
    } 
}
