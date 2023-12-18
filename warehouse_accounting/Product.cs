using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_accounting
{
    internal class Product
    {

        public string name;
        public string id;
        public string art;
        public int units;
        public string sum;
        public string path;

        public Product(string name, string id,string art, int units, string sum,string path)
        {
            this.name = name;
            this.id = id;
            this.art = art;
            this.units = units;
            this.sum = sum;
            this.path = path;
        }
    }
}
