using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    public class ContentRepository : BaseRepository<Content>
    {
        public List<Content> Search(ContentType type, ContentStatus status)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                return connection.Query<Content>("SELECT * FROM Content WHERE ContentType = @ContentType AND Status = @Status",
                    new { ContentType = type, Status = status }).ToList();
            }
        }

    }
}
