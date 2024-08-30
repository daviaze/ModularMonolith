using ModularMonolith.Orders.Data.Repository.Interfaces;
using ModularMonolith.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Data.Repository.Repositories
{
    internal sealed class OrderRepository : IOrderRepository
    {
        void IRepository<Order>.Add(Order entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Order>.Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Order> IRepository<Order>.Get()
        {
            throw new NotImplementedException();
        }

        Task<Order?> IRepository<Order>.GetById(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Order>.Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
