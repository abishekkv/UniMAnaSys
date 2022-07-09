using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmsWeb.Models;

namespace UmsWeb.DataAccess.Repository.IRepository
{
    public interface IFacultyRepository : IRepository<Faculty>
    {
        public void Update(Faculty faculty);
    }
}
