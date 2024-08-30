using ModularMonolith.Orders.Data.Repository.Interfaces;
using ModularMonolith.Orders.Data.Repository.Repositories;
using ModularMonolith.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Data
{
    internal class UnitOfWork : IUnitOfWork
    {
        public IOrderRepository OrderRepository
        {
            get
            {
                return OrderRepo ??= new OrderRepository();
            }
        }

        public IRepository<Item> ItemRepository
        {
            get
            {
                return ItemRepo ??= new ItemRepository();
            }
        }

        private OrderRepository OrderRepo { get; set; }
        private ItemRepository ItemRepo { get; set; }

        public Task Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
