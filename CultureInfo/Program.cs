using System;
using System.Globalization;

namespace CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-BR");

            Console.WriteLine(DateTime.Now);
        }
    }
}
