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
    [Export(typeof(IReleaseItemRepository))]
    public class ReleaseItemDataProvider : IReleaseItemRepository
    {
        public ReleaseItem GetReleaseItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReleaseItem> GetReleaseItems(int pageIndex, int pageCount)
        {
            throw new NotImplementedException();
        }

        public void AddReleaseItem(ReleaseItem releaseItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteReleaseItem(int releaseItemID)
        {
            throw new NotImplementedException();
        }

        public void UpdateReleaseItem(ReleaseItem releaseItem)
        {
            throw new NotImplementedException();
        }
    }
}
