using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsService.BL.DTO;
using NewsService.DAL.Models;

namespace NewsService.BL.Services
{
    public interface INewsService
    {
        Task CreateNews(NewsDTO news);
        Task<IEnumerable<NewsDTO>> GetAllNews();
        Task<IEnumerable<NewsDTO>> GetImportantNews();
        Task<IEnumerable<NewsDTO>> GetDailyNews();
        Task<NewsDTO> GetByIdNews(long id);
        Task DeleteNews(long id);
        Task UpdateNews(NewsDTO news);
    }
}
