using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.Model
{
    public class sellercredentials
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="Name Length should be less than 50")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Designation  should be less than 50 characters")]
        public string Designation { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage ="Password should be in ")]
        public string Password { get; set; }
    

}
}
