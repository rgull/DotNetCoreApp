using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_DomainEntities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobilePhone { get; set; }

        [Required]
        public string OfficePhone { get; set; }

        [Required]
        public string SkypeName { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Address1_Fr { get; set; }

        public string Address2 { get; set; }

        public string Address2_Fr { get; set; }

        public string Description { get; set; }

        public string Description_Fr { get; set; }

        public string LocationSearch { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; } 

    }
}
