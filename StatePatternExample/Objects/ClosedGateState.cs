using System;

namespace StatePatternExample.Objects
{
    public class ClosedGateState : IGateState
    {
        public IGateState Enter()
        {
            Console.WriteLine("Payment not yet received, remaining in closed state");
            return new ClosedGateState();
        }

        public IGateState Pay()
        {
            Console.WriteLine("Payment received, transferring to Pending state");
            return new PendingGateState();
        }

        public IGateState PayOk()
        {
            Console.WriteLine("Payment information received in wrong state, remaining in closed state");
            return new ClosedGateState();
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Payment information received in wrong state, remaining in closed state");
            return new ClosedGateState();
        }

        public void PrintState()
        {
            Console.WriteLine("The gate is currently closed");
        }
    }
}