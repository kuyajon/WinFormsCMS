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
    public class ComponentRepository : BaseRepository<Component>
    {
        public Component GetComponentByComponentKey(string componentKey)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                return connection.QueryFirstOrDefault<Component>("SELECT * FROM Component WHERE ComponentKey = @ComponentKey", new { ComponentKey = componentKey });
            }
        }
    }
}
