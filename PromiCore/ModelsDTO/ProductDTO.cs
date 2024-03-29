﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PromiCore.ModelsDTO
{
    public class CreateProductDTO
    {
        //public int OrderId { get; set; }
        //for photo
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public IFormFile File { get; set; }
        public string Link { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double LengthWithoutPackaging { get; set; }
        public double WidthWithoutPackaging { get; set; }
        public double HeightWithoutPackaging { get; set; }
        public double LengthWithPackaging { get; set; }
        public double WidthWithPackaging { get; set; }
        public double HeightWithPackaging { get; set; }
        public double WeightGross { get; set; }
        public double WeightNetto { get; set; }
        public string PackagingBoxCode { get; set; }
        public IList<OrderServiceDTO> OrderServices { get; set; }
    }

    public class UpdateProductDTO
    {
        //public int OrderId { get; set; }
        //for photo
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public IFormFile File { get; set; }
        public string Link { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double LengthWithoutPackaging { get; set; }
        public double WidthWithoutPackaging { get; set; }
        public double HeightWithoutPackaging { get; set; }
        public double LengthWithPackaging { get; set; }
        public double WidthWithPackaging { get; set; }
        public double HeightWithPackaging { get; set; }
        public double WeightGross { get; set; }
        public double WeightNetto { get; set; }
        public string PackagingBoxCode { get; set; }
        public IList<OrderServiceDTO> OrderServices { get; set; }
    }
    public class ProductDTO : CreateProductDTO
    {
        public int Id { get; set; }

        //public OrderDTO Order { get; set; }
        public IList<OrderDTO> Orders { get; set; }
        /* public ServiceDTO Service { get; set; }*/
        //public virtual IList<ProductMaterialDTO> ProductMaterials { get; set; }
        public IList<ProductMaterialDTO> ProductMaterials { get; set; }
        public IList<RecentWorkDTO> RecentWorks { get; set; }

        /*public IList<ProductServiceDTO> ProductServices { get; set; }*/
    }
}
