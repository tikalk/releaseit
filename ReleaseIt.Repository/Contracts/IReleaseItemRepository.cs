using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Repository.Contracts
{
    public interface IReleaseItemRepository
    {
        ReleaseItem GetReleaseItem(int id);

        IEnumerable<ReleaseItem> GetReleaseItems(int pageIndex, int pageCount);

        void AddReleaseItem(ReleaseItem releaseItem);

        void DeleteReleaseItem(int releaseItemID);

        void UpdateReleaseItem(ReleaseItem releaseItem);
    }
}
