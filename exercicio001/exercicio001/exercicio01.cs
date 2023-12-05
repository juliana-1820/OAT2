using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio01
    {
        public void Executarexercicioum()
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se
            //a soma de A + B é menor que C.

            Console.WriteLine("Exercicio 01 - algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C");
            Console.ReadKey();

            Console.WriteLine("Digite o valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            int C = int.Parse(Console.ReadLine());

            if ((A + B) < C)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }
            Console.ReadKey();

        }

    }
}
