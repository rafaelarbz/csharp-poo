using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set {
                nome = value.ToUpper(); 
            }
        }

        private String descricao;

        public String Descricao
        {
            get { return this.descricao; }
            set { 
                this.descricao = value.ToUpper(); 
            }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine("Descrição do Pokemon: " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatado)
        {
            if (formatado == true)
            {
                Console.WriteLine("Pokemon " + this.Nome + ": " + this.Descricao.ToLower());
            }
            else
            {
                Console.WriteLine("Nome do Pokemon: " + this.Nome);
                Console.WriteLine("Descrição do Pokemon: " + this.Descricao);
            }
        }
    }
}
