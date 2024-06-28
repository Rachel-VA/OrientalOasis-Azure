using OrientalOasis.DataAccess.Data;
using OrientalOasis.DataAccess.Repository.IRepository;
using OrientalOasis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.DataAccess.Repository.IRepository
{
	//create a public class to impletement the ICategoryRepo and use its base funcs
	public class ProductRepository:Repository<Product>, IProductRepository
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}


		public void Update(Product obj)
		{
			var objFromDb = _db.Products.FirstOrDefault(u=>u.ProductId==obj.ProductId);
			if (objFromDb != null)
			{
				//update
				objFromDb.ItemName = obj.ItemName;
				objFromDb.ItemNumber = obj.ItemNumber;
				objFromDb.Price = obj.Price;
				objFromDb.Price50 = obj.Price50;
				objFromDb.ListPrice = obj.ListPrice;
				objFromDb.Price100 = obj.Price100;
				objFromDb.Description = obj.Description;
				objFromDb.Cat_Id  = obj.Cat_Id;
				objFromDb.Origin = obj.Origin;

				if (obj.ImageURL != null)
				{
					objFromDb.ImageURL = obj.ImageURL;
				}
			}
		}
	}
}
