using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio11
    {
        public void Executarexercicioonze()
        {

            //Algoritmo que calcule o que deve ser pago por um produto, considerando o preço normal
            //de etiqueta e a escolha da condição de pagamento. Utilize os códigos da tabela a seguir
            //para ler qual a condição de pagamento escolhida e efetuar o cálculo adequado. Código condição
            //pagamento: 1- à vista em dinheiro ou cheque, recebe 10% de desconto. 2- à vista no cartão de
            //crédito, recebe 15% de desconto. 3- em duas vezes, preço normal de etiqueta sem juros. 4- em
            //duas vezes, preço normal de etiqueta mais juros de 10%.

            double preconormal, valorpag;
            int condicaopag;

            Console.WriteLine("Exercicio 11 - algoritmo que calcule o preço a ser pago");
            Console.ReadKey();


            Console.WriteLine("Digite o preço normal de etiqueta:");
            preconormal = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a condição de pagamento:");
            Console.WriteLine("1- À vista em dinheiro ou cheque (com 10% de desconto)");
            Console.WriteLine("2- À vista no cartão de crédito (com 15% de desconto)");
            Console.WriteLine("3- Em duas vezes (preço normal sem juros)");
            Console.WriteLine("4- Em duas vezes (preço normal com juros de 10%)");
            condicaopag = int.Parse(Console.ReadLine());

            switch (condicaopag)
            {
                case 1:
                    valorpag = preconormal * 0.9;
                    break;
                case 2:
                    valorpag = preconormal * 0.85;
                    break;
                case 3:
                    valorpag = preconormal;
                    break;
                case 4:
                    valorpag = preconormal * 1.1;
                    break;
                default:
                    Console.WriteLine("Código inválido, por favor digite novamente");
                    return;
            }

            Console.WriteLine("O valor a ser pago é:" + valorpag);



        }
    }
}
