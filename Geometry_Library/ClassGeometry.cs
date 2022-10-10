using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Library
{
    public class ClassGeometry
    {
        public static  int SumTwo(int a, int b)
        {
             return  a + b;
        }

        public static double PloKruPoRadiusa(double r)
        {   
            return Math.PI * Math.Pow(r,2.0);
        }

        public static double PloTriPoTriSto(double a , double b , double c)
        { 
            double p = (a +b+c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
