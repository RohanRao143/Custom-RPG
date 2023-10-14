// State Class #2

// Game State will be stacked based on the user descisions
//  either to move Ahead or to pop the same state from the current stack


using System;
using System.Collections.Generic;
using System.Text;

namespace RpgGame
{
    class State
    {

        protected Stack<State> states;

        // Fleshing out states #4: to

        protected bool end = false;

        public State(Stack<State> states)
        {
            this.states = states;


            // Console.WriteLine(states.GetHashCode());
        }

        public bool RequestEnd()
        {
            return this.end;
        }

        virtual public void Update()
        {
              


        }
    }
}