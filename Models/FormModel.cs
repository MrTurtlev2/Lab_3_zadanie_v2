using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab3_test.Models
{
    public class FormModel
    {  
        
        [Required]
        [Display(Name = "Enter your name")]
     
        public string Name { get; set; }

        [Display(Name = "Enter Repeat number between 1 and 5")]
        [Range(1, 5)]
        public int RepeatValue { get; set; }
      
    }
}
