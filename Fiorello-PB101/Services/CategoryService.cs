using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
