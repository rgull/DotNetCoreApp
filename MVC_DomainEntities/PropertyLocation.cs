using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_DomainEntities
{
    public class PropertyLocation
    {
        [Key]
        public int PropertyLocationId { get; set; }

        [ForeignKey("Locations")]
        [Required]
        public int LocationId { get; set; }

        [ForeignKey("SubLocations")]
        [Required]
        public int SubLocationId { get; set; }

        [ForeignKey("Districts")]
        [Required]
        public int DistrictId { get; set; }

        [ForeignKey("Properties")]
        [Required]
        public int PropertyId { get; set; }

        public virtual District Districts { get; set; }
        public virtual Location Locations { get; set; }
        public virtual Property Properties { get; set; }
        public virtual SubLocation SubLocations { get; set; }

    }
}
