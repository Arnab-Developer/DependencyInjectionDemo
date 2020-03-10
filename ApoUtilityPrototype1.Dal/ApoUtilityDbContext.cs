using ApoUtilityPrototype1.DomainModels;
using System.Data.Entity;

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
