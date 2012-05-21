using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Repository.Contracts
{
    public interface IUsersRepository
    {
        User GetUser(int id);

        IEnumerable<User> GetUsers(int pageIndex, int pageCount);

        void AddUser(User user);

        void DeleteUser(int userID);

        void UpdateUser(User user);
    }
}
