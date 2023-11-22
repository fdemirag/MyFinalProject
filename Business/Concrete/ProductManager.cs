﻿
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class ProductManager : IProductService
        {
            IProductDal _productDal;
            public ProductManager(IProductDal productDal)
            {
                _productDal = productDal;
            }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürünün ismi en az 2 karakter olmalıdır.");
            }

            _productDal.Add(product);
            return new Result(true,"Ürün eklendi");
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

        public Product GetById(int ProductId)
        {
            return _productDal.get(p => p.ProductId == ProductId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}

