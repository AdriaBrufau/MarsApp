using MarsApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarsApp
{
    public class MarsAppDbContext : DbContext
    {
        public MarsAppDbContext(DbContextOptions<MarsAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<RoverEntity> Rover { get; set; }
        public DbSet<CompassEnum> Command { get; set; }
        public DbSet<MapSizeEntity> MapSize { get; set; }


        protected override void OnModelCreating(ModelBuilder model)
        {
            
        }
    }
}
