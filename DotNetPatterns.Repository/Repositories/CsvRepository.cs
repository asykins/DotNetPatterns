using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Repository.Repositories
{
    public abstract class CsvRepository<T> : IRepository<T>
    {
        public async Task<IEnumerable<T>> GetAll()
        {
            var queryResults = new List<T>();

            var lines = await File.ReadAllLinesAsync("somePath", Encoding.UTF8);
            var semiColonSeparatedLines = lines.Skip(1)
                                               .Select(x => x.Split(";"));

            semiColonSeparatedLines.ToList().ForEach(splittedLine => {
                queryResults.Add(Map(splittedLine));
            });

            return queryResults;
        }

        public async Task<T> GetById(Guid id)
        {
            return Map((await File.ReadAllLinesAsync("somePath", Encoding.UTF8))
                                  .Skip(1)
                                  .Select(x => x.Split(";"))
                                  .First(x => x[0] == id.ToString()));
        }

        public abstract T Map(string[] splittedLine);
    }
}
