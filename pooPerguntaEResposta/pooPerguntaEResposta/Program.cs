using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual linguagem de programação utilizada neste sistema?";
            p.Resposta = "C#";
            p.Dica = "É uma linguagem de programação, multiparadigma, de tipagem forte, \n desenvolvida pela Microsoft como parte da plataforma .NET.";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("Sua resposta é: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns, você acertou!");
            }
            else
            {
                Console.WriteLine("Que pena, você errou.");
                Console.WriteLine("A resposta certa é: " + p.Resposta);
            }

            Console.ReadKey();
            
        }
    }
}
