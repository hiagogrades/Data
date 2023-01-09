using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Sempre que definido um novo objeto TimeSpan, o mesmo será zerado.
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan.ToString());

            
        }
    }
}
