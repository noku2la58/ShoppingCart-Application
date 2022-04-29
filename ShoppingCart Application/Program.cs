using System;
using System.Collections.Generic;
using shoppinglibrary;


namespace Shoppingcart
{
    internal class program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            var item = new ShoppingCartItem("bread", 20);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("rice", 30);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("Beans", 40);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("Mlik", 13);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("Banana", 29);
            cart.Addshoppingcartitem(item);

            List<ShoppingCartItem> shoppingCartItems = cart.ShoppingCartItems();

            foreach (ShoppingCartItem shoppingCartItem in shoppingCartItems)
            {
                Console.WriteLine(shoppingCartItem.Name + "\t\t\t" + shoppingCartItem.Price);
            }

            Console.WriteLine("subTotal" + "\t" + cart.GetsubTotal());
            Console.WriteLine("With Vat" + "\t" + cart.Getwithvattotal());
        }
    }

     
}
