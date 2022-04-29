namespace MainApp;

partial class Program
{
    static void Main(string[] args)
    {
        HelloFrom("Hello World!");
    }

    static partial void HelloFrom(string name);
}