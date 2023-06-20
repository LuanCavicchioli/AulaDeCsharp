using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4Notass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Media de 4 notas
            double nota1, nota2, nota3, nota4, total, media;

            Console.WriteLine("///////////////////////////");
            Console.WriteLine("|     Calcular Media     |");
            Console.WriteLine("///////////////////////////");

            //Atribuir Valor As 4 Notas
            Console.Write("Digite a primeira nota :");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota:");
            nota4 = Convert.ToDouble(Console.ReadLine());
            //Atribuir os resultados a um total e calcular media
            total = (nota1 + nota2) + (nota2 + nota3);

            media = total / 4;
            //Verificação da media
            if (media >= 7)
            {
                Console.WriteLine("Voce foi aprovado :D, sua media é:  " + media);
            }
            else
            {
                Console.WriteLine("Voce foi reprovado :( , sua media é : " + media);
            }

        }
    }
}