using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared;

namespace web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration config;
        private readonly HttpClient http;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config, HttpClient http)
        {
            _logger = logger;
            this.config = config;
            this.http = http;
        }

        public IEnumerable<City>? Cities { get; private set; }

        public async void OnGet()
        {
            string apiHost = config["apiAdress"];
            string url = $"{apiHost}/api/elections/cites";
            Cities = await http.GetFromJsonAsync<IEnumerable<City>>(url);
        }
    }
}