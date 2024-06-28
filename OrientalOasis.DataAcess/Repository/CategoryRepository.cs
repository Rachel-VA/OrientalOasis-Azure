using Oriental_Oasis_Web.Data;
using Oriental_Oasis_Web.Models;
using OrientalOasis.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.DataAcess.Repository
{
	//create a public class to empletement ICategoryRepo
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		//declare using independency injection
		private readonly ApplicationDbContext _db;
		//constructor
		public CategoryRepository(ApplicationDbContext db):base(db)
		{
			_db = db;
		}
		
		public void Save()
		{
			_db.SaveChanges();
		
		}
		public void Update(Category obj)
		{
			 
			_db.Categories.Update(obj);
		
		}

		
	}
}
