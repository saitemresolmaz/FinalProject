using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //bir classın default hali internal'dır. internal sadece entities erişebilir demek.
    public class Product : IEntity
    //public yaptık diğer katmanlar bu class'a erişebilsin diye.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }

        public short UnitsInStock { get; set; } //short int'in küçüğü.

        public decimal UnitPrice { get; set; }  //decimal para birimi. 


    }
}
