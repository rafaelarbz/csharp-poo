using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a;
            int tl = 0;
            Animal[] animais = new Animal[20];

            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;
            int tipoAnimal = 0;

            Console.WriteLine("Controle de Animais");

            try
            {
                Console.Write("Quantos animais deseja informar (máximo 20): ");
                tl = Convert.ToInt32(Console.ReadLine());
                if (tl > 20) tl = 20;
            }
            catch
            {
                tl = 0;
            }

            for ( int i = 0; i < tl; i++ )
            {
                a = new Animal();

                Console.Write("Digite o nome do "+ (i+1) +"º animal: ");
                a.Nome = Console.ReadLine();
                Console.Write("Informe o tipo do " + (i+1) + "º animal ( 0 - Cachorro, 1 - Gato ou 2 - Peixe): ");

                try
                {
                    tipoAnimal = Convert.ToInt32(Console.ReadLine());
                    if (tipoAnimal < 0) tipoAnimal = 2;
                    if (tipoAnimal > 2) tipoAnimal = 2;
                }
                catch
                {
                    tipoAnimal = 2;
                }

                a.Tipo = (TipoAnimal)tipoAnimal;

                //contar tipo informado
                if (a.Tipo == TipoAnimal.Cachorro) tlCachorro++;
                if (a.Tipo == TipoAnimal.Gato) tlGato++;
                if (a.Tipo == TipoAnimal.Peixe) tlPeixe++;

                //armazenar o animal no vetor
                animais[i] = a;
            }

            #region Resultado
            Console.WriteLine("Total de Animais: ");
            Console.WriteLine("Cachorros: "+tlCachorro+" \nGatos: "+tlGato+" \nPeixes: "+tlPeixe);
            Console.WriteLine("Detalhes: ");
       
            for ( int i = 0; i < tl; i++ )
            {
                Console.WriteLine((i+1) + "º - Nome: " + animais[i].Nome + ", Tipo: " + animais[i].Tipo);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
