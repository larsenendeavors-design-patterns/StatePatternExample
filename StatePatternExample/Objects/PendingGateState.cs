using System;

namespace StatePatternExample.Objects
{
    public class PendingGateState : IGateState
    {
        public IGateState Enter()
        {
            Console.WriteLine("Payment not finished processing, remaining in pending state");
            return new PendingGateState();
        }

        public IGateState Pay()
        {
            Console.WriteLine("Payment not finished processing, please wait, remaining in pending state");
            return new PendingGateState();
        }

        public IGateState PayOk()
        {
            Console.WriteLine("Payment finished processing, transferring to open state");
            return new OpenGateState();
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Payment failed processing, transferring to closed state");
            return new ClosedGateState();
        }

        public void PrintState()
        {
            Console.WriteLine("The gate is currently pending");
        }
    }
}