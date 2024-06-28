using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.Model
{
    //create a public class and inherit IdentityUser to create more columns in database for more user info
    public class ApplicationUser:IdentityUser
    {
        //if we need to make changes in here, we must add migration for the change and update database
        [Required]
        public String? Name {  get; set; }

        public string? StreetAddress {  get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }

        //add foreign key property
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company? Company { get; set; }


    }
}
