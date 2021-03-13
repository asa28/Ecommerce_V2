using System.ComponentModel.DataAnnotations;
using V2.DAL.InfraStructure;

namespace V2.DAL.Models
{
    public class Category:BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }
        
        public string Products { get; set; } // comma-seperated string for products
        public string Companies { get; set; } // comma-seperated string for compaines 
    }
}