using System;
using New_Online_Store.Enums;
using New_Online_Store.Notebook_Classes.Notebook_Interface;

namespace New_Online_Store.Notebook_Classes
{
    public abstract class Notebook : IComparable<Notebook>, INotebookType
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public DeviceColor Color { get; set; }
        public double Price { get; set; }

        public double ScreenSize { get; set; }
        public int RAM { get; set; }

        public Notebook()
        {
        }

        public Notebook(int iD, string model, int memory, DeviceColor color, double screenSize, int rAM, double price)
        {
            ID = iD;
            Model = model;
            Memory = memory;
            Color = color;
            ScreenSize = screenSize;
            Price = price;
            RAM = rAM;
        }

        public override string ToString()
        {
            return "ID " + ID + "  Модель ноутбука: " + Model +
                " / Память : " + Memory + " ГБ" +
                " / Цвет: " + Color +
                " / Размер экрана: " + ScreenSize + "\"" +
                " / Оперативная память: " + RAM + " ГБ" +
                " / Цена: " + Price + " BYN";
        }

        public int CompareTo(Notebook other)
        {
            return string.Compare(this.Price.ToString(), other.Price.ToString());
        }
    }
}
