using CsvHelper;
using Models;
using System.IO;
using System.Linq;

namespace Repository.Csv
{
    public class EnrolleeRepository : GenericRepository<Enrollees>, IEnrolleeRepository
    {
        public EnrolleeRepository(string filePath) : base (filePath)
        {

        }

        public override Enrollees GetById(int id)
        {
            using (TextReader fileReader = File.OpenText(_filePath))
            {
                var csv = new CsvReader(fileReader);
                return csv.GetRecords<Enrollees>().ToList().Where(x => x.Id == id).FirstOrDefault();
            }
        }

        #region Not Implemented
        public bool IsActive(int enrolleeId)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
