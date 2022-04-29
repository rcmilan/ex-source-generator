using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace Generator
{
    [Generator]
    public class QuadraticSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var sourceText = SourceText.From(@"
namespace QuadraticNamespace
{
    using System;

    public class QuadraticClass
    {
        public static (double x1, double x2) Calculate(double a, double b, double c)
        {
            var x1 = (-b + Math.Sqrt(Delta(a, b, c))) / (2 * a);
            var x2 = (-b - Math.Sqrt(Delta(a, b, c))) / (2 * a);

            return (x1, x2);
        }

        private static double Delta(double a, double b, double c) { return Math.Pow(b, 2) - 4 * a * c; }
    }
}
", Encoding.UTF8);

            context.AddSource("Quadratic.generated.cs", sourceText);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}
