using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    internal class Exercicio08
    {
        public void Executarexerciciooito()
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e
            //mostre-os em ordem decrescente.

            Console.WriteLine("Exercicio 08 - algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.");
            Console.ReadKey();


            int x = 0;
            int y = 0;
            int z = 0;


            while (x != -1)
            {
                Console.Clear();

                Console.WriteLine("Digite o primeiro numero");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o terceiro número");
                z = int.Parse(Console.ReadLine());



            }


        }
    }
}
