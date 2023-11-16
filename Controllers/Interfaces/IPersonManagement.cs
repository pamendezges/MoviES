using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviES.Models.Person;

namespace MoviES.Interfaces
{
    public interface IPersonManagement
    {
        public void AddPerson(Person person) { }

        public void DeletePerson(Person person) { }

        public void ShowPersons() { }

    }
}
