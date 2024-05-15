using Fiorello_PB101.Models;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
