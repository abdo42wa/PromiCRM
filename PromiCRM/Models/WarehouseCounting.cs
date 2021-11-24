﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PromiCRM.Models
{
    public class WarehouseCounting
    {
        [Key]
        public int Id { get; set; }
        public int QuantityProductWarehouse { get; set; }
        public string Photo { get; set; }
        public DateTime LastTimeChanging  { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        
    }
}
