using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_DomainEntities
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public string LocationName { get; set; }

        [Required]
        public string LocationName_Fr { get; set; }

    }

}
