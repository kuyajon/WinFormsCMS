using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Data;
using MySql.Data.MySqlClient; // Assuming you're using MySQL
using System.Configuration;

namespace WinFormsCMS
{
    public class BaseRepository<T> where T : class
    {
        public IEnumerable<T> GetAll()
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                return connection.GetAll<T>();
            }
        }

        public T GetById(int id)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                return connection.Get<T>(id);
            }
        }

        public void Insert(T entity)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                connection.Insert(entity);
            }
        }

        public void Update(T entity)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                connection.Update(entity);
            }
        }

        public void Delete(T entity)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                connection.Delete(entity);
            }
        }
    }
}
