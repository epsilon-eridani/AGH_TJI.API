using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGH_TJI.API.Models;

namespace AGH_TJI.API.Services
{
    public class PeopleRepository : IPeopleInfoRepository
    {
        private AGH_DemoContext _context;

        public PeopleRepository(AGH_DemoContext context)
        {
            _context = context;
        }

        public void AddPerson(People contactToAdd)
        {
            _context.People.Add(contactToAdd);
            _context.SaveChanges();
        }

        public IEnumerable<People> GetPeople()
        {
            return _context.People.OrderBy(a => a.PersonId).ToList();
        }

        public People GetPerson(int id)
        {
            return _context.People.Where(a => a.PersonId == id).FirstOrDefault();
        }
    }
}
