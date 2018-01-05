using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_DomainEntities
{
    public class ContractType
    {

        [Key]
        public int ContractTypeId { get; set; }

        [Required]
        public string ContractTypeName { get; set; }

        [Required]
        public string ContractTypeName_Fr { get; set; }

    }

}
