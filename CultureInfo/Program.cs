using System;
using System.Globalization;

namespace CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Trabalhando com Informações de Cultura");

            var ptBR = new System.Globalization.CultureInfo("pt-BR");
            var ptPT = new System.Globalization.CultureInfo("pt-PT");
            var enUK = new System.Globalization.CultureInfo("en-UK");
            var enUS = new System.Globalization.CultureInfo("en-US");
            var CultureAtual = System.Globalization.CultureInfo.CurrentCulture; //Atribuindo a cultura da máquina

            Console.WriteLine(DateTime.Now);


            //Exibindo a data no modo short date time (Data "curta")
            //Formatando a data de maneira manual
            Console.WriteLine(String.Format("{0:D}", DateTime.Now));
            //Modo direto
            Console.WriteLine(DateTime.Now.ToString("D", enUS));
        }
    }
}
