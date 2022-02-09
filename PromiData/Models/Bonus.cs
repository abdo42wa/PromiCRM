﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PromiData.Models
{
    public class Bonus
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public int Quantity { get; set; }
        public int Accumulated { get; set; }
        public int Bonusas { get; set; }
        /*        public int LeftUntil { get; set; }*/
    }
}