using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.DataAccess.Repository.IRepository
{
	//create a public interface and a generic class

	public interface IRepository<T> where T : class 
	{
		//get all categories
		IEnumerable<T> GetAll(Expression<Func<T,bool>>? filter=null,string? includeProperties = null);

		//allow user to get specific category and interract with it
		T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
		
		void Add(T entiry);
		void Delete(T entiry);
		//void Update(T entiry);
		void DeleteRange(IEnumerable<T> entity);
	}
	
}
