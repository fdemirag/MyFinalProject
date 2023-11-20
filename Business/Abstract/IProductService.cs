﻿using System;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IProductService
	{
		List<Product> getAll();
		List<Product> GetAllByCategoryId(int id);
		List<Product> GetByUnitPrice(decimal min, decimal max);
		List<ProductDetailDto> GetProductDetails();

    }
}

