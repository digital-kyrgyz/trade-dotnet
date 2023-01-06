using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductWriteRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}