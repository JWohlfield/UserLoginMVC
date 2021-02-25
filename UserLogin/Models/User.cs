using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserLogin.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage ="User Name is required!")]
        public string UserId { get; set; }

        [Required(ErrorMessage ="Password is required!")]
        [StringLength(12, MinimumLength =5,ErrorMessage ="Password must be between 5-12 characters!")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Age is required!")]
        [Range(5,130,ErrorMessage ="Age must be between 5-130!")]
        public int Age { get; set; }
    }
}
