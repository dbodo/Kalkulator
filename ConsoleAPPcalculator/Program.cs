using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace ConsoleAPPcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float rezultat = 0;
            int nOdabir;         
            Console.Write("Unesite prvi broj: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odaberite operaciju:");
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Oduzimanje");
            Console.WriteLine("3. Mnozenje");
            Console.WriteLine("4. Dijeljenje");
            nOdabir = Convert.ToInt32(Console.ReadLine());
            Calculator Calculator = new Calculator();
            switch (nOdabir)
            {
                case 1:
                    rezultat = Calculator.Add(a, b);        
                    break;
                case 2:
                    rezultat = Calculator.Substract(a, b);
                    break;
                case 3:
                    rezultat = Calculator.Multiply(a, b);
                    break;
                case 4:
                    rezultat = Calculator.Divide(a, b);
                    break;                        
            }
            Console.WriteLine("Rezultat je: " + rezultat);
            Console.ReadKey();

        }
    }
}
