using New_Online_Store.Enums;

namespace New_Online_Store.Interface
{
    public interface IElectronicsGeneralView
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public DeviceColor Color { get; set; }
        public double Price { get; set; }
    }
}
