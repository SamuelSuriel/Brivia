using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brivia.Web.Data.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Gain 
        {
            get => Gain;
            set => Gain = 0;
        }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Lost 
        { 
            get => Lost;
            set => Lost = 0;
        }
    }
}
