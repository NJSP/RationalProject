namespace RationalProject
{
    public class Rational
    {
        private int numerator;
        private int denominator;

        // Default constructor
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }

        // Parametric constructor
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Method to write the rational number
        public void WriteRational()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }

        // Method to negate the rational number
        public void Negate()
        {
            numerator = -numerator;
        }

        // Method to invert the rational number
        public void Invert()
        {
            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }

        // Method to convert the rational number to double
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }

        // Method to reduce the rational number to its lowest terms
        public Rational Reduce()
        {
            long gcd = GCD(numerator, denominator);
            return new Rational(numerator / (int)gcd, denominator / (int)gcd);
        }

        // Method to add two rational numbers
        public static Rational Add(Rational r1, Rational r2)
        {
            int newNumerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int newDenominator = r1.denominator * r2.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            return result.Reduce();
        }

        // Instance method to add two rational numbers
        public Rational Add(Rational other)
        {
            int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            return result.Reduce();
        }

        // Method to find the greatest common divisor (GCD)
        private static long GCD(long n1, long n2)
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