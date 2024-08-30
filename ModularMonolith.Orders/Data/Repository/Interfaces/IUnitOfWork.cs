﻿using ModularMonolith.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Data.Repository.Interfaces
{
    internal interface IUnitOfWork : IDisposable
    {
        IOrderRepository OrderRepository { get; }
        IRepository<Item> ItemRepository { get; }

        Task Commit();
    }
}
