using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandonWebsite06.Models
{
    public class Companies
    {
        
        
        
        //public int PhotoID { get; set; }

        //[DisplayName("Picture")]
        
        //public string PhotoFileName { get; set; }

        
       //public string ImageMimeType { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Name is required!")]
        public string companyName { get; set; }

        [Required(ErrorMessage = "You need a company ID")]
        //[IntegerLength(5)]


        [Key]
        [ScaffoldColumn(false)]

        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "boothnumber")]      
        public int boothnumber { get; set; }

        

    }
    
}
