using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio03
    {
        public void Executarexerciciotres()
        {
            //Faça um algoritmo para receber um número qualquer e informar na tela se
            //é par ou ímpar.

            int x = 0;
            int resultado = 0;


            while (x != -1)
            {
                Console.Clear();

                Console.WriteLine("Digite um numero");
                x = int.Parse(Console.ReadLine());

                if (resultado == x % 2)
                {
                    Console.WriteLine("O número é par");
                }

                else
                {
                    Console.WriteLine("O número é ímpar");
                }
                Console.ReadKey();

            }

        }
    }
}
