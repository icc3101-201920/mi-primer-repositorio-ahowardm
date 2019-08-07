using System;

namespace ProyectoPrueba
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 5);
            Console.WriteLine(fraction1);
            Fraction fraction2 = new Fraction(4, 10);
            Console.WriteLine(fraction2);

            Fraction sum = fraction1.Plus(fraction2);
            Console.WriteLine(sum);

            fraction1.SetDenominator(-3);
            Console.WriteLine(fraction1);
        }
    }
}
