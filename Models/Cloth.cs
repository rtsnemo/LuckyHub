namespace StyleHub.Models
{
    public class Cloth
    {
        public int ClothId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public string ImageURL { get; set; }
    }
}
