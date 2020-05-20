using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        // Default way to capturing the category
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("DemoCategory");
        }

        public void OnGet()
        {
            // organizing by order of severity
            _logger.LogTrace("This is a Trace log");
            _logger.LogDebug("This is a Debug log");
            _logger.LogInformation("This is an information log");
            _logger.LogWarning("This is a warning log");
            _logger.LogError("This is a error log");
            _logger.LogCritical("This is a critial log");

            _logger.LogError("The server wen down temporarily at {Time}", DateTime.UtcNow);

            // Advanced loggin messages
            try
            {
                throw new Exception("U forget to catch me");
            }
            catch (Exception ex)
            {

                _logger.LogCritical(ex, "There was a bad exception at {Time}", DateTime.UtcNow);
            }
        }
    }

    public class LoggingId
    {
        public const int DemoCode = 1001;
    }
}
