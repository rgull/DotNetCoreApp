using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MVC_DomainEntities
{
    public class User 
    {

       public string FirstName { get; set; }

       public string LastName { get; set; }

       [Required]
       public string Email { get; set; }

       public string Address1 { get; set; }

       public string Address2 { get; set; }

       public string ProfileImage { get; set; }

    }
}
