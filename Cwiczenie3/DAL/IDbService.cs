using Cwiczenie3.Models;
using System.Collections.Generic;
namespace Cwiczenie3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
