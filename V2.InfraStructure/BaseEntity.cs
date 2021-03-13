using System;
using System.ComponentModel.DataAnnotations;

namespace V2.InfraStructure
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        [MaxLength(128)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(128)]
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}