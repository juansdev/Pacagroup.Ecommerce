﻿using Pacagroup.Ecommerce.Application.DTO.Enums;

namespace Pacagroup.Ecommerce.Application.DTO
{
    public sealed record DiscountDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Percent {  get; set; }
        public DiscountStatusDto Status { get; set; }

    }
}
