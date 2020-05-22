using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brivia.Web.Data.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }
    }
}
