using Bussiness.Abstract;
using Bussiness.Constands;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService,ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user,claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByEmail(userForLoginDto.Email);
            if (userToCheck==null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck.Data);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passWordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passWordSalt);
            var user = new User() {
                Email=userForRegisterDto.Email,
                FirstName=userForRegisterDto.FirstName,
                LastName=userForRegisterDto.LastName,
                PasswordHash=passwordHash,
                PasswordSalt=passWordSalt,
                Status=true
            };
            _userService.AddUser(user);
            return new SuccessDataResult<User>();
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByEmail(email)!=null)
            {
                return new ErrorResult(Messages.UserAlReadyExists);
            }
            return new SuccessResult();
        }
    }
}
