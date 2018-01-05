using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;
using MVC_DAL;
using System.Linq.Expressions;

namespace MVC_BLL
{
    public class UserService : IUserService
    {
        IUserRepositery IUserRepositery;
        public UserService(IUserRepositery IUR)
        {
            IUserRepositery = IUR;
        }

        //For Account Controller
        public UserService()
        {
            if (IUserRepositery == null)
                IUserRepositery = new UserRepositery();
        }

       

    }
}
