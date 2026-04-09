using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkCodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")] 
        public Category Category { get; set; }
    }
}