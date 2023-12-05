using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio04
    {
        public void Executarexercicioquatro()
        {
            //Faça um algoritmo que leia dois valores inteiros A e B se os valores
            //forem iguais deverá se somar os dois, caso contrário multiplique A
            //por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado
            //para uma variável C e mostrar seu conteúdo na tela.

            int A, B, C;


            Console.WriteLine("Digite o primeiro número");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            B = int.Parse(Console.ReadLine());

            if (A != B)
            {
                C = A + B;
                Console.WriteLine("O resultado é:" + C);
            }
            else
            {
                C = A * B;
                Console.WriteLine("O resultado é:" + C);
            }

            Console.ReadKey();

        }

    }
}
