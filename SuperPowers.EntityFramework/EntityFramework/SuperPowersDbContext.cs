using Abp.EntityFramework;
using SuperPowers.Classify.Mappings;

namespace SuperPowers.EntityFramework
{
    public class SuperPowersDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SuperPowersDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SuperPowersDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SuperPowersDbContext since ABP automatically handles it.
         */
        public SuperPowersDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("super_powers");
            modelBuilder.Configurations.Add(new SuperPowersPersonMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
