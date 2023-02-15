using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoPitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();

            String resposta = "S";
            while (resposta != "N")
            {
                Console.Clear();

                Console.WriteLine("A hora do Pitch");

                Console.WriteLine("Informe a duração do Pitch: ");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a frequência do Efeito Sonoro (1 à 500): ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());

                alarme.EfeitoSonoro = efeitoSonoro;
                alarme.Tempo = tempo;
                alarme.Iniciar();
                Console.WriteLine("Opss, seu tempo acabou!");

                Console.Write("Executar o programa novamente: S/N");
                resposta = Console.ReadLine().ToUpper();

            }

        }
    }
}
