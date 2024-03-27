using csharp_with_javascript.Service;
using System;

namespace csharp.with.javascript
{
    internal class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            string propertyPath = "R.admin.disciplinasMinistradas";

            var value = ExpressionService.GetProperty(propertyPath);

            Console.WriteLine(value);

            Console.ReadKey();

        }
    }
}
