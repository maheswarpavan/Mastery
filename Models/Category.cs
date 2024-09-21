using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mastery.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Display Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }

}
