using New_Online_Store.Enums;
using New_Online_Store.Interface;
using New_Online_Store.Tablet_Interface;

namespace New_Online_Store.Tablet_Classes
{
    public abstract class Tablet : ITabletType
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public DeviceColor Color { get; set; }
        public double Price { get; set; }

        public double DisplaySize { get; set; }

        public Tablet()
        {
        }

        public Tablet(int iD, string model, int memory, DeviceColor color,
            double displaySize, double price)
        {
            ID = iD;
            Model = model;
            Memory = memory;
            Color = color;
            DisplaySize = displaySize;
            Price = price;
        }

        public override string ToString()
        {
            return "ID " + ID + "  Модель планшета: " + Model +
                " / Память : " + Memory + " ГБ" +
                " / Цвет: " + Color +
                " / Дисплей: " + DisplaySize + "\"" +
                " / Цена: " + Price + " BYN"; ;
        }

        public int CompareTo(IElectronicsGeneralView other)
        {
            return string.Compare(this.Price.ToString(), other.Price.ToString());
        }
    }
}
