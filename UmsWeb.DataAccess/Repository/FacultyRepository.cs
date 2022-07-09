using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmsWeb.DataAccess.Repository.IRepository;
using UmsWeb.Models;

namespace UmsWeb.DataAccess.Repository
{
    public class FacultyRepository : Repository<Faculty>,IFacultyRepository
    {
        private readonly ApplicationDbContext _db;
        public FacultyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Models.Faculty faculty)
        {
            _db.Faculty.Update(faculty);
        }
    }
}
