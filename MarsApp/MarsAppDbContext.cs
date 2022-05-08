using MarsApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarsApp
{
    public class MarsAppDbContext : DbContext
    {
        public MarsAppDbContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<RoverEntity> Rovers { get; set; }
        public DbSet<MapSizeEntity> Maps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RoverEntity>().Property(f => f.RoverID).ValueGeneratedOnAdd();

            modelBuilder.Entity<RoverEntity>().HasData(
                new RoverEntity { RoverID = 1, Compass = CompassEnum.Orientation.North, IsAlive = true, Order = "", Or_Grade= 0, X_Position = 0, Y_Position = 0 });
            modelBuilder.Entity<MapSizeEntity>().HasData(
                new MapSizeEntity { MapID = 1, X_Axis = 3, Y_Axis = 4 });
        }
    }
}
