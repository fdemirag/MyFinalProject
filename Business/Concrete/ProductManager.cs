
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class ProductManager : IProductService
        {
            IProductDal _productDal;
            public ProductManager(IProductDal productDal)
            {
                _productDal = productDal;
            }



            public List<Product> getAll()
            {
                //iş kodları 
                return _productDal.GetAll();

            }


        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}

