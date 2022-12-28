using IVS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IVS.UseCases.PluginInterfaces
{
	public interface IInventoryRepository
	{
		Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
	}
}
