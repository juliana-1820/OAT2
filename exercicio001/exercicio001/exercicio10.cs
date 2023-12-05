using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio10
    {
        public void Executarexerciciodez()
        {
            //O IMC – Índice de Massa Corporal é um critério da Organização Mundial
            //de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
            //adulta. A fórmula é: IMC = peso / (altura)2
            //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
            //sua condição de acordo com a tabela abaixo. IMC em adultos Condição
            //Abaixo de 18,5 Abaixo do peso. Entre 18,5 e 25 Peso normal. Entre 25 e
            //30 Acima do peso. Acima de 30 obeso.

            Console.WriteLine("Exercicio 09 - algoritmo que calcule seu peso ideal");
            Console.ReadKey();

            double altura, peso, imc;


            Console.WriteLine("Informe a sua altura(em metros)");
            
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);


            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso, pois seu IMC é:" + imc);
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Você está como um peso adequado, pois seu IMC é:" + imc);
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso, pois seu IMC é:" + imc);
            }
            else
            {
                Console.WriteLine("Você está obeso, pois seu IMC é:" + imc);
            }

            Console.ReadKey();
        }
    }
}
