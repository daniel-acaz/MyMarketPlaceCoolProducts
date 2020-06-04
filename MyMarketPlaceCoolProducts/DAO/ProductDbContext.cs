﻿using System;
using Microsoft.EntityFrameworkCore;
using MyMarketPlaceCoolProducts.Model;

namespace MyMarketPlaceCoolProducts.DAO
{
    public class ProductDbContext: DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
