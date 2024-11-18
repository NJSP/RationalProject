namespace RationalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rational Project");
            Rational r1 = new Rational();
            Rational r2 = new Rational(2, 6);

            r2.WriteRational3();
            r2.Reduce();
            r2.WriteRational3();

        }
    }
}
