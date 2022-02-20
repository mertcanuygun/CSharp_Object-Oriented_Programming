using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    public static class Simple_Equations
    {
        //Factorial calculation
        public static int Factorial (int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        //cube of a number
        public static double Cubic(double n)
        {
            return n * n * n;
        }
    }

}
