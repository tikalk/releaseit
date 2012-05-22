using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using ReleaseIt.Repository.Contracts;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Web.Client.Controllers.API
{
    public class ReleaseItemController : ApiController
    {
        private IReleaseItemRepository _repository;

        //[ImportingConstructor]
        public ReleaseItemController()
        {
            _repository = ReleaseIt.Composition.MefContainer.Container.GetExportedValue<IReleaseItemRepository>();
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
        public void Post(string value)
        {
            //return _repository.UpdateReleaseItem(id);
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
