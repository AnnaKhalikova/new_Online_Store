using System;
using System.Collections;
using New_Online_Store.Enums;
using New_Online_Store.Interface;

namespace New_Online_Store
{
    public class ElectronicsService : IDisplay
    {
        public BuyerСart Сart { get; set; }
        public int ID { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public DeviceColor Color { get; set; }
        public double Price { get; set; }

        public ElectronicsService()
        {
        }

        public ElectronicsService(BuyerСart Сart)
        {
            this.Сart = Сart;
        }

        public void DisplayinfoAllItemFromCollection(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }

        // Total sum items
        public double GetSumAllItemFromCollection(ICollection collection)
        {
            double result = 0.0;

            foreach (IElectronicsGeneralView item in collection)
            {
                result += item.Price;
            }

            return result;
        }
    }
}
