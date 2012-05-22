using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using ReleaseIt.Composition;
using ReleaseIt.Repository.Contracts;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Web.Client.Controllers.API
{
    public class ReleaseItemController : ApiController
    {
        private IReleaseItemRepository _repository;

        public ReleaseItemController()
        {
            _repository = MefContainer.Container.GetExportedValue<IReleaseItemRepository>();
        }

        // GET /api/releaseitem
        public IEnumerable<ReleaseItem> Get()
        {
            return _repository.GetReleaseItems(0, 1);
        }

        // GET /api/releaseitem/5
        public ReleaseItem Get(int id)
        {
            return _repository.GetReleaseItem(id);
        }

        // POST /api/releaseitem
        public void Post(ReleaseItem item)
        {
            _repository.UpdateReleaseItem(item);
        }

        // PUT /api/releaseitem/5
        public void Put(ReleaseItem item)
        {
            _repository.AddReleaseItem(item);
        }

        // DELETE /api/releaseitem/5
        public void Delete(int id)
        {
            _repository.DeleteReleaseItem(id);
        }
    }
}
