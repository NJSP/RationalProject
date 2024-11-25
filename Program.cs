namespace RationalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rational Project");

            // Create a new Rational object using the default constructor
            Rational r1 = new Rational();
            r1.WriteRational();

            // Create a new Rational object using the parametric constructor
            Rational r2 = new Rational(2, 6);
            r2.WriteRational();

            // Test the Negate method
            r2.Negate();
            r2.WriteRational();

            // Test the Invert method
            r2.Invert();
            r2.WriteRational();

            // Test the ToDouble method
            Console.WriteLine(r2.ToDouble());

            // Test the Reduce method
            Rational r3 = r2.Reduce();
            r3.WriteRational();

            // Test the Add method
            Rational r4 = Rational.Add(r1, r2);
            r4.WriteRational();

            // Test the Instance Add method
            Rational r5 = r1.Add(r2);
            r5.WriteRational();



            /* 
             * #4 - Exercise 13.4
             * Static methods seem to be better for utility functions and operations that don't depend on instance
             * data. However, there are times when you necessarily need to use or modify data specific to an instance. 
             * In those cases, you would use an instance method. Static methods tend to be easier and more concise,
             * and you don't need to instantiate an object to use them. Instance methods, on the other hand, require
             * you to instantiate an object before you can use them, which can be cumbersome in some cases, but
             * necessary in others.
            */
        }
    }
}