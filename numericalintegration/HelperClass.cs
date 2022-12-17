using System;
using System.Collections.Generic;
using System.Text;

namespace numericalintegration
{
    class HelperClass
    {
       public static string[] Getcoefficents(string input)
        {
            int count = 0;
            string[] coefficents = new string[] { "", "", "", "" };
            for(int i =0;i <input.Length;i++)
            {
               if(input[i]!=Convert.ToChar(" "))
               {
                    coefficents[count] += input[i];
               }
               else
                    count++;
            }
            return coefficents;
        }

        public static string WriteForFunction(string[] coeff)
        {
            string output = "f(x) = " + coeff[0] + "x^3 + " + coeff[1] + "x^2 + " + coeff[2] + "x + " + coeff[3];
            return output;
        }

        public static double GetFunctionValue(string[] coefficants,double value)
        {
            double a = Convert.ToDouble(coefficants[0]);
            double b= Convert.ToDouble(coefficants[1]);
            double c= Convert.ToDouble(coefficants[2]);
            double d= Convert.ToDouble(coefficants[3]);
            a = a * Math.Pow(value,3);
            b = b * Math.Pow(value, 2);
            c = c * Math.Pow(value, 1);
            return a + b + c + d;
        }
    }
}
