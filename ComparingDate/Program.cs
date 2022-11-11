using System;

namespace ComparingDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Declarando uma variável data como nula
            //DateTime? data = null;

            var data = DateTime.Now;
            Console.WriteLine($"DateTime inicial: {data}");

            /*Comparando a variável data com o tempo atual, nunca terá um retorno verdadeiro.
            Pois, desta forma sera comparado toda a estrutura de data e tempo, ou seja, até os milissegundos
            */
            if (data == DateTime.Now)
            {
                Console.WriteLine("É igual");
            }

            //Maneira correta de fazer
            //Desta forma está sendo comparado data com data, possibilitando o retorno verdadeiro.
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine($"DateTime final: {DateTime.Now}");
        }
    }
}
