using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DotNetPatterns.Repository.Repositories
{
    public abstract class SqlRepository<T> : IRepository<T>
    {
        public async Task<IEnumerable<T>> GetAll()
        {
            var queryResult = new List<T>();

            using (var connection = new SqlConnection("someConnectionString"))
            {
                using(var command = connection.CreateCommand())
                {
                    SetGetAllCommand(command);

                    await connection.OpenAsync();
                    var reader = await command.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        queryResult.Add(Map(reader));
                    }

                    return queryResult;
                }
            }
        }
        public async Task<T> GetById(Guid id)
        {
            using (var connection = new SqlConnection("someConnectionString"))
            {
                using (var command = connection.CreateCommand())
                {
                    SetGetByIdCommand(command, id);

                    await connection.OpenAsync();
                    var reader = await command.ExecuteReaderAsync();

                    reader.Read();

                    return Map(reader);
                }
            }
        }

        public abstract T Map(DbDataReader dbDataReader);
        public abstract void SetGetAllCommand(DbCommand command);
        public abstract void SetGetByIdCommand(DbCommand command, Guid id);
    }
}
