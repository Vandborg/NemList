using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLayer
{
    public class ShoppingList
    {
        //Values
        public string shoppingListName { get; set; }
        public long creationDate { get; set; }
        public long completionDate { get; set; }

        //Lists
        public List<User> users { get; set; }
        //public List<Product> products { get; set; }


        public ShoppingList(string shoppingListName, long creationDate, long completionDate)
        {
            this.shoppingListName = shoppingListName;
            this.creationDate = creationDate;
            this.completionDate = completionDate;

            this.users = new List<User>();
        }
    }
}
