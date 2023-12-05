using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio06
    {
        public void Executarexercicioseis()
        {
            //Escreva um algoritmo que lê dois valores booleanos (lógicos) e então
            //determina se ambos são VERDADEIROS ou FALSOS.


            bool valor1, valor2, verdadeiros, falsos;

            Console.Write("Digite o primeiro valor booleano:");
            valor1 = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Digite o segundo valor booleano:");
            valor2 = Convert.ToBoolean(Console.ReadLine());

            verdadeiros = valor1 && valor2;
            falsos = !valor1 && !valor2;

            if (verdadeiros)
            {
                Console.WriteLine("Ambos são verdadeiros.");
            }
            else if (falsos)
            {
                Console.WriteLine("Ambos são falsos");
            }
            else
            {
                Console.WriteLine("Um dos valores é verdadeiro e o outro é falso");
            }
        }
    }
}
