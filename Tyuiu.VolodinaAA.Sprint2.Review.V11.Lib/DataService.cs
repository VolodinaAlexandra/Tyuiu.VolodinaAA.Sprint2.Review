using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.VolodinaAA.Sprint2.Review.V11.Lib
{
    public class DataService  
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x * x + y * y <= 1) && ((y == x)||(x>=-1 && x<=0 && y<=1 && y>=-1)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
