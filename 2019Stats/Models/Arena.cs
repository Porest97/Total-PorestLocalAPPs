﻿using System.ComponentModel.DataAnnotations;

namespace _2019Stats.Models
{
    public class Arena
    {
        public int Id { get; set; }

        [Display(Name = "Arena")]
        public string ArenaName { get; set; }
    }
}