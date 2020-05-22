using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brivia.Web.Data.Entities
{
    public class QuestionEntity
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Question { get; set; }

        public int IdCategory { get; set; }

        [Display(Name = "Correct Answer")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int CorrectAnswer { get; set; }

        [Display(Name = "Answer 1")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer1 { get; set; }

        [Display(Name = "Answer 2")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer2 { get; set; }

        [Display(Name = "Answer 3")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer3 { get; set; }

        [Display(Name = "Answer 4")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer4 { get; set; }
    }
}
