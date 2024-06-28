using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Oriental_Oasis_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientalOasis.DataAcess.Repository.IRepository
{
	// Create a public interface to implement the IRepo interface, inheriting the IRepository class
	public interface ICategoryRepository : IRepository<Category>
	{
		// Method to update & save Category
		void Update(Category obj);
		void Save();
	}
}
