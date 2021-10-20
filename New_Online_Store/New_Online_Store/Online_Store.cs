using System;
using System.Collections;
using System.Collections.Generic;
using New_Online_Store.Interface;

namespace New_Online_Store
{
    public class Online_Store : IElectronicsServise, IDisplay
    {
        public string Name { get; set; }
        public string TimeWorking { get; set; }
        public string PhoneNumber { get; set; }
        public AddressStore Address { get; set; }
        public List<IElectronicsGeneralView> ListOfItems { get; set; }

        public Online_Store()
        {
        }

        public Online_Store(string Name, string TimeWorking, string PhoneNumber,
            AddressStore Address, List<IElectronicsGeneralView> ListOfItems)
        {
            this.Name = Name;
            this.TimeWorking = TimeWorking;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.ListOfItems = ListOfItems;
        }

        public void Online_StoreDisplayInfo()
        {
            Console.WriteLine("Название магазина: " + Name +
                " / Режим работы: " + TimeWorking +
                " / Телефон: " + PhoneNumber);
        }

        public void AddressOnlineStoreDisplayInfo()
        {
            Console.WriteLine("Адрес магазина: " + "Страна: " +
                Address.Country + " / Город: " + Address.City + " / Улица: " +
                Address.Street + " / Почтовый адрес: " + Address.PostalCode);
        }

        public void DisplayinfoAllItemFromCollection(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public IElectronicsGeneralView GetNameByModel(string model)
        {
            IElectronicsGeneralView electronics = null;

            foreach (IElectronicsGeneralView item in ListOfItems)
            {
                if (item.Model == model)
                {
                    electronics = item;

                    break;
                }
            }
            return electronics;
        }

        public List<IElectronicsGeneralView> GetAllItems()
        {
            List<IElectronicsGeneralView> items = new List<IElectronicsGeneralView>();

            foreach(IElectronicsGeneralView item in ListOfItems)
            {
                items.Add(item);
            }
            return items;
        }

        public IElectronicsGeneralView GetItemById(int id)
        {
            IElectronicsGeneralView electronic = null;

            foreach(IElectronicsGeneralView item in ListOfItems)
            {
                if(item.ID == id)
                {
                    electronic = item;

                    break;
                }
            }
            return electronic;
        }
    }
}
