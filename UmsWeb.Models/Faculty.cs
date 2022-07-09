using System.ComponentModel.DataAnnotations;
namespace UmsWeb.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Faculty")]
        public string Name { get; set; }
    }
}
