using System;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IProductDal
	{
		List<Product> GetAll();
		void Add(Product product);
		void Delete(Product product);
		void Update(Product product);

	}
}

