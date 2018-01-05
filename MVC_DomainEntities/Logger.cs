using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_DomainEntities
{
    public class Logger
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ErrorDate { get; set; }

        [Required]
        public string ErrorDesc { get; set; }

        public string ErrorStack { get; set; }

    }
}
