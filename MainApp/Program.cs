namespace MainApp;

partial class Program
{
    static partial void HelloFrom(string name);

    static void Main(string[] args)
    {
        HelloFrom("Hello World!");

        (double x1, double x2) = QuadraticNamespace.QuadraticClass.Calculate(1, -1, -12);
    }
}