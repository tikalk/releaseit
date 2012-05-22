using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using ReleaseIt.Composition;
using ReleaseIt.Repository.Contracts;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Web.Client.Controllers.API
{
    public class UsersController : ApiController
    {
        private IUsersRepository _repository;

        public UsersController()
        {
            _repository = MefContainer.Container.GetExportedValue<IUsersRepository>();
        }

        // GET /api/users
        public IEnumerable<User> Get()
        {
            return _repository.GetUsers(0, 1);
        }

        // GET /api/users/5
        public User Get(int id)
        {
            return _repository.GetUser(id);
        }

        // POST /api/users
        public void Post(User item)
        {
            _repository.UpdateUser(item);
        }

        // PUT /api/users/5
        public void Put(User item)
        {
            _repository.AddUser(item);
        }

        // DELETE /api/users/5
        public void Delete(int id)
        {
            _repository.DeleteUser(id);
        }
    }
}
