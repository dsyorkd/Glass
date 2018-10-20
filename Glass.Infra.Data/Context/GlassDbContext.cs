using System;
using Glass.Domain.Models;
using Glass.Infra.Data.Mappings;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GlassApi.Infra.Data.Context
{
    public class GlassDbContext : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SensorMap());
        }



        public GlassDbContext(DbContextOptions<GlassDbContext> options) : base(options) { }

    }
}
