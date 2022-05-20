using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JulieShop.Infrastructure.Data;
using JulieShop.Domain.Entities;

namespace JulieShopWebUI.Pages
{
    public class IndexModel : PageModel
    {
        private JulieShopDbContext _dbConetxt;
        public List<Category> Categories { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JulieShopDbContext context)
        {
            _logger = logger;
            _dbConetxt = context;
            Categories = _dbConetxt.Categories.ToList();
        }

        public void OnGet()
        {

        }
    }
}