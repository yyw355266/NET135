using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    public class ProductType
    {
        public int PTID { get; set; }
        public string PTName { get; set; }

        //外键导航属性
        virtual public ICollection<Products> Products { get; set; }
    }
}
