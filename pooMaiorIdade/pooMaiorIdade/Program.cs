using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3;

            Console.WriteLine("Quem é a pessoa mais velha?");
            
            Console.WriteLine("1º Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("1ª Idade: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2º Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("2ª Idade: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3º Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("3ª Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);
            
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é ");
                p1.ExibirDados();
           
            }else if((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é ");
                p2.ExibirDados();
            }else if((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
            {
                Console.WriteLine("A pessoa mais velha é ");
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("Todas as pessoas possuem a mesma idade!");
            }

            Console.ReadKey();
        }
    }
}
