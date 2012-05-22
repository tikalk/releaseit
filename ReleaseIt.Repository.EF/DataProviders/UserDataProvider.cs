using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReleaseIt.Repository.Contracts;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Repository.EF.DataProviders
{
    [Export(typeof(IUsersRepository))]
    public class UserDataProvider : IUsersRepository
    {
        public User GetUser(int id)
        {
            var context = new ReleaseItContext();
            return context.Users.Where(r => r.ID == id).FirstOrDefault();
        }

        public IEnumerable<Entities.User> GetUsers(int pageIndex, int pageCount)
        {
            var context = new ReleaseItContext();
            return context.Users.ToArray();
        }

        public void AddUser(Entities.User user)
        {
            var context = new ReleaseItContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void DeleteUser(int userID)
        {
            var context = new ReleaseItContext();
            var item = context.Users.Where(r => r.ID == userID).FirstOrDefault();
            context.Users.Remove(item);
            context.SaveChanges();
        }

        public void UpdateUser(Entities.User user)
        {
            var context = new ReleaseItContext();

            context.Users.Attach(user);
            context.ChangeTracker.DetectChanges();
            context.SaveChanges();
        }
    }
}
