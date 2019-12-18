using System;

namespace ATM
{
    public class EndofChainHandler : IDispenser
    {
        public static EndofChainHandler Instance { get { return _instance; } }

        private EndofChainHandler() { }

        public int Dispense(int amount)
        {
            return amount;
        }
        public void SetNext(IDispenser next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain");
        }
        
        private static readonly EndofChainHandler _instance = new EndofChainHandler();
    }
}
