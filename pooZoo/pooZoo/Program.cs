using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalPlus> animais = new List<AnimalPlus>();

            #region contar Carnivoros e Herbivoros

            int countCar = 0, countHer = 0;
            Console.WriteLine("Sistema que confere quantidade de animais Carnivoros e Herbivoros");

            for (int i = 0; i < 4; i++ )
            {
                AnimalPlus animal = new AnimalPlus();

                Console.Write("Espécie: ");
                animal.Especie = Console.ReadLine();

                Console.Write("Peso: ");
                animal.Peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Tipo de alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();

                animais.Add(animal);

                if (animal.TipoAlimentacao.ToLower() == "carnivoro" || animal.TipoAlimentacao.ToLower() == "carnívoro")
                { countCar++; }
                else { countHer++; }
            }

            #endregion

            Console.Write("Total de animais carnívoros: " + countCar );
            Console.WriteLine("Total de animais herbívoros: " + countHer );
            Console.ReadKey();
        }
    }
}
