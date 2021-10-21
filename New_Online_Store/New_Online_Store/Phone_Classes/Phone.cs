﻿using New_Online_Store.Enums;
using New_Online_Store.Interface;
using New_Online_Store.Phones_Interface;

namespace New_Online_Store.Phone_Classes
{
    public abstract class Phone : IPhoneType
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public DeviceColor Color { get; set; }
        public double Price { get; set; }

        public Phone()
        {
        }

        public Phone(int iD, string model, int memory, DeviceColor color, double price)
        {
            ID = iD;
            Model = model;
            Memory = memory;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            return "ID " + ID + "  Модель телефона: " + Model +
                " / Память : " + Memory + " ГБ" +
                " / Цвет: " + Color +
                " / Цена: " + Price + " BYN";
        }

        public int CompareTo(IElectronicsGeneralView other)
        {
            return string.Compare(this.Price.ToString(), other.Price.ToString());
        }
    }
}
