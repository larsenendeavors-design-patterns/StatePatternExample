using System;

namespace StatePatternExample.Objects
{
    public class OpenGateState : IGateState
    {
        public IGateState Enter()
        {
            Console.WriteLine("Gate Opened, entering Closed State");
            return new ClosedGateState();
        }

        public IGateState Pay()
        {
            Console.WriteLine("Payment already received, no state change, remaining open");
            return new OpenGateState();
        }

        public IGateState PayOk()
        {
            Console.WriteLine("Payment already received, no state change, remaining open");
            return new OpenGateState();
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Payment already received, no state change, remaining open");
            return new OpenGateState();
        }

        public void PrintState()
        {
            Console.WriteLine("The gate is currently open");
        }
    }
}