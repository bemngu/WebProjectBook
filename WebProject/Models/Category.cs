﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       [DisplayName("Display Order")]
       [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public string DisplayOrder { get; set; }
      
    }
}
