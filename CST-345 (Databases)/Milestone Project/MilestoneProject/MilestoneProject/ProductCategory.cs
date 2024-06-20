namespace MilestoneProject
{
    internal class ProductCategory
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ProductCategory(int categoryID, string name, string description)
        {
            this.CategoryID = categoryID;
            this.Name = name;
            this.Description = description;
        }
    }
}