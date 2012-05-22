using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReleaseIt.Repository.Contracts;
using ReleaseIt.Repository.Entities;

namespace ReleaseIt.Repository.EF
{
    [Export(typeof(IReleaseItContext))]
    public class ReleaseItContext : DbContext, IReleaseItContext
    {
        public ReleaseItContext()
        {
            var seed = new ReleaseItContextInitializer();
            Database.SetInitializer(seed);
            seed.InitializeDatabase(this);
        }

        #region Properties

        public DbSet<ReleaseItem> ReleaseItems { get; set; }

        public DbSet<User> Users { get; set; }

        #endregion
    }

    public class ReleaseItContextInitializer :
             DropCreateDatabaseIfModelChanges<ReleaseItContext>
    {
        protected override void Seed(ReleaseItContext context)
        {
            var testUser = new User() { UserName = "TestUser" };
            context.Users.Add(new User() { UserName = "TestUser" });
            context.ReleaseItems.Add(
                new ReleaseItem()
                {
                    User = testUser,
                    Title = "test item 1",
                    Body = "test item body",
                    DomainType = ReleaseDomainTypes.DotNet,
                    ReleaseType = ReleaseTypes.BetaProduct,
                    Uri = "no uri "
                });
        }
    }

}
