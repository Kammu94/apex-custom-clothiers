namespace ApexCustomClothiers.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public List<string> Inclusions { get; set; }
        public bool IsActive { get; set; }
    }
}