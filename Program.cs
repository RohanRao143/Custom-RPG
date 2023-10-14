// See https://aka.ms/new-console-template for more information


// Instance of Game will be main purpose and Any details can be added.

using System;

namespace RpgGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            Console.WriteLine(Gui.Title("WELCOME"));

            game.Run(); 
        }
    }
}