using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLayer
{
    public class ProductList
    {
        //Values
        public string listName { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime completionDate { get; set; }

        //Lists
        public List<User> users { get; set; }
        public List<Product> products { get; set; }


        public ProductList()
        {

        }
    }
}
