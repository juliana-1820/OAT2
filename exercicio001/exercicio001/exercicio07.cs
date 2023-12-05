using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio07
    {
        public void Executarexerciciosete()
        {
            //Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8,
            //caso seja ímpar, imprimir o resultado desta operação.

            int x = 0;
            int y = 0;


            while (x != -1)
            {
                Console.Clear();

                Console.WriteLine("Digite um numero");
                x = int.Parse(Console.ReadLine());

                if (y == x % 2)
                {
                    y = x + 5;
                    Console.WriteLine("O resultado é:" + y);

                }

                else
                {
                    y = x + 8;
                    Console.WriteLine("O resultado é:" + y);

                }
                Console.ReadKey();


            }
        }
    }
}
