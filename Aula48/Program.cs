using System;
using System.Globalization;

namespace Aula48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("- Qual é a cotação do dólar? ");
            CotacaoDolar.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("- Quantos dólares você vai comprar? ");
            CotacaoDolar.Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            System.Console.Write($"- Valor pago em reais: ");
            CotacaoDolar.Conversor();
            //CotacaoDolar.Conversor2();
        }
    }
}
