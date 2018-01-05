using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVC_DomainEntities
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Title_Fr { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Description_Fr { get; set; }

        [Required]
        public int Price { get; set; }

        [ForeignKey("PropertyTypes")]
        [Required]
        public int PropertyTypeId { get; set; }

        public int Bathrooms { get; set; }

        public int Bedrooms { get; set; }

        public int Area { get; set; }

        public int Ratings { get; set; }

        [Required]
        public bool Featured { get; set; }

        [Required]
        public string LocationSearch { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
        
        public virtual PropertyType PropertyTypes { get; set; }

        public string PropertyImage { get; set; }

    }

}
