﻿using ECommerce.Persistence.Context;
using EcommerceAPI.Domain.Entities;
using ECommerceAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceApiDbContext context) : base(context)
        {

        }
    }
}
