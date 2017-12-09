using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsService.Controllers.Pagination;

namespace NewsService.DAL.Models
{
    public class NewsPaginationViewModel
    {
        public IEnumerable<News> news { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
