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
            var context = new ReleaseItContext();
            return context.ReleaseItems.Where(r => r.ID == id).FirstOrDefault();
        }

        public IEnumerable<ReleaseItem> GetReleaseItems(int pageIndex, int pageCount)
        {
            var context = new ReleaseItContext();
            return context.ReleaseItems.ToArray();
        }

        public void AddReleaseItem(ReleaseItem releaseItem)
        {
            var context = new ReleaseItContext();
            context.ReleaseItems.Add(releaseItem);

            context.SaveChanges();
        }

        public void DeleteReleaseItem(int releaseItemID)
        {
            var context = new ReleaseItContext();
            //return context.ReleaseItems.Remove(releaseItemID

            context.SaveChanges();
        }

        public void UpdateReleaseItem(ReleaseItem releaseItem)
        {
            var context = new ReleaseItContext();
            //context.ReleaseItems.Where(r => r.ID == id).FirstOrDefault();

            context.SaveChanges();
        }
    }
}
