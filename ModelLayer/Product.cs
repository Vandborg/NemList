using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLayer
{
    class Product
    {
        //Values
        public string productName { get; set; }

        public Product(string productname)
        {
            this.productName = productName;
        }
    }
}
