using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    internal class Rational
    {
        public int numerator, denominator;
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }

        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static void WriteRational(Rational r)
        {
            Console.WriteLine($"{r.numerator}/{r.denominator}");
        }

        public void WriteRational2(Rational r)
        {
            Console.WriteLine($"{r.numerator}/{r.denominator}");
        }

        public void WriteRational3()
        {
            Console.WriteLine($"{this.numerator}/{this.denominator}");
        }

        public void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            this.numerator /= gcd;
            this.denominator /= gcd;
        }

        static int GCD(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
    }
}
