using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Data;
using MySql.Data.MySqlClient; // Assuming you're using MySQL
using System.Configuration;
using System.Reflection;

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

        public T GetById(long id)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                return connection.Get<T>(id);
            }
        }

        public T Insert(T entity)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                long id = connection.Insert(entity);
                return connection.Get<T>(id);
            }
        }

        public void Update(T entity)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                PropertyInfo updateDateProperty = entity.GetType().GetProperty("UpdatedDate");
                if (updateDateProperty != null && updateDateProperty.CanWrite)
                {
                    updateDateProperty.SetValue(entity, DateTime.Now, null);
                }
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
