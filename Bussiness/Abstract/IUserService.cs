using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IUserService
    {
        IResult AddUser(User User);
        IResult DeleteUser(User User);
        IResult UpdateUser(User User);
        IDataResult<List<User>> GetAllUser();
    }
}
