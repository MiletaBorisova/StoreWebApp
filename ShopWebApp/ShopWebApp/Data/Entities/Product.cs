using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Data.Entities
{
    public class Product
    {
        public Product()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? ProductName { get; set; }

        [Required]
        public string? Picture { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<Purchase> Purchases { get; set; } = null!;
    }
}
