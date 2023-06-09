﻿using Ecore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecore
{
    public interface ITenantDbContextFactory : IDbContextFactory<TenantDbContext>
    {
    }

    public class TenantDbContextFactory : ITenantDbContextFactory
    {
        private readonly DbContextOptions<TenantDbContext> _options;
        public TenantDbContextFactory(DbContextOptions<TenantDbContext> options)
        {
            _options = options;
        }
        public TenantDbContext CreateDbContext()
        {
            var db = new TenantDbContext(_options);
            return db;
        }
    }
}