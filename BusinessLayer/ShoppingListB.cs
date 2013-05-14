using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ShoppingListB
    {

        public ShoppingListB()
        {
        }

        public void createShoppingList(string listName, long completionDate, User user)
        {
            TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970,1,1,0,0,0);

            ShoppingList shoppingList = new ShoppingList(string listName, (long)timeSpan.TotalSeconds, completionDate);
        }
    }

}
