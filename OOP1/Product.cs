using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //entity class'larında sadece özellik olur.
        //CRUD operasyonları burada yapılmaz.
        public int Id { get; set; }
        public int CatrogryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


    }
}
