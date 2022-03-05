using System;

namespace lab1
{
    class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator
        {
            get => this.numerator;
        }
        public int Denominator
        {
            get => this.denominator;
        }

        public Fraction()
        {
        }

        public Fraction(int nominator, int denominator)
        {
            this.numerator = nominator;
            this.denominator = denominator;
        }
        public Fraction(Fraction fraction)
        {
            int numerator;
            int denominator;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.numerator, a.denominator);
        public static Fraction operator *(Fraction a, Fraction b)
        => new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

        public string ToString() => $"{numerator} / {denominator}";

        public interface IEquatable
        {

        }

        public interface IComparable
        {

        }


        


        public static void Main()
        {
            Console.WriteLine(new Fraction(5,2).ToString());
        }
    }

    
}
