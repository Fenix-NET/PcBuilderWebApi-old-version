﻿namespace PcBuilderWebApi.Dtos.CatalogDtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string ImageName { get; set; }
    }
}