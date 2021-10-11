namespace StatePatternExample.Objects
{
    public class Gate
    {
        public IGateState GateState { get; set; }

        public Gate(IGateState gateState)
        {
            GateState = gateState;
        }

        public Gate Enter()
        {
            return new Gate(GateState.Enter());
        }

        public Gate Pay()
        {
            return new Gate(GateState.Pay());
        }

        public Gate PayOk()
        {
            return new Gate(GateState.PayOk());
        }

        public Gate PayFailed()
        {
            return new Gate(GateState.PayFailed());
        }

        public void PrintState()
        {
            GateState.PrintState();
        }
    }
}