using CsvHelper;
using Models;
using System.IO;
using System.Linq;

namespace Repository.Csv
{
    public class BookRepository : GenericRepository<Books>, IBookRepository
    {
        public BookRepository(string filePath) : base (filePath)
        {

        }

        public override Books GetById(int id)
        {
            using (TextReader fileReader = File.OpenText(_filePath))
            {
                var csv = new CsvReader(fileReader);
                return csv.GetRecords<Books>().ToList().Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public bool IsActive(int bookId)
        {
            throw new System.NotImplementedException();
        }
    }
}
