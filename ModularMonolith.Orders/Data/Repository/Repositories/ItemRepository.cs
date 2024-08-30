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
    internal sealed class ItemRepository : IRepository<Item>
    {
        public void Add(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Item entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Item> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Item?> GetById(Expression<Func<Item, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
