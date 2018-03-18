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
            if (dmscoord.deg < 0 || dmscoord.min < 0 || dmscoord.sec < 0)
            {
                return 9999;
            }
            if (dmscoord.min >= 60 || dmscoord.sec >= 60)
            {
                return 9999;
            }
            double minutes = Convert.ToDouble(dmscoord.min) / 60;
            double seconds = dmscoord.sec / 3600;
            double dd = Math.Round((dmscoord.deg + minutes + seconds), 5);
            return dd;
        }
    }
}
