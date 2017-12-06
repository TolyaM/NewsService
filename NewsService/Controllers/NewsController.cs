using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsService.DAL.Models;
using NewsService.DAL.Repositories;

namespace NewsService.Controllers
{
    [Route("api/news")]
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;

        public NewsController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        // GET: api/news
        [HttpGet]
        public Task<IEnumerable<News>> Get()
        {
            return _newsRepository.GetAll();
        }

        // GET api/news/5
        [HttpGet("{id}")]
        public Task<News> Get(int id)
        {
            return _newsRepository.GetById(id);
        }

        // POST api/news
        [HttpPost]
        public async Task Post([FromBody]News news)
        {
            if (ModelState.IsValid)
                await _newsRepository.Add(news);
        }

        // PUT api/news/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]News news)
        {
            news.Id = id;
            if (ModelState.IsValid)
                await _newsRepository.Update(news);
        }

        // DELETE api/news/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _newsRepository.Delete(id);
        }
    }
}
