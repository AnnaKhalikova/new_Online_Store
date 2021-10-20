﻿using New_Online_Store.Enums;
using New_Online_Store.Notebook_Classes.Notebook_Interface;

namespace New_Online_Store.Notebook_Classes
{
    public class MacBook_Air : Notebook, INotebookTypeFeatures
    {
        public string NotebookVendorCode { get; set; }
        public string CPU { get; set; }

        public MacBook_Air()
        {
        }

        public MacBook_Air(int iD, string model, int memory, DeviceColor color, double screenSize, int rAM, double price, string notebookVendorCode, string cPU) :
            base(iD, model, memory, color, screenSize, rAM, price)
        {
            NotebookVendorCode = notebookVendorCode;
            CPU = cPU;
        }

        public override string ToString()
        {
            return base.ToString() + " / Артикул: " + NotebookVendorCode + " / Процессор: " + CPU;
        }
    }
}
