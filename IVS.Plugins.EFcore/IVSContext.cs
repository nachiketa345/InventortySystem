using IVS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVS.Plugins.EFcore
{
	public class IVSContext : DbContext
	{
		public IVSContext(DbContextOptions options): base(options)
		{
				
		}
		public DbSet<Inventory> Inventories { get; set; }

		protected override void OnModelCreating (ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Inventory>().HasData(
				new Inventory { InventoryId = 1, InventoryName = "Engine", Quantity = 1, Price = 1500 },
				new Inventory { InventoryId = 2, InventoryName = "Body", Quantity = 3, Price = 4000 },
				new Inventory { InventoryId = 3, InventoryName = "Wheels", Quantity = 5, Price = 250 },
				new Inventory { InventoryId = 4, InventoryName = "Seats", Quantity = 30, Price = 450 }

				);
		}
	}
}
