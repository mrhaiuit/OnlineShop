using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductModel
    {
        private OnlineShopDbContext context = null;
        public ProductModel()
        {
            context = new OnlineShopDbContext();
        }
    }
}
