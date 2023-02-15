using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de perguntas
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
            //pergunta exibida aleatoriamente
            Random random = new Random();
            int index = random.Next(0, perguntas.Count());
            NovaPergunta pergunta = perguntas[index];
            //logica
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";
            while (tentativas < 3 && flag == false )
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                Console.Write("Sua resposta é: ");
                resposta = Console.ReadLine();
                if (resposta.ToLower() == pergunta.Resposta.ToLower())
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Incorreto. Dica: " + pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabéns, você ganhou!");
            }
            else
            {
                Console.WriteLine("Que pena, você perdeu.");
            }
            
            Console.ReadKey();
        }

        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            lista.Add(new NovaPergunta("Qual a cor do céu?", "Azul", "Começa com a letra A"));
            lista.Add(new NovaPergunta("Qual a cor do Sol?", "Amarelo", "Mesma cor das pétalas do Girassol"));
            lista.Add(new NovaPergunta("Qual a cor produzida pela Clorofila?", "Verde", "Começa com a letra V"));
            lista.Add(new NovaPergunta("Que país tem o formato de uma bota?", "Itália", "Começa com a letra I"));
            lista.Add(new NovaPergunta("Quantos ossos temos no nosso corpo?", "206", "Mais de 100 e menos que 300"));
            lista.Add(new NovaPergunta("Qual o maior planeta do sistema solar?", "Júpiter", "Começa com a letra J"));
            lista.Add(new NovaPergunta("Qual o planeta mais próximo do Sol?", "Mercúrio", "Começa com a letra M"));
            lista.Add(new NovaPergunta("O que os pandas comem?", "Bambu", "Começa com a letra B"));
            lista.Add(new NovaPergunta("Que fruto nasce da oliveira?", "Azeitona", "Começa com a letra A"));
            lista.Add(new NovaPergunta("Que navio famoso naufragou na sua viagem inaugural?", "Titanic", "Começa com a letra T"));
            return lista;
        }
    }
}
