using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientalOasis.Model;

namespace OrientalOasis.DataAccess.Repository.IRepository
{
	//create a public interface to impletement for the IRepo interface to get the base funcs from the IRepo
	public interface IApplicationUserRepository:IRepository<ApplicationUser> //call Category from Model, must declare using directive
	{
		
		
	}
}
