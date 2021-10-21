using System;
using System.Collections.Generic;
using New_Online_Store.Enums;
using New_Online_Store.Interface;
using New_Online_Store.Notebook_Classes;
using New_Online_Store.Phone_Classes;
using New_Online_Store.Tablet_Classes;

namespace New_Online_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phones
            IPhone_XR iPhone_XR_MH6M3RM = new IPhone_XR(1, "iPhone XR", 64, DeviceColor.Black, 1899.0, "MH6M3RM/A");
            IPhone_XR iPhone_XR_MH6N3RM = new IPhone_XR(2, "iPhone XR", 64, DeviceColor.White, 1899.0, "MH6N3RM/A");
            IPhone_XR iPhone_XR_MH7L3RM = new IPhone_XR(3, "iPhone XR", 128, DeviceColor.Gold, 2099.0, "MH7L3RM/A");

            IPhone_11 iPhone_11_MH7L3RN = new IPhone_11(4, "iPhone 11", 64, DeviceColor.Green, 1999.0, "MH7L3RN/A");
            IPhone_11 iPhone_11_MR7L3RN = new IPhone_11(5, "iPhone 11", 64, DeviceColor.Red, 1999.0, "MR7L3RN/A");
            IPhone_11 iPhone_11_MR7L3SN = new IPhone_11(6, "iPhone 11", 128, DeviceColor.Blue, 2199.0, "MR7L3SN/A");
            IPhone_11 iPhone_11_MD7L3SN = new IPhone_11(7, "iPhone 11", 128, DeviceColor.PinckGold, 2199.0, "MD7L3SN/A");

            IPhone_SE iPhone_SE_MHGQ3RM = new IPhone_SE(8, "iPhone SE", 64, DeviceColor.Purple, 1299.0, "MHGQ3RM/A");
            IPhone_SE iPhone_SE_MRGQ3RN = new IPhone_SE(9, "iPhone SE", 128, DeviceColor.SpaceGray, 1499.0, "MRGQ3RN/A");
            IPhone_SE iPhone_SE_MNGQ3RN = new IPhone_SE(10, "iPhone SE", 256, DeviceColor.Black, 2099.0, "MNGQ3RN/A");

            IPhone_12_mini iPhone_12_mini_MGDY3RM = new IPhone_12_mini(11, "iPhone 12 mini", 64, DeviceColor.Green, 2299.0, "MGDY3RM/A");
            IPhone_12_mini iPhone_12_mini_MRDY3RM = new IPhone_12_mini(12, "iPhone 12 mini", 128, DeviceColor.White, 2499.0, "MRDY3RM/A");
            IPhone_12_mini iPhone_12_mini_MSDY3RM = new IPhone_12_mini(13, "iPhone 12 mini", 256, DeviceColor.Gold, 3199.0, "MSDY3RM/A");

            IPhone_12_Pro_Max iPhone_12_Pro_Max_MGD93RM = new IPhone_12_Pro_Max(14, "iPhone 12 ProMax", 128, DeviceColor.White, 4199.0, "MGD93RM/A");

            IPhone_12_Pro iPhone_12_Pro_MGMK3RM = new IPhone_12_Pro(15, "iPhone 12 Pro", 128, DeviceColor.SpaceGray, 3799.0, "MGMK3RM/A");

            IPhone_12 iPhone_12_MGJE3RM = new IPhone_12(16, "iPhone 12", 128, DeviceColor.Blue, 2899.0, "MGJE3RM/A");

            // Tablets
            IPad_Air_4 iPad_Air_4_MYFM2RK = new IPad_Air_4(1, "iPad Air 4", 64, DeviceColor.Gold, 10.9, 2299.0, "MYFM2RK", true);
            IPad_Air_4 iPad_Air_4_MYjM2RK = new IPad_Air_4(2, "iPad Air 4", 256, DeviceColor.Green, 10.9, 2899.0, "MYjM2RK", true);

            IPad_10_2 iPad_10_2_MYMN2RK = new IPad_10_2(3, "iPad 10.2", 64, DeviceColor.Gold, 10.2, 2099.0, "MYMN2RK", true, true);
            IPad_10_2 iPad_10_2_MYNN2RK = new IPad_10_2(4, "iPad 10.2", 32, DeviceColor.SpaceGray, 10.2, 1729.0, "MYNN2RK", true, true);

            IPad_mini iPad_mini_MK7P3RK = new IPad_mini(5, "iPad mini", 64, DeviceColor.Gold, 6, 1899.0, "MYNN2RK", true);

            IPad_Pro_12_9 iPad_Pro_12_9_MXF82RK = new IPad_Pro_12_9(6, "iPad Pro 12.9", 512, DeviceColor.SpaceGray, 12.9, 5459.0, "MXF82RK", true, "5G");

            // Notebooks
            MacBook_Air macBook_Air_MGN63RU = new MacBook_Air(1, "MacBook Air 13", 256, DeviceColor.SpaceGray, 13.0, 8, 3799.0, "MYDA2RU/A", "M1");
            MacBook_Air macBook_Air_MGO63RU = new MacBook_Air(2, "MacBook Air 13", 256, DeviceColor.Silwer, 13.0, 16, 4499.0, "MGO63RU", "M1");
            MacBook_Air macBook_Air_MGP63RU = new MacBook_Air(3, "MacBook Air 13", 512, DeviceColor.SpaceGray, 13.0, 8, 4299.0, "MGP63RU", "M1");

            MacBookPro macBookPro_MYDA2RU = new MacBookPro(4, "MacBook Pro 13", 256, DeviceColor.SpaceGray, 13.0, 8, 4799.0, "MGN63RU", "M1");
            MacBookPro macBookPro_MYD92RU = new MacBookPro(5, "MacBook Pro 13", 512, DeviceColor.Silwer, 13.0, 8, 5499.0, "MYD92RU/A", "M1");
            MacBookPro macBookPro_MVVJ2RU = new MacBookPro(6, "MacBook Pro 16", 512, DeviceColor.SpaceGray, 16.0, 16, 8759.0, "MVVJ2RU/A", "M1");
            MacBookPro macBookPro_MWP72RU = new MacBookPro(7, "MacBook Pro 13", 512, DeviceColor.Silwer, 13.0, 16, 6599.0, "MWP72RU/A", "Intel Core i5");

            List<IElectronicsGeneralView> items = new List<IElectronicsGeneralView>();

            // Added phones
            items.Add(iPhone_XR_MH6M3RM);
            items.Add(iPhone_XR_MH6N3RM);
            items.Add(iPhone_XR_MH7L3RM);

            items.Add(iPhone_11_MH7L3RN);
            items.Add(iPhone_11_MR7L3RN);
            items.Add(iPhone_11_MR7L3SN);
            items.Add(iPhone_11_MD7L3SN);

            items.Add(iPhone_SE_MHGQ3RM);
            items.Add(iPhone_SE_MRGQ3RN);
            items.Add(iPhone_SE_MNGQ3RN);

            items.Add(iPhone_12_mini_MGDY3RM);
            items.Add(iPhone_12_mini_MRDY3RM);
            items.Add(iPhone_12_mini_MSDY3RM);

            items.Add(iPhone_12_Pro_Max_MGD93RM);

            items.Add(iPhone_12_Pro_MGMK3RM);

            items.Add(iPhone_12_MGJE3RM);

            // Added tablets
            items.Add(iPad_Air_4_MYFM2RK);
            items.Add(iPad_Air_4_MYjM2RK);

            items.Add(iPad_10_2_MYMN2RK);
            items.Add(iPad_10_2_MYNN2RK);

            items.Add(iPad_mini_MK7P3RK);

            items.Add(iPad_Pro_12_9_MXF82RK);

            // Added notebooks
            items.Add(macBook_Air_MGN63RU);
            items.Add(macBook_Air_MGO63RU);
            items.Add(macBook_Air_MGP63RU);

            items.Add(macBookPro_MYDA2RU);
            items.Add(macBookPro_MYD92RU);
            items.Add(macBookPro_MVVJ2RU);
            items.Add(macBookPro_MWP72RU);

            items.Sort(); // Sort items by price from Min to Max
            //items.Reverse(); // Sort items by price from Max to Min

            Online_Store store = new Online_Store("Mobi-Store", "Пн.- Сб с 9-00 до 21:00", "+375 (44) 0000000",
                new AddressStore("Беларусь", "Минск", "пр-т Партизанский 109Б", "220019"), items);
            store.Online_StoreDisplayInfo();
            Console.WriteLine(new String('-', 174));

            store.AddressOnlineStoreDisplayInfo();
            Console.WriteLine(new String('-', 174));

            Console.WriteLine("Список доступных товаров: \n");
            store.DisplayinfoAllItemFromCollection(items);
            Console.WriteLine(new String('-', 174));

            // Buyer / (add items the buyer cart)
            List<IElectronicsGeneralView> buyerСart = new List<IElectronicsGeneralView>();

            buyerСart.Add(iPhone_12_Pro_Max_MGD93RM);
            buyerСart.Add(iPhone_SE_MNGQ3RN);
            buyerСart.Add(iPad_mini_MK7P3RK);
            buyerСart.Add(macBookPro_MVVJ2RU);

            //buyerСart.Clear(); // Удалить все товары из корзины
            //buyerСart.Remove(iPhone_12_Pro_Max_MGD93RM); // Удаление с карзины определенного товара

            Buyer buyer = new Buyer("Ruslan", "+375 (33) 3500000", true, new BuyerСart(buyerСart));

            buyer.BuyerDisplayInfo();
            Console.WriteLine(new String('-', 34));

            Console.WriteLine("Корзина: \n");
            buyer.DisplayinfoAllItemFromCollection(buyerСart);

            // Service / The total cost of all items in the buyer cart
            ElectronicsService electronicsService = new ElectronicsService(new BuyerСart(buyerСart));

            electronicsService.GetSumAllItemFromCollection(buyerСart);

            if (buyerСart.Count == 0)
            {
                Console.WriteLine($"\tВаша корзина пуста!!!");
            }
            else
            {
                Console.WriteLine($"\nИтоговая стоимость за {buyerСart.Count} товар(а)" +
                $" состовляет: " + electronicsService.GetSumAllItemFromCollection(buyerСart) + " BYN");
            }
        }
    }
}
