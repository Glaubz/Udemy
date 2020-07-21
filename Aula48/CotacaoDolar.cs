using System.Globalization;

namespace Aula48{
    class CotacaoDolar{
        public static double Dolar;
        public static double Dolares;

        public static void Conversor(){
            System.Console.WriteLine((Dolar * Dolares).ToString("F2", CultureInfo.InvariantCulture));
        }

        /*public static double Conversor2(){
            double Resultado = Dolar * Dolares;
            return Resultado;
        }*/
    }
}