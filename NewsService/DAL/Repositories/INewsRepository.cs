using System.Collections.Generic;
using System.Threading.Tasks;
using NewsService.DAL.Models;


namespace NewsService.DAL.Repositories
{
    public interface INewsRepository
    {
        Task Add(News news);
        Task<IEnumerable<News>> GetAll();
        Task<News> GetById(long id);
        Task Delete(long id);
        Task Update(News news);
    }
}
