using System;

namespace demo.Models
{
    public class Products
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public decimal ProPrice { get; set; }
        public int PTID { get; set; }

        virtual public ProductType ProductType { get; set; }
    }
}
