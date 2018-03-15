using System.Data.Entity;
using Domain.Entities;
using Domain.Generic;
using Infraestructure.Generic;

namespace Infraestructure.Repositories
{
    public class StoreRepository:Repository<Store>,IStoreRepository
    {
        private DbSet<Store> _stores;

        public StoreRepository()
        {
            var context = new MyStoreDbContext();
            _stores = context.Stores;
        }
    }
}
