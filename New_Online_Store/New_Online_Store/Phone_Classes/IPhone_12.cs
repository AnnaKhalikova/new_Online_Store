using New_Online_Store.Enums;
using New_Online_Store.Phones_Interface;

namespace New_Online_Store.Phone_Classes
{
    public class IPhone_12 : Phone, IPhoneTypeFeatures
    {
        public string PhoneVendorCode { get; set; }

        public IPhone_12()
        {
        }

        public IPhone_12(int iD, string model, int memory, DeviceColor Color, double Price, string phoneVendorCode)
            : base(iD, model, memory, Color, Price)
        {
            PhoneVendorCode = phoneVendorCode;
        }

        public override string ToString()
        {
            return base.ToString() + " / Артикул: " + PhoneVendorCode;
        }
    }
}
