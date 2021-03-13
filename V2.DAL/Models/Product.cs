using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using V2.DAL.InfraStructure;

namespace V2.DAL.Models
{
    public class Product:BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public Category Category { get; set; }

        public string SerialNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}