using System;
using System.Collections.Generic;
using System.Text;

namespace numericalintegration
{
    class BigMethodsClass
    {
        public static double GetIntegralTrapeze(string[] coeff,double a , double b, int n)
        {
            double h = (b - a) / n;
            double I =h / 2 * (HelperClass.GetFunctionValue(coeff, a) + HelperClass.GetFunctionValue(coeff, b));
            for(int i=1;i<n;i++)
            {
                I += h * HelperClass.GetFunctionValue(coeff, a + i * h);
            }
            return I;
        }
        public static double GetintegralSimpson(string[] coeff, double a, double b, int n)
        {
            double h = (b - a) / n;
            double I = HelperClass.GetFunctionValue(coeff, a) + HelperClass.GetFunctionValue(coeff, b);
            for(int i =1;i<n;i++)
            {
                int coefficent = i % 2 == 0 ? 2 : 4;
                I += coefficent * HelperClass.GetFunctionValue(coeff, a + i * h);
            }
            I *= h / 3;
            return I;
        }

    }
}
