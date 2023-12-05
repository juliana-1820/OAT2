using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Escolha o número do exercício (1 ao 12)");
                int numexercicio = int.Parse(Console.ReadLine());
                while(numexercicio > 0 || numexercicio <= 12)
                {
                    switch (numexercicio)
                    {
                        case 1:
                            Exercicio01 exercicio_01 = new Exercicio01();
                            exercicio_01.Executarexercicioum();
                            break;                          

                        case 2:
                            Exercicio02 exercicio_02 = new Exercicio02();
                            exercicio_02.Executarexerciciodois();
                            break;

                        case 3:
                            Exercicio03 exercicio_03 = new Exercicio03();
                            exercicio_03.Executarexerciciotres();
                            break;

                        case 4:
                            Exercicio04 exercicio_04 = new Exercicio04();
                            exercicio_04.Executarexercicioquatro();
                            break;

                        case 5:
                            Exercicio05 exercicio_05 = new Exercicio05();
                            exercicio_05.Executarexerciciocinco();
                            break;

                        case 6:
                            Exercicio06 exercicio_06 = new Exercicio06();
                            exercicio_06.Executarexercicioseis();
                            break;

                        case 7:
                            Exercicio07 exercicio_07 = new Exercicio07();
                            exercicio_07.Executarexerciciosete();
                            break;

                        case 8:
                            Exercicio08 exercicio_08 = new Exercicio08();
                            exercicio_08.Executarexerciciooito();
                            break;

                        case 9:
                            Exercicio09 exercicio_09 = new Exercicio09();
                            exercicio_09.Executarexercicionove();
                            break;

                        case 10:
                            Exercicio10 exercicio_10 = new Exercicio10();
                            exercicio_10.Executarexerciciodez();
                            break;

                        case 11:
                            Exercicio11 exercicio_11 = new Exercicio11();
                            exercicio_11.Executarexercicioonze();
                            break;

                        case 12:
                            Exercicio12 exercicio_12 = new Exercicio12();
                            exercicio_12.Executarexerciciodoze();
                            break;

                    }

                }

            } while (true);

        }
    }
}
