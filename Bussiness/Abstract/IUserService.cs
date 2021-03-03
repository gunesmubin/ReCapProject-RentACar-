using Core.Entities.Concrete;
using Core.Utilities.Results;
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
        IDataResult<User> GetUserById(int id);
        IDataResult<User> GetByEmail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}
