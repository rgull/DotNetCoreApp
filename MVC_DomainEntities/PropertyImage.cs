using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_DomainEntities
{
    public class PropertyImage
    {
        [Key]
        public int PropertyImagesId { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [ForeignKey("Properties")]
        [Required]
        public int PropertyId { get; set; }

        [Required]
        public bool Featured { get; set; }


        public virtual Property Properties { get; set; }
    }
}
