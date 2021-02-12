using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _UserDal;
        public UserManager(IUserDal UserDal)
        {
            _UserDal = UserDal;
        }
        public IResult AddUser(User User)
        {
            if (User == null)
            {
                return new ErrorResult(Messages.UserIsEmpty);
            }
            else
            {
                _UserDal.Add(User);
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
                _UserDal.Delete(User);
            }
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAllUser()
        {
            return new SuccessDataResult<List<User>>(_UserDal.GetAll().ToList(), "Kullanıcılar Listelendi");
        }

        public IResult UpdateUser(User User)
        {
            if (User == null)
            {
                return new ErrorResult(Messages.UserIsEmpty);
            }
            else
            {
                _UserDal.Update(User);
            }
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
