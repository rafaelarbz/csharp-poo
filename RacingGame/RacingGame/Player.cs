using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Player
    {
        public static Random random = new Random();
        public Player()
        {
            this.Name = "";
        }
        public Player(String nome)
        {
            this.Name = nome;
        }

        private String name;

        public String Name
        {
            get { return this.name; }
            set {
                this.name = value.ToUpper();
                if (value.Length > 1) this.name = value[0].ToString().ToUpper();
                if (value.Length == 0) this.name = "P";
            }
        }

        public int Run()
        {
           return Player.random.Next(1, 10);
        }
    }
}
