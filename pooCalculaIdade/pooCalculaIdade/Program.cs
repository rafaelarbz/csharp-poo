using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa");

            Console.Write("Nome: ");
            String nomePessoa = Console.ReadLine();

            Console.Write("Ano de nascimento: ");
            int anoNascimentoPessoa = Convert.ToInt32(Console.ReadLine());

            Pessoa p = new Pessoa(nomePessoa, anoNascimentoPessoa);
            //Console.WriteLine("Digite o nome da pessoa: ");
            //p.Nome = Console.ReadLine();

            //Console.WriteLine("Digite o ano de nascimento: ");
            //p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            p.ExibirDados();
            //Console.WriteLine(p.Idade);
            Console.ReadKey();
        }
    }
}
