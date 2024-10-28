using CarBook.Domain.Enums;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
    public class GetCarQueryResult
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string BigImageUrl { get; set; }
        public FuelType Fuel { get; set; }
        public TransmissionType Transmission { get; set; }
    }
}