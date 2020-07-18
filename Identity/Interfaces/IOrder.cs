using Identity.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Services
{
    public interface IOrder
    {
        public void CreateOrder(Order order);
        
    }
}
