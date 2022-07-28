using Application.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbConnection _connection;
        private readonly string _entityName;
        public Repository(IDbConnection connection, string entityName)
        {
            _connection = connection;
            _entityName = entityName;
        }

        public IEnumerable<TEntity> GetAll()
        {
            string sql = $"SELECT * FROM {_entityName}";

            var model = _connection.Query<TEntity>(sql);

            return model;
        }
    }
}
