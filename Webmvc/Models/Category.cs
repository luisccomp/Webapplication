using System.ComponentModel.DataAnnotations;

namespace Webmvc.Models
{
    public class Category
    {
        public long Id { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set;}
    }
}