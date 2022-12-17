using System;

namespace numericalintegration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the coefficients of polynomial function:");
            string userInput = Console.ReadLine();
                string[] coefficents = new string[4];
                coefficents = HelperClass.Getcoefficents(userInput);
                Console.WriteLine("The function you've entered:");
                Console.WriteLine(HelperClass.WriteForFunction(coefficents));
                Console.WriteLine("Please write the boundaries of integration:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double resultfortrapeze = BigMethodsClass.GetIntegralTrapeze(coefficents, a, b, 100);
                double resultforsimpson = BigMethodsClass.GetintegralSimpson(coefficents, a, b, 100);
                Console.Write("Integration by trapezoidal method: ");
                Console.WriteLine(resultfortrapeze);
                Console.Write("Integration by simpson method: ");
                Console.WriteLine(resultforsimpson);
        }
    }
}
