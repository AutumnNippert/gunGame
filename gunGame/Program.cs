//Importing all things ya need
using System;

//Using namespace lets the program use other files with the same namespace (ie the other classes we've made)
namespace gunGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calls startGame
            startGame();
        }

        static void startGame()
        {
            Player player = new Player();
            player.initPlayer(24, );
        }
    }
}
