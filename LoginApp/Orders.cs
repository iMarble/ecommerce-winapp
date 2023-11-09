namespace LoginApp
{
    internal class Orders
    {
        public int OrderId { get; set; }
        public int BuyerId { get; set; }
        public string ProductName { get; set; }
        public string BuyerName { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerPhone { get; set; }
        public string Payment { get; set; }
        public float Productprice { get; set; }
        public int stock { get; set; }
        public bool isDelievered { get; set; }

        public Orders(int orderId, int buyerId, string productName, string buyerName, string buyerAddress, string buyerPhone, string payment, float productprice, int stock, bool isDelievered)
        {
            OrderId = orderId;
            BuyerId = buyerId;
            ProductName = productName;
            BuyerName = buyerName;
            BuyerAddress = buyerAddress;
            BuyerPhone = buyerPhone;
            Payment = payment;
            Productprice = productprice;
            this.stock = stock;
            this.isDelievered = isDelievered;
        }
    }
}
