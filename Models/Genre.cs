﻿using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
