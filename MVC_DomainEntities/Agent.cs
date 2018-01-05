using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_DomainEntities
{
    public class Agent
    {

        [Key]
        public int AgentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        

        public string CompanyName { get; set; }

        

        [Required]
        public string MobilePhone { get; set; }

        public string OfficePhone { get; set; }

        [Required]
        public string Email { get; set; }

        public string Description { get; set; }

        

        public string Address1 { get; set; }

        

        public string Address2 { get; set; }

        

        public string ProfileImage { get; set; }

        public double Ratings { get; set; }




    }
}

