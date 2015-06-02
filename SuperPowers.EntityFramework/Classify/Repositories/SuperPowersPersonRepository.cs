using Abp.EntityFramework;
using SuperPowers.Classify.Entities;
using SuperPowers.EntityFramework;
using SuperPowers.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify.Repositories
{
    public class SuperPowersPersonRepository : SuperPowersRepositoryBase<SuperPowersPerson>, ISuperPowersPersonRepository
    {
        public SuperPowersPersonRepository(IDbContextProvider<SuperPowersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
