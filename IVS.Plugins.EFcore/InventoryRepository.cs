using IVS.CoreBusiness;
using IVS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IVS.Plugins.EFcore
{
	public class InventoryRepository : IInventoryRepository

	{
		private readonly IVSContext db;

		public InventoryRepository(IVSContext db) 
		{
			this.db = db;
		}
		public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name="")
		{
			return await this.db.Inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
								  string.IsNullOrWhiteSpace(name)).ToListAsync();
			
		}
	}
}