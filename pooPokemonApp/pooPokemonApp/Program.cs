using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int acao = 100;
            while (acao != 0)
            {
                acao = Menu();
                if (acao == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (acao == 2)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("Digite o código do Pokemon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //get user pokemon
                    PokemonPlus pUser = pokedex.Pokemons[codigo];
                    //get system pokemon
                    Random random = new Random();
                    codigo = random.Next(0, pokedex.Pokemons.Count());
                    PokemonPlus pSystem = pokedex.Pokemons[codigo];
                    //batalhar
                    Console.WriteLine("-------- Pokemons escolhidos para a batalha --------");
                    Console.WriteLine("Seu Pokemon");
                    pUser.ExibirDadosPokemonPlus();
                    Console.WriteLine("Dados do seu oponente");
                    pSystem.ExibirDadosPokemonPlus();
                    if (pUser.Poder >= pSystem.Poder)
                    {
                        Console.WriteLine("Parabéns, você ganhou a batalha!");
                    }
                    else
                    {
                        Console.WriteLine("Que pena, você perdeu a batalha.");
                    }

                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        static int Menu()
        {
            Console.WriteLine("Batalha de Pokemons");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Exibir todos os Pokemons da Pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int acao = Convert.ToInt32(Console.ReadLine());
            return acao;
        }
    }
}
