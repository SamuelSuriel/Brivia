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

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string CorrectAnswer { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string IncorrectAnswers { get; set; }
    }
}
