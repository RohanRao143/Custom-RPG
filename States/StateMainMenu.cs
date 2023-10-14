// More State Classes #3

// Rest of the states will be stacked upon the Main state as the part of the options, start, select, create etc

// Fleshing out states #4: to -> Will be decided based on the user input.


using System;
using System.Collections.Generic;
using System.Text;

namespace RpgGame
{
    class StateMainMenu : State
    {

        public StateMainMenu(Stack<State> states)
            : base(states)
        {
            Console.WriteLine("MainMenu");

            // this.states.Push(new StateGame(this.states));
        }

        override public void Update()
        {

            Console.WriteLine(Gui.MenuTitle("Game State"));

            Console.WriteLine(Gui.MenuOption(0, "Create Character"));
            Console.WriteLine(Gui.MenuOption(-1, "Exit"));



                // Fleshing out states #4: to

            Console.WriteLine("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                this.end = true;
            else
                Console.WriteLine("Entered Number: " + number);

        }
    }
}