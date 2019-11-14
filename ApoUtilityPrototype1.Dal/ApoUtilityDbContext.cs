using System.Data.Entity;
using ApoUtilityPrototype1.DomainModels;

namespace ApoUtilityPrototype1.Dal
{
    public class ApoUtilityDbContext : DbContext
    {
        public ApoUtilityDbContext()
            : base("conApoUtility")
        {
        }

        public DbSet<UserAccount> Account { get; set; }
    }
}
