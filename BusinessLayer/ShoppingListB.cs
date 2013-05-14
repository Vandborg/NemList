using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ShoppingListB : IFShoppingListB
    {

        public ShoppingListB()
        {
        }

        public void createShoppingList(string shoppingListName, long completionDate, int userId)
        {
            TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970,1,1,0,0,0);

            ShoppingList shoppingList = new ShoppingList(shoppingListName, (long)timeSpan.TotalSeconds, completionDate);
            

        }
    }

}
