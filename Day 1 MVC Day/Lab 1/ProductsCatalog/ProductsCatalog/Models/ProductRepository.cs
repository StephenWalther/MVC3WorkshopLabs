using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ProductsCatalog.Models
{ 
    public class ProductRepository : IProductsRepository
    {
        ProductCatalogContext context = new ProductCatalogContext();

        public IQueryable<Product> All
        {
			get { return context.Products; }
        }

        public IQueryable<Product> AllIncluding(params Expression<Func<Product, object>>[] includeProperties)
        {
            IQueryable<Product> query = context.Products;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Product Find(int id)
        {
            return context.Products.Find(id);
        }

        public void InsertOrUpdate(Product products)
        {
            if (products.Id == default(int)) {
                // New entity
                context.Products.Add(products);
            } else {
                // Existing entity
                context.Products.Attach(products);
                context.Entry(products).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var products = context.Products.Find(id);
            context.Products.Remove(products);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

	public interface IProductsRepository
    {
		IQueryable<Product> All { get; }
		IQueryable<Product> AllIncluding(params Expression<Func<Product, object>>[] includeProperties);
		Product Find(int id);
		void InsertOrUpdate(Product products);
        void Delete(int id);
        void Save();
    }
}