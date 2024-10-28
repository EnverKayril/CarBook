﻿using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Results.BrandResult
{
    public class GetBrandByIdQueryResult
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}