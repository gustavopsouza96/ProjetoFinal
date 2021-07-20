﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.v2.Models;

namespace SalesWebMvc.v2.Data
{
    public class SalesWebMvcv2Context : DbContext
    {
        public SalesWebMvcv2Context (DbContextOptions<SalesWebMvcv2Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
