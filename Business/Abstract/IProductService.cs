﻿ using System;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<List<Product>> getAll();
		IDataResult<List<Product>> GetAllByCategoryId(int id);
		IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
		IDataResult<List<ProductDetailDto>> GetProductDetails();
		IDataResult<Product> GetById(int ProductId);
        IResult Add(Product product);
        IResult Update(Product product);




    }
}

