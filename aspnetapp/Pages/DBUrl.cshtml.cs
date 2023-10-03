using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetapp.Pages
{
    public class DBUrlModel : PageModel
    {
        private readonly ILogger<DBUrlModel> _logger;

        public DBUrlModel(ILogger<DBUrlModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
