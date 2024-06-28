using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.DataAcess.Repository.IRepository
{
	// create a generic  public class T for Repo pattern to allow users to interact w/database
	public interface IRepository<T> where T : class
	{
		//T will be category/generic models to interact w/DbContext
		IEnumerable<T> GetAll(); //get all method
		T GetFirstOrderDefault(Expression<Func<T,bool>> filter); //get indivi method
		void Add(T entity); //func add item
		void Delete(T entity); //remove item
		void DeleteItems(IEnumerable<T> entity);
	}
}
