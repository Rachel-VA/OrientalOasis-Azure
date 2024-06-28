using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OrientalOasis.DataAcess.Repository.IRepository;
using Oriental_Oasis_Web.Data; // Ensure this using directive is correct
using Microsoft.EntityFrameworkCore; // Add this for EF Core

namespace OrientalOasis.DataAcess.Repository
{
	// Create a class Repo to implement the IRepo, inherit the class name
	public class Repository<T> : IRepository<T> where T : class
	{
		// Declare using dependency injection
		private readonly ApplicationDbContext _db;
		// Define DbSet from Entity Framework to allow modify the generic class T
		internal DbSet<T> dbSet;

		public Repository(ApplicationDbContext db)
		{
			_db = db;
			dbSet = _db.Set<T>();
			// _db.Categories == dbSet
		}

		public void Add(T entity)
		{
			// Now we can use the dbSet
			_db.Add(entity);
		}

		public void Delete(T entity)
		{
			dbSet.Remove(entity); // Allow remove item using built-in remove method
		}

		public void DeleteItems(IEnumerable<T> entity)
		{
			dbSet.RemoveRange(entity); // Using built-in RemoveRange method
		}

		public IEnumerable<T> GetAll()
		{
			IQueryable<T> query = dbSet;
			return query.ToList(); // Convert and return query to the list
		}

		public T GetFirstOrderDefault(Expression<Func<T, bool>> filter)
		{
			// Using IQueryable of T and assign to complete dbSet
			IQueryable<T> query = dbSet;
			query = query.Where(filter); // Apply the 'where' condition to use filter
										 // The Get method always need to return query
			return query.FirstOrDefault(); // From CategoryController
		}
	}
}
