using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash.data
{
    class Order
    {

        public int r ;
        public int c ;
        public Product[] p;

        public Order(int r , int c , int l)
        {
            this.r = r;
            this.c = c;
            p = new Product[l]; 
        }
    }
}
