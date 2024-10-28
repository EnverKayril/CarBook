using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Results.BrandResult
{
    public class GetBrandQueryResult
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}