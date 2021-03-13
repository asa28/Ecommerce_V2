using System;
using System.ComponentModel.DataAnnotations;
using V2.DAL.InfraStructure;

namespace V2.DAL.Models
{
    public class Company:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string FaxNumber { get; set; }
        public DateTime AddedDate { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
    }
}