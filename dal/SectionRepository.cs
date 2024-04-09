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
    public class SectionRepository : BaseRepository<Section>
    {
        public Section GetSectionByContentKey(string contentKey)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                // Execute the query using Dapper
                return connection.QueryFirstOrDefault<Section>("SELECT * FROM Section WHERE ContentKey = @ContentKey", new { ContentKey = contentKey });
            }
        }
    }
}
