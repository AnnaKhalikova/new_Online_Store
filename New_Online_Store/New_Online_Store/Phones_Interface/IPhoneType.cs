using New_Online_Store.Enums;
using New_Online_Store.Interface;

namespace New_Online_Store.Phones_Interface
{
    public interface IPhoneType : IElectronicsGeneralView
    {
        public new int ID { get; set; }
        public new string Model { get; set; }
        public new int Memory { get; set; }
        public new DeviceColor Color { get; set; }
        public new double Price { get; set; }


    }
}
