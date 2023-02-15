using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            //Instanciar
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasauro", "descrição bulbasauro", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Raticate", "descrição raticate", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Caterpie", "descrição caterpie", 75);
            this.pokemons.Add(p);
            p = new PokemonPlus("Horsea", "descrição horsea", 95);
            this.pokemons.Add(p);
            p = new PokemonPlus("Weedle", "descrição weedle", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Seel", "descrição seel", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Cubone", "descrição cubone", 80);
            this.pokemons.Add(p);
            p = new PokemonPlus("Clefairy", "descrição clefairy", 85);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ekans", "descrição ekans", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Oddish", "descrição oddish", 65);
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do Pokemon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }
    }
}
