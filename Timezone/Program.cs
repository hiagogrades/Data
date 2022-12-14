using System;
using System.Globalization;

namespace Timezone
{
    class Program
    {
        static void Main(string[] args)
        {
            var pt = new CultureInfo("pt-Pt");
            var br = new CultureInfo("pt-Br");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            //Pega somente a data e hora sem utilizar o timezone
            var utcdate = DateTime.UtcNow;

            Console.WriteLine($"Horário atual com timezone do servidor: {DateTime.Now}");
            Console.WriteLine($"Horário atual com timezone da máquina local: {utcdate.ToLocalTime()}");
            Console.WriteLine($"Horário atual sem timezone: {utcdate}");

            var timeZoneAlasca = TimeZoneInfo.FindSystemTimeZoneById("Ilhas Faroe");
            Console.WriteLine($"Time zone Alaskan: {timeZoneAlasca}");

            //Convertendo para o time zone da Australia
            var horaAlasca = TimeZoneInfo.ConvertTimeFromUtc(utcdate, timeZoneAlasca);
            Console.WriteLine(horaAlasca);
            Console.WriteLine("-----------------");

            //Pegando todos os times zones disponíveis no sistema
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcdate, timezone));
                Console.WriteLine("-----------------");
            }


        }
    }
}
