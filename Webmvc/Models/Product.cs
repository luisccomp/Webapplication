using System.ComponentModel.DataAnnotations;

namespace Webmvc.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }

        [Required]
        public long CategoryId { get; set; }

        public Category Category { get; set; }
    }
}