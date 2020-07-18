using Identity.Areas.Identity.Data;
using Identity.Data;
using Identity.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Identity.Classes
{
    public class PersonClass : IPerson
    {
        private readonly WAContext wAContext;

        public PersonClass(WAContext wAContext)
        {
            this.wAContext = wAContext;
        }

        public void AddOrder(Person person, Order order)
        {
            if (person.Orders == null)
            {
                person.Orders = new List<Order>();
            }
            Order order1 = new Order { Name = "au" };
            wAContext.Add<Order>(order1);
            person.Orders.Add(order1);
            wAContext.SaveChanges();

            
        }

        public async Task<Person> GetPerson(string userName)
        {
            return await wAContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }
    }
}
