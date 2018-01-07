using System;
using DemoDbFirstAproach.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoDbFirstAproach.Models
{
    public partial class ActorDbContext : DbContext
    {
        public virtual DbSet<Actors> Actors { get; set; }

        public ActorDbContext(DbContextOptions<ActorDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public static implicit operator ActorDbContext(ActorController v)
        {
            throw new NotImplementedException();
        }
    }
}
