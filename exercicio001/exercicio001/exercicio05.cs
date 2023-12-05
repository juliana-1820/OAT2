using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio05
    {
        public void Executarexerciciocinco()
        {
            //Encontrar o dobro de um número caso ele seja positivo e o seu triplo
            //caso seja negativo, imprimindo o resultado

            int x = 0;
            int y = 0;


            while (x != -1)
            {
                Console.Clear();

                Console.WriteLine("Digite um numero");
                x = int.Parse(Console.ReadLine());

                if (x > 0)
                {
                    y = x * 2;
                    Console.WriteLine("O resultado é:" + y);
                }

                else
                {
                    y = x * 3;
                    Console.WriteLine("O resultado é:" + y);
                }
                Console.ReadKey();
            }
        }
    }
}


