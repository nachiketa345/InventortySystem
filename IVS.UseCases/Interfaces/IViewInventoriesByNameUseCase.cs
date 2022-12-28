using IVS.CoreBusiness;

namespace IVS.UseCases
{
	public interface IViewInventoriesByNameUseCase
	{
		Task<IEnumerable<Inventory>> ExecuteAsync(string name);
	}
}