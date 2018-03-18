using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordConverterBLL
{
    public class DMSConverter
    {
        public double Dms2Dd (DMSCoord dmscoord)
        {
            double minutes = Convert.ToDouble(dmscoord.min) / 60;
            double seconds = dmscoord.sec / 3600;
            double dd = Math.Round((dmscoord.deg + minutes + seconds), 5);
            return dd;
        }
    }
}
