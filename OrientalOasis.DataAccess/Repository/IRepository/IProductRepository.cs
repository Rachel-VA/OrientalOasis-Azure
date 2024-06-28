using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientalOasis.Model;

namespace OrientalOasis.DataAccess.Repository.IRepository
{
	//create a public interface to impletement for the IRepo interface to get the base funcs from the IRepo
	public interface IProductRepository:IRepository<Product> //call Category from Model, must declare using directive
	{
		//impletement Update and save methods for the IRepo
		void Update(Product obj);
		
	}
}
