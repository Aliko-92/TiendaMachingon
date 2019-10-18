using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaMachingon.Web.Data.Entities
{
    public class Shop
    {
        public int Customer { get; set; }

        public double Sale { get; set; }

        public int SaleDetail { get; set; }

        public int Product { get; set; }

        public int Provider { get; set; }

        public double Purchase { get; set; }

        public int PurchaseDetail { get; set; }
    }
}
