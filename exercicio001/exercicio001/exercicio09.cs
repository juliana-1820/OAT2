using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio09
    {
        public void Executarexercicionove()
        {
            //Tendo como dados de entrada a altura e o sexo de uma pessoa, construa
            //um algoritmo que calcule seu peso ideal, utilizando as seguintes
            //fórmulas:● para homens: (72.7 * h) – 58; ● para mulheres: (62.1 * h) – 44.7.



            Console.WriteLine("Exercicio 09 - algoritmo que calcule seu peso ideal");
            Console.ReadKey();

            int altura;
            int sexo;
            double pesoideal = 0;


            Console.WriteLine("Informe a sua altura(em centímetros)");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha: 1- Sexo Masculino / 2- Sexo Feminino: ");
            sexo = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                pesoideal = (72.7 * altura) - 58;
                Console.WriteLine("Seu peso ideal é:" + pesoideal);

            }
            else
            {
                pesoideal = (62.1 * altura) - 44.7;
                Console.WriteLine("Seu peso ideal é:" + pesoideal);

            }
            Console.ReadKey();

        }
    }
}
