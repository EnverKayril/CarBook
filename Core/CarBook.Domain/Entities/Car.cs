using CarBook.Domain.Enums;

namespace CarBook.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string BigImageUrl { get; set; }
        public FuelType Fuel { get; set; }
        public TransmissionType Transmission { get; set; }
        public List<CarFeature> Features { get; set; }
        public List<CarDescription> Descriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}