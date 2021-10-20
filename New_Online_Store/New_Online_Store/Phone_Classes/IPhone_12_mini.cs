using New_Online_Store.Enums;
using New_Online_Store.Phones_Interface;

namespace New_Online_Store.Phone_Classes
{
    public class IPhone_12_mini : Phone, IPhoneTypeFeatures
    {
        public string PhoneVendorCode { get; set; }

        public IPhone_12_mini()
        {
        }

        public IPhone_12_mini(int iD, string model, int memory, DeviceColor color, double price, string phoneVendorCode)
            : base(iD, model, memory, color, price)
        {
            PhoneVendorCode = phoneVendorCode;
        }

        public override string ToString()
        {
            return base.ToString() + " / Артикул: " + PhoneVendorCode;
        }
    }
}
