using System;
using System.ComponentModel.DataAnnotations;
using V2.DAL.InfraStructure;

namespace V2.DAL.Models
{
    public class User:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Is_Active { get; set; }
    }
}