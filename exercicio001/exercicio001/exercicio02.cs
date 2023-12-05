using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio001
{
    public class Exercicio02
    {
        public void Executarexerciciodois()
        {
            //Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa.
            //Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo
            //de casada (anos).

            
            string nome, sexo, estadoc;
            int tempocasada = 0;

            Console.Write("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.Write("Informe o seu sexo (M - para MASCULINO e F - para FEMININO):");
            sexo = Console.ReadLine();

            Console.Write("Digite o seu estado civil:");
            estadoc = Console.ReadLine();

            if (sexo == "F" && estadoc == "casada")
            {
                Console.Write("Digite o seu tempo de casada (em anos):");
                tempocasada = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome:" + nome);
                Console.WriteLine("Sexo:" + sexo);
                Console.WriteLine("Estado Civil:" + estadoc);
                Console.WriteLine("Tempo de Casada:" + tempocasada, "anos");
            }
            else
            {
                Console.WriteLine("Nome:" + nome);
                Console.WriteLine("Sexo:" + sexo);
                Console.WriteLine("Estado Civil:" + estadoc);
            }
        }                     
    }
}
