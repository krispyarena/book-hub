using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bookhub_razor.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("DisplayOrder")]
        [Range(1,100, ErrorMessage = "The feild Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
