using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class MenuReadRepository : ReadRepository<Menu>, IMenuReadRepository
    {
        public MenuReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
