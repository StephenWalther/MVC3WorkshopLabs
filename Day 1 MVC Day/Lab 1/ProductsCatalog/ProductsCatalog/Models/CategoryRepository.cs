using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ProductsCatalog.Models
{ 
    public class CategoryRepository : ICategoriesRepository
    {
        ProductCatalogContext context = new ProductCatalogContext();

        public IQueryable<Category> All
        {
			get { return context.Categories; }
        }

        public IQueryable<Category> AllIncluding(params Expression<Func<Category, object>>[] includeProperties)
        {
            IQueryable<Category> query = context.Categories;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Category Find(int id)
        {
            return context.Categories.Find(id);
        }

        public void InsertOrUpdate(Category categories)
        {
            if (categories.CategoryId == default(int)) {
                // New entity
                context.Categories.Add(categories);
            } else {
                // Existing entity
                context.Categories.Attach(categories);
                context.Entry(categories).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var categories = context.Categories.Find(id);
            context.Categories.Remove(categories);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

	public interface ICategoriesRepository
    {
		IQueryable<Category> All { get; }
		IQueryable<Category> AllIncluding(params Expression<Func<Category, object>>[] includeProperties);
		Category Find(int id);
		void InsertOrUpdate(Category categories);
        void Delete(int id);
        void Save();
    }
}