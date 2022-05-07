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

        public DbSet<RoverEntity> Rovers { get; set; } = null!;
        public DbSet<MapSizeEntity> Maps { get; set; } = null!;

        
    }
}
