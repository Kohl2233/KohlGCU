namespace MilestoneProject
{
    internal class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int VendorID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(int productID, int categoryID, int vendorID, string name, float price)
        {
            this.ProductID = productID;
            this.CategoryID = categoryID;
            this.VendorID = vendorID;
            this.Name = name;
            this.Price = price;
        }
    }
}