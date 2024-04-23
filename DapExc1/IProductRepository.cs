using System;
namespace DapExc1
{
	public interface IProductRepository
	{
		public IEnumerable<Product> GetAllProducts();

		void CreateProduct(string name, double price, int categoryID);
	}
}

