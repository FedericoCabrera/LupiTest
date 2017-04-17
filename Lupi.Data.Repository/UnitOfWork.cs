using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lupi.Data.DataAccess;
using Lupi.Data.Entities;

namespace Lupi.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LupiDbContext dbContext;
        public UnitOfWork()
        {
            dbContext = new LupiDbContext();
        }

        private IRepository<Owner> ownerRepository;
        public IRepository<Owner> OwnerRepository
        {
            get
            {
                if(ownerRepository == null)
                {
                    ownerRepository = new Repository<Owner>();
                }

                return ownerRepository;
            }
        }
    }
}
