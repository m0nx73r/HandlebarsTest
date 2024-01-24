using HtmlMapperUsingHandlebars.Models.RequestModels;
using HtmlMapperUsingHandlebars.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace HtmlMapperUsingHandlebars.Controllers
{

    [ApiController]

    [Route("api/[controller]")]
    public class HtmlMapperController : ControllerBase
    {
        private readonly ITemplateMapperService _userMappingService;
        public HtmlMapperController(ITemplateMapperService userMappingService)
        {
            _userMappingService = userMappingService;
        }

        [HttpPost("[action]")]
        public IActionResult MapTemplate([FromBody] TemplateMappingRequestModel request)
        {

            string template = request.Template;
            JObject data = JObject.Parse(request.Body.ToString());
            Console.WriteLine(data);
            string content = _userMappingService.MapTemplate(template, data);
            return Ok(content);
        }

    }
}
