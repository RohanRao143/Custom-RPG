// More State Classes #3

// Rest of the states will be stacked upon the Main state as the part of the options, start, select, create etc


using System;
using System.Collections.Generic;
using System.Text;

namespace RpgGame
{
    class StateGame : State
    {

        public StateGame(Stack<State> states)
            : base(states)
        {


            // Console.WriteLine("GameMenu");
        }
    }
}