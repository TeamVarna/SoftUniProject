using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeIt.Models
{
    public class CreateCodeModel
    {
        [Required]
        [Display(Name = "Code Title")]
        [StringLength(200)]
        public string CodeTitle { get; set; }

        [Required]
        public string CodeContent { get; set; }


    }
}