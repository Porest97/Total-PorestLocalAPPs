﻿using System.ComponentModel.DataAnnotations;

namespace NBSUltra.Models.DataModels
{
    public class OrderStatus
    {
        public int Id { get; set; }

        [Display(Name ="Status")]
        public string OrderStatusName { get; set; }
    }
}