using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetapp.Pages
{
    public class DebugModel : PageModel
    {
        private readonly ILogger<DebugModel> _logger;

        public DebugModel(ILogger<DebugModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
