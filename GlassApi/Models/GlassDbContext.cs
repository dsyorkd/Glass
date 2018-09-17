using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GlassApi.Models {
    public class GlassDbContext : DbContext {
        public DbSet<Sensor> Sensors { get; set; }

        public GlassDbContext (DbContextOptions<GlassDbContext> options) : base (options) { }

    }
}
