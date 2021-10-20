using New_Online_Store.Enums;
using New_Online_Store.Tablet_Interface;

namespace New_Online_Store.Tablet_Classes
{
    public class IPad_Pro_12_9 : Tablet, ITabletTypeFeatures
    {
        public string TabletVendorCode { get; set; }
        public bool WiFi { get; set; }

        public string LTE { get; set; }

        public IPad_Pro_12_9()
        {
        }

        public IPad_Pro_12_9(int iD, string model, int memory, DeviceColor color,
            double displaySize, double price, string tabletVendorCode, bool wiFi, string lTE) :
            base(iD, model, memory, color, displaySize, price)
        {
            TabletVendorCode = tabletVendorCode;
            WiFi = wiFi;
            LTE = lTE;
        }

        public override string ToString()
        {
            return base.ToString() + " / Артикул: " + TabletVendorCode + " / Wi-Fi: " + true + " / " + LTE;
        }
    }
}
