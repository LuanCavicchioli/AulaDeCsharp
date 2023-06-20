using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4, media;

            Console.WriteLine("///////////////////////////");
            Console.WriteLine("|     Calcular Media     |");
            Console.WriteLine("///////////////////////////");
            Console.Write("Digite o numero 1 :");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o numero 2 :");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o numero 3 :");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o numero 4 :");
            numero4 = Convert.ToInt32(Console.ReadLine());

            media = (numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("|" + "Sua media é :" + media + "|");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        }
    }
}