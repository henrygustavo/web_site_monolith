﻿namespace Web.Site.Product.Application.Dto
{
    using Web.Site.Common.Domain.Enum;

    public class ProductCreateDto
    {
        public  string Name { get; set; }
        public  string PictureUrl { get; set; }
        public  string Description { get; set; }
        public decimal Balance { get; set; }

        public int CategoryId { get; set; }
        public Currency Currency { get; set; }
    }
}
