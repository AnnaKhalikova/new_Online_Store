using System;
using System.Collections;
using New_Online_Store.Interface;

namespace New_Online_Store
{
    public class Buyer : IDisplay
    {
        public string BuyerName { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public bool СardCurrency { get; set; }
        public BuyerСart Сart { get; set; }

        public Buyer()
        {
        }

        public Buyer(string BuyerName, string BuyerPhoneNumber, bool СardCurrency, BuyerСart Сart)
        {
            this.BuyerName = BuyerName;
            this.BuyerPhoneNumber = BuyerPhoneNumber;
            this.СardCurrency = СardCurrency;
            this.Сart = Сart;
        }

        public void BuyerDisplayInfo()
        {
            Console.WriteLine($"Имя покупателя: {BuyerName} \nНомер телефона: {BuyerPhoneNumber}");
        }

        public void DisplayinfoAllItemFromCollection(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
