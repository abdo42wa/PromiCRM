﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PromiCRM.ModelsDTO
{
    public class CreateProductMaterialDTO
    {
        [Required]
        public int Quantity { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        [Required]
        public int MaterialWarehouseId { get; set; }
    }
    public class UpdateProductMaterialDTO : CreateProductMaterialDTO
    {
        public int Id { get; set; }
    }

    public class ProductMaterialDTO : CreateProductMaterialDTO
    {
        public int Id { get; set; }
        public ProductDTO Product { get; set; }
        public OrderDTO Order { get; set; }
        public MaterialWarehouseDTO MaterialWarehouse { get; set; }

    }
}
