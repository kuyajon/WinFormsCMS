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
        public List<Category> GetCategoriesByContentId(long id)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                string query = "select * from Category c where exists (select 1 from ContentCategory cc where cc.ContentId=@ContentId and cc.CategoryId = c.Id)";
                return connection.Query<Category>(query, new { ContentId = id }).ToList();
            }
        }

        public Category FindByName(string name)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                string query = "SELECT * FROM Category WHERE Name = @Name";
                return connection.QueryFirstOrDefault<Category>(query, new { Name = name });
            }
        }
    }
}
