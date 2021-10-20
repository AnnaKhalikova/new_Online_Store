using New_Online_Store.Enums;
using New_Online_Store.Tablet_Interface;

namespace New_Online_Store.Tablet_Classes
{
    public class IPad_10_2 : Tablet, ITabletTypeFeatures
    {
        public string TabletVendorCode { get; set; }
        public bool WiFi { get; set; }

        public bool LTE { get; set;}

        public IPad_10_2()
        {
        }

        public IPad_10_2(int iD, string model, int memory, DeviceColor color,
            double displaySize, double price, string tabletVendorCode, bool wiFi, bool lTE) :
            base(iD, model, memory, color, displaySize, price)
        {
            TabletVendorCode = tabletVendorCode;
            WiFi = wiFi;
            LTE = lTE;
        }

        public override string ToString()
        {
            return base.ToString() + " / Артикул: " + TabletVendorCode + " / Wi-Fi: " + true + " / 4G: " + true;
        }
    }
}
