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

        [MaxLength(200, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Question { get; set; }

        [MaxLength(30, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public CategoryEntity Category { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Correct Answer")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string CorrectAnswer { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Answer 1")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer1 { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Answer 2")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer2 { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Answer 3")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer3 { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Answer 4")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public virtual string Answer4 { get; set; }
    }
}
