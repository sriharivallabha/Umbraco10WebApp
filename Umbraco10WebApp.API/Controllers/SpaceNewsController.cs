using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Umbraco10WebApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpaceNewsController : ControllerBase
    {

        private readonly ILogger<SpaceNewsController> _logger;

        public SpaceNewsController(ILogger<SpaceNewsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSpaceNews")]
        public async Task<ActionResult<List<SpaceNews>>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.spaceflightnewsapi.net/");
                    var response = await client.GetAsync($"v3/articles");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var newsResult = JsonConvert.DeserializeObject<List<SpaceNews>>(stringResult);
                    return newsResult.ToList();

                }

                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting news from spacenews: {httpRequestException.Message}");
                }
            }
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> IdAsync(string id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.spaceflightnewsapi.net/");
                    var response = await client.GetAsync($"v3/articles?id={id}");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawWeather = JsonConvert.DeserializeObject<List<SpaceNews>>(stringResult);
                    return Ok();
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                }
            }
        }
    }
}