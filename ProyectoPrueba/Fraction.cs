using System;
namespace ProyectoPrueba
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }

        public Fraction(int n, int d)
        {
            numerator = n;
            denominator = d;
            Reduce();
        }

        public Fraction Plus(Fraction other)
        {
            Fraction result = new Fraction(numerator * other.GetDenominator() + denominator * other.GetNumerator(), denominator * other.GetDenominator());
            return result;
        }

        public Fraction Minus(Fraction other)
        {

            Fraction result = new Fraction(numerator * other.GetDenominator() - denominator * other.GetNumerator(), denominator * other.GetDenominator());
            return result;
        }

        public Fraction Times(Fraction other)
        {
            Fraction result = new Fraction(numerator * other.GetNumerator(), denominator * other.GetDenominator());
            return result;
        }

        public Fraction DividedBy(Fraction other)
        {
            Fraction result = new Fraction(numerator * other.GetDenominator(), denominator * other.GetNumerator());
            return result;
        }

        public Boolean Equals(Fraction other)
        {
            if (numerator == other.GetNumerator() && denominator == other.GetDenominator())
            {
                return true;
            }
            return false;
        }

        override public String ToString()
        {
            return numerator + "/" + denominator;
        }

        private void Reduce()
        {
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            if (numerator == 0 && denominator != 0)
            {
                denominator = 1;
            }

            for (int i = Math.Min(Math.Abs(numerator), denominator); i >= 2; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                }
            }
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public void SetNumerator(int n)
        {
            numerator = n;
            Reduce();
        }

        public void SetDenominator(int d)
        {
            denominator = d;
            Reduce();
        }

        public int GetDenominator()
        {
            return denominator;
        }
    }
}
