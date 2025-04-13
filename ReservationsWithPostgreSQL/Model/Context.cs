using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanTsvetkov11zh.Model
{
	internal class Context : DbContext
	{
		public DbSet<Flight> Flights { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

		public Context() { }
		public Context(DbContextOptions options) : base(options) { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseNpgsql(Configuration.connectionSting);
			}
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Flight>();
			modelBuilder.Entity<Reservation>(entity =>
			{
				entity.HasOne(e => e.Flight).WithMany(e => e.Reservations).OnDelete(DeleteBehavior.Restrict);
			});
		}
	}
}
