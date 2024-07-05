using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.Model
{
    public class RegistrationModel
    {
        public int id { get; set; }
        [Required]
         [MinLength(3)]
         [MaxLength(50)]
         public string FirstName { get; set; }

         [Required]
         [MinLength(3)]
         [MaxLength(50)]
         public string LastName { get; set; }

         [Required]
         [EmailAddress]
         public string Email { get; set; }
         [Phone]
         public string Phone { get; set; }
         [Required]
         public string Address { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string State { get; set; }

        }
    }


