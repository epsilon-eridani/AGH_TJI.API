using AGH_TJI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGH_TJI.API.Services
{
    public interface IPeopleInfoRepository
    {
        IEnumerable<People> GetPeople();
        People GetPerson(int id);
        void AddPerson(People contactToAdd);
    }
}
