using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace MVC_DomainEntities
{
    public class PropertyType
    {
        [Key]
        public int PropertyTypeId { get; set; }

        [Required]
        public string PropertyTypeName { get; set; }

        [Required]
        public string PropertyTypeName_Fr { get; set; }

    }
}
