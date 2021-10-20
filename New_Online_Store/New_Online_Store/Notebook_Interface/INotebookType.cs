using New_Online_Store.Enums;
using New_Online_Store.Interface;

namespace New_Online_Store.Notebook_Classes.Notebook_Interface
{
    public interface INotebookType : IElectronicsGeneralView
    {
        public new int ID { get; set; }
        public new string Model { get; set; }
        public new int Memory { get; set; }
        public new DeviceColor Color { get; set; }
        public new double Price { get; set; }

        public double ScreenSize { get; set; }
        public int RAM { get; set; }
    }
}
