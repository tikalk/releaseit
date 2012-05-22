using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;
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

        public void AddReleaseItem(ReleaseItem item)
        {
            item.CreateTime = DateTime.Now;
            item.UpdateTime = DateTime.Now;

            var context = new ReleaseItContext();
            context.ReleaseItems.Add(item);
            context.SaveChanges();
        }

        public void DeleteReleaseItem(int releaseItemID)
        {
            var context = new ReleaseItContext();
            var item = context.ReleaseItems.Where(r => r.ID == releaseItemID).FirstOrDefault();
            context.ReleaseItems.Remove(item);
            context.SaveChanges();
        }

        public void UpdateReleaseItem(ReleaseItem item)
        {
            var context = new ReleaseItContext();

            context.ReleaseItems.Attach(item);
            context.ChangeTracker.DetectChanges();
            context.SaveChanges();
        }
    }
}
