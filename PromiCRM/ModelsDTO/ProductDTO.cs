﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PromiCRM.ModelsDTO
{
    public class CreateProductDTO
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string Photo { get; set; }
        public string Link { get; set; }
        [Required]
        public string code { get; set; }
        public string Category { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 10, ErrorMessage = "The Product  Name cannot be more than 100 or less than 10 ")]
        public string Name { get; set; }
        [Required]
        public double LengthWithoutPackaging { get; set; }
        [Required]
        public double WidthWithoutPackaging { get; set; }
        [Required]
        public double HeightWithoutPackaging { get; set; }
        [Required]
        public double WeightGross { get; set; }
        [Required]
        public string PackagingBoxCode { get; set; }
        [Required]
        public double PackingTime { get; set; }
        [Required]
        public int ServiceId { get; set; }
    }

    public class UpdateProductDTO : CreateProductDTO
    {

    }
    public class ProductDTO : CreateProductDTO
    {
        public int Id { get; set; }
        public OrderDTO Order { get; set; }
        public ServiceDTO Services { get; set; }
        //public virtual IList<MaterialDTO> Materials { get; set; }

    }
}
