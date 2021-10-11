namespace StatePatternExample.Objects
{
    public interface IGateState
    {
        public IGateState Enter();
        public IGateState Pay();
        public IGateState PayOk();
        public IGateState PayFailed();
        public void PrintState();
    }
}