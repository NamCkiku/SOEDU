using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using SOEDU.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Service
{
    public interface IUserService
    {
        Sys_Users Add(Sys_Users course);
        void Update(Sys_Users course);
        Sys_Users Delete(int id);
        IEnumerable<Sys_Users> GetAll();
        IEnumerable<Sys_Users> GetAll(string keyword);
        Sys_Users GetByID(int id);
        Sys_Users ValidateUser(string username, string password);
        void SaveChanges();
    }
    public class UserService : IUserService
    {
        private IUsersRepository _userRepository;
        private IUnitOfWork _IUnitOfWork;
        public UserService(IUsersRepository userRepository, IUnitOfWork IUnitOfWork)
        {
            this._userRepository = userRepository;
            this._IUnitOfWork = IUnitOfWork;
        }
        public Sys_Users Add(Sys_Users course)
        {
            return _userRepository.Add(course);
        }

        public Sys_Users Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public IEnumerable<Sys_Users> GetAll()
        {
            return _userRepository.GetAll();
        }

        public IEnumerable<Sys_Users> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _userRepository.GetMulti(x => x.User_Name.Contains(keyword));
            else
                return _userRepository.GetAll();
        }

        public Sys_Users GetByID(int id)
        {
            return _userRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _IUnitOfWork.Commit();
        }

        public void Update(Sys_Users course)
        {
            _userRepository.Update(course);
        }

        public Sys_Users ValidateUser(string username, string password)
        {
            var user = _userRepository.GetSingleByUsername(username);
            return user;
            //if (user != null && isUserValid(user, password))
            //{
            //    var userRoles = GetUserRoles(user.Username);
            //    membershipCtx.User = user;

            //    var identity = new GenericIdentity(user.Username);
            //    membershipCtx.Principal = new GenericPrincipal(
            //        identity,
            //        userRoles.Select(x => x.Name).ToArray());
            //}
        }
        //private bool isPasswordValid(Sys_Users user, string password)
        //{
        //    return string.Equals(Common.Encryption.EncryptPassword(password,user.IsPassword), user.IsSex);
        //}
        //private bool isUserValid(Sys_Users user, string password)
        //{
        //    if (isPasswordValid(user, password))
        //    {
        //        return !user.IsLocked;
        //    }

        //    return false;
        //}
    }
}
