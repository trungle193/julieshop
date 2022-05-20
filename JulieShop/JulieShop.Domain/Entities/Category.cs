﻿using JulieShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieShop.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
    }
}
