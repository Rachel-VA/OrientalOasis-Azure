using OrientalOasis.DataAccess.Data;
using OrientalOasis.DataAccess.Repository.IRepository;
using OrientalOasis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.DataAccess.Repository
{
	//create a public class to impletement the ICategoryRepo and use its base funcs
	public class CategoryRepository:Repository<Category>, ICategoryRepository
	{
		private ApplicationDbContext _db;
		public CategoryRepository(ApplicationDbContext db) : base(db)

		{
			_db = db;
		}


		public void Update(Category obj)
		{
			_db.Categories.Update(obj);
		}
	}
}
