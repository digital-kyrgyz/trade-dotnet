using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderReadRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}