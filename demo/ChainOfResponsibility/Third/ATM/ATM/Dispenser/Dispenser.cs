namespace ATM
{
    public class Dispenser : IDispenser
    {

        private readonly IBill _bill;
        protected IDispenser _next;

        public Dispenser(IBill bill)
        {
            _bill = bill;
            _next = EndofChainHandler.Instance;
        }

        public void SetNext(IDispenser next)
        {
            _next = next;
        }
        public int Dispense(int amount)
        {
            if (amount < _bill.Denomination)
                return _next.Dispense(amount);

            int remaining = _bill.WithdrawBills(amount);
            if (remaining != 0)
                return _next.Dispense(remaining);

            return remaining;
        }
    }
}
