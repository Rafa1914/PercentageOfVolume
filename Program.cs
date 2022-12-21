using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PercentageOfVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leitura da entrada:
            Console.Write("Digite o total negociado: ");
            int.TryParse(Console.ReadLine(), out int totalNegociado);
            Console.Write("Digite a porcentagem desejada, se for 10% digite 0,1: ");
            decimal.TryParse(Console.ReadLine(), out decimal porcentagem);

            //Cálculo da Percentage of Volume:
            int pov = funcaoRetornaQuantidadePOV(porcentagem, totalNegociado);

            //Exibição do resultado:
            Console.WriteLine($"A estratégia deverá realizar {pov} execuções.");
        }

        private static int funcaoRetornaQuantidadePOV(decimal porcentagem, int totalNegociado)
            => (int)Math.Floor((porcentagem * totalNegociado) / ((decimal)1.0 - porcentagem));
    }
}