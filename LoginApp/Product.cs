namespace LoginApp
{
    internal class Product
    {
        public string name { get; set; }
        public int id { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
        public bool isBlocked { get; set; }
        public int userId { get; set; }

        public Product(string name, int id, float price, string description, int stock, bool isBlocked, int userId)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.description = description;
            this.stock = stock;
            this.isBlocked = isBlocked;
            this.userId = userId;
        }
    }
}
