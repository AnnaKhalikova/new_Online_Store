using New_Online_Store.Enums;
using New_Online_Store.Tablet_Interface;

namespace New_Online_Store.Tablet_Classes
{
    public class IPad_Air_4 : Tablet, ITabletTypeFeatures
    {
        public string TabletVendorCode { get; set; }
        public bool WiFi { get; set; }

        public IPad_Air_4()
        {
        }

        public IPad_Air_4(int iD, string model, int memory, DeviceColor color,
            double displaySize, double price, string tabletVendorCode, bool wiFi):
            base(iD, model, memory, color, displaySize, price)
        {
            TabletVendorCode = tabletVendorCode;
            WiFi = wiFi;
        }

        public override string ToString()
        {
            return base.ToString() + " / Артикул: " + TabletVendorCode + " / Wi-Fi: " + true;
        }
    }
}
