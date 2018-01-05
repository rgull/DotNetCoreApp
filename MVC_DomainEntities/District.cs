using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_DomainEntities
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }

        [ForeignKey("SubLocation")]
        [Required]
        public int SubLocationId { get; set; }

        [Required]
        public string DistrictName { get; set; }

        [Required]
        public string DistrictName_Fr { get; set; }


        public virtual SubLocation SubLocation { get; set; }

    }

}
