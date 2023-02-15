using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Track
    {
        public Track(int size, Player player)
        {
            this.Size = size;
            this.Player = player;
            this.PlayerPosition = 0;
        }

        public int Size { get; set; }

        private int playerPosition;

        public int PlayerPosition
        {
            get { return this.playerPosition; }
            set { this.playerPosition = value; }
        }

        public Player Player { get; set; }

        public Boolean UpdateRacing()
        {
            Boolean win = false;

            if (this.PlayerPosition < this.Size)
            {
                this.PlayerPosition += this.Player.Run();
            }

            if (this.PlayerPosition >= this.Size)
            {
                win = true;
                this.PlayerPosition = this.Size;
            }

            return win;
        }

        public void ShowRacing()
        {
            String playerTrack = "";
            String viewTrack = "";

            for (int i = 1; i <= this.Size; i++)
            {
                viewTrack += "_";
                if (i == this.PlayerPosition)
                {
                    playerTrack += this.Player.Name;
                }
                else
                {
                    playerTrack += " ";
                }
            }

            //show track and player
            Console.WriteLine(playerTrack);
            Console.WriteLine(viewTrack);
        }

    }
}
