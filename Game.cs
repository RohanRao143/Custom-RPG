// Game Class #1

// Manage the start and exit of game which includes all initializations

// Fleshing out states #4: from -> Move to respective states


using System;
using System.Collections.Generic;
using System.Text;

namespace RpgGame
{
    class Game
    {

        //members (Variables)

        private bool end;

        private Stack<State> states;

        // Private functions
        private void InitVariables()
        {
            this.end = false;
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            this.states.Push(new StateMainMenu(this.states));
        }


        // Constructors and Destructors

        public Game()
        {
            this.InitVariables();
            this.InitStates();
            
            Console.WriteLine("Hello, From the Game Class");
        }

        public void Run()
        {
            while(this.states.Count > 0)
            {


                // Fleshing out states #4: from


                if (this.states.Count > 0)
                {
                    this.states.Peek().Update();

                    if (this.states.Peek().RequestEnd())
                    {
                        this.states.Pop();

                        Console.WriteLine( this.states.Count);
                    }

                }

                
            }

            Console.WriteLine("Ending Game.......");
        }

    }
}