using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogTrace("This is a Trace log");
            _logger.LogDebug("This is a Debug log");
            _logger.LogInformation("This is an information log");
            _logger.LogWarning("This is a warning log");
            _logger.LogError("This is a error log");
            _logger.LogCritical("This is a critial log");
        }
    }

    public class LoggingId
    {
        public const int DemoCode = 1001;
    }
}
