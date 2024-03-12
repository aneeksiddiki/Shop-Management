using System.ComponentModel.DataAnnotations;

namespace Shop_Management.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
