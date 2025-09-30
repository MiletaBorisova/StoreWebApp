using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Data.Entities
{
    public class Client
    {
        public Client()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public int EGN { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public ICollection<Purchase> Purchases { get; set; } = null!;
    }
}
