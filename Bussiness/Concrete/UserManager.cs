using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Concrete;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal UserDal)
        {
            _userDal = UserDal;
        }
        public IResult AddUser(User User)
        {
            if (User == null)
            {
                return new ErrorResult(Messages.UserIsEmpty);
            }
            else
            {
                _userDal.Add(User);
            }
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult DeleteUser(User User)
        {
            if (User == null)
            {
                return new ErrorResult(Messages.UserIsEmpty);
            }
            else
            {
                _userDal.Delete(User);
            }
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAllUser()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll().ToList(), "Kullanıcılar Listelendi");
        }

        public IDataResult<User> GetByEmail(string email)
        {
            var result = _userDal.Get(x => x.Email == email);
            return new SuccessDataResult<User>(result);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }
         

        public IDataResult<User> GetUserById(int id)
        {
            var result = _userDal.Get(x=>x.Id==id);
            return new SuccessDataResult<User>(result);
        }

        public IResult UpdateUser(User User)
        {
            if (User == null)
            {
                return new ErrorResult(Messages.UserIsEmpty);
            }
            else
            {
                _userDal.Update(User);
            }
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
