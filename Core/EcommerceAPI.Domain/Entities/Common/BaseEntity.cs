﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
