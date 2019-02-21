using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel
    {
        private OnlineShopDbContext context = null;
        public CategoryModel()
        {
            context = new OnlineShopDbContext();
        }

        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("sp_Category_ListAll").ToList();
            return list;
        }

        public int Create(string Name, string Alias, int? Idx, int? ParentId, bool status)
        {
            object[] parammeters =
            {
                new SqlParameter("@Name", Name),
                 new SqlParameter("@Alias", Alias),
                 new SqlParameter("@Idx", (Idx??0)),
                 new SqlParameter("@ParentId", (ParentId??0)),
                 new SqlParameter("@Status", status)
            };

            var p1 = new SqlParameter("@Name", Name);
            var p2 = new SqlParameter("@Alias", Alias);
            var p3 = new SqlParameter("@Idx", (Idx ?? 0));
            var p4 = new SqlParameter("@ParentId", (ParentId ?? 0));
            var p5 = new SqlParameter("@Status", status);
            int res = context.Database.ExecuteSqlCommand("sp_Category_Insert @Name, @Alias, @Idx, @ParentId, @Status", p1, p2, p3, p4, p5);
            return res;
        }
    }
}
