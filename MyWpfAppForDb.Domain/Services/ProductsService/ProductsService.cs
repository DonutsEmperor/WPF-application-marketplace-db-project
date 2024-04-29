﻿using MyWpfAppForDb.EntityFramework.Entities;
using MyWpfAppForDb.EntityFramework.Services;
using MyWpfAppForDb.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyWpfAppForDb.Domain.Services.ProductsService
{
	public class ProductsService : IProductsService
	{
		private readonly AppDbContextFactory _contextFactory;
		private readonly NonQueryDataService<Product> _nonQueryDataService;

		public ProductsService(AppDbContextFactory contextFactory)
		{
			_contextFactory = contextFactory;
			_nonQueryDataService = new NonQueryDataService<Product>(contextFactory);
		}

		public async Task<Product> Create(Product entity)
		{
			return await _nonQueryDataService.Create(entity);
		}

		public async Task<bool> Delete(int id)
		{
			return await _nonQueryDataService.Delete(id);
		}

		public async Task<Product> Get(int id)
		{
			using (AppDbContext context = _contextFactory.CreateDbContext())
			{
				Product entity = await context.Products
					.Include(p => p.Market)
					.Include(p => p.ProductInstance)
						.ThenInclude(pi => pi.Category)
					.FirstOrDefaultAsync((p) => p.Id == id);
				return entity;
			}
		}

		public async Task<IEnumerable<Product>> GetAll()
		{
			using (AppDbContext context = _contextFactory.CreateDbContext())
			{
				IEnumerable<Product> entities = await context.Products
					.Include(p => p.Market)
					.Include(p => p.ProductInstance)
						.ThenInclude(pi => pi.Category).ToListAsync();
				return entities;
			}
		}

		public async Task<IEnumerable<Product>> GetProducts(int offset, int fetch)
		{
			using (AppDbContext context = _contextFactory.CreateDbContext())
			{
				IEnumerable<Product> entities = await context.Products
					.Include(p => p.Market)
					.Include(p => p.ProductInstance)
						.ThenInclude(pi => pi.Category)
					.Skip(offset)
					.Take(fetch)
				.ToListAsync();
					
				return entities;
			}
		}

		public async Task<Product> Update(int id, Product entity)
		{
			return await _nonQueryDataService.Update(id, entity);
		}
	}
}