using Identity.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Services
{
    interface IPerson
    {
        public void AddOrder(Person person, Order order);

        public Task<Person> GetPerson(string userName);
    }
}
