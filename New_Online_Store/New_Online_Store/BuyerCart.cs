using System;
using System.Collections.Generic;
using New_Online_Store.Interface;

namespace New_Online_Store
{
    public class BuyerСart
    {
        public List<IElectronicsGeneralView> buyerСart;

        public BuyerСart()
        {
        }

        public BuyerСart(List<IElectronicsGeneralView> _buyerCart)
        {
            buyerСart = _buyerCart;
        }

        public void BuyerCartDisplayInfo()
        {
            Console.WriteLine("Корзина покупателя: " + buyerСart);//buyerCart collection doesn't display correctly, to dispay items in collection try to use foreach or smth. else for iteration
        }
    }
}
