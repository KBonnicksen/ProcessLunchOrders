namespace ProcessLunchOrders
{
    internal class Food
    {
        public decimal totalPrice;

        public string addOn1;
        public string addOn2;
        public string addOn3;

        public decimal addOnPrice;

        public void AddItem()
        {
            this.totalPrice += this.addOnPrice;
        }

        public void TakeItemOffOrder()
        {
            this.totalPrice -= this.addOnPrice;
        }
    }
}