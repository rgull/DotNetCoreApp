using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_DomainEntities
{
    public class SubLocation
    {
        [Key]
        public int SubLocationId { get; set; }

        [ForeignKey("Location")]
        [Required]
        public int LocationId { get; set; }

        [Required]
        public string SubLocationName { get; set; }

        [Required]
        public string SubLocationName_Fr { get; set; }

        public virtual Location Location { get; set; }

    }

}
