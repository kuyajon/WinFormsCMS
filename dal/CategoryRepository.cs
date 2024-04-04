using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public List<Category> GetCategoriesByContentType(ContentType contentType)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                string query = "SELECT * FROM Category WHERE ContentType = @ContentType";
                return connection.Query<Category>(query, new { ContentType = contentType }).ToList();
            }
        }
    }
}
