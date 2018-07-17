using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AGH_TJI.API.Models
{
    public partial class People
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Your title is required")]
        public string Title { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Your Forename is required")]
        public string Forename { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Your Surname is required")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"(1[8-9]|[2-9][0-9])", ErrorMessage = "Your age should be in range from 10 to 199")]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"([0-9]){9}", ErrorMessage = "Your phone number has incorrect format!")]
        public int Phone { get; set; }

        [Required]
        [RegularExpression(@"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+\.)+[a-z]{2,5}$", ErrorMessage = "Your email has incorrect format!")]
        public string Email { get; set; }
        
    }
}
