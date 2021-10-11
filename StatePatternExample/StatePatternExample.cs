using System;
using StatePatternExample.Objects;

namespace StatePatternExample
{
    internal static class StatePatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Christopher Okhravi YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/11
         */
        
        private static void Main()
        {
            // The gist of the State Pattern is to have an implementation of an interface that handles different states
            // In this example we also demonstrate how one can make the object immutable, and to allow it to be chained.
            // I think chains are super cool :D 
            
            var gate = new Gate(new ClosedGateState());
            gate = gate.Enter().Pay().PayFailed().Pay().PayOk();
            gate.PrintState();
            gate = gate.Enter();
            gate.PrintState();
        }
    }
}