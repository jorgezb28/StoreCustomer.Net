using AppService.Dtos;

namespace AppService.Store
{
    public interface IStoreAppService
    {
        StoreDto AddStore(StoreDto newStore);
    }
}
