using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookHub.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name {  get; set; }

        public string? StreetAddress { get; set; }
        public string? City {  get; set; }
        public string? State { get; set; }
        public string? PostalCode {  get; set; }
    }
}
