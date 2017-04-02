using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
    public class StringState : State
    {
        private string state; // the state represented by a string
        private double cost; // cost to reach this state (set by a setter)
        private State cameFrom; // the state we came from to this state (setter)
        public StringState(string state) // CTOR
        {
            this.state = state;
        }
        public bool Equals(State s) // we overload Object's Equals method
        {
            return state.Equals((s as StringState).state);
        }
        // ...
    }
}
