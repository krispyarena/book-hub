using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookHub.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1,100, ErrorMessage = "The field Display Order must be between 1-100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
