using HandlebarsTest.Models.RequestModels;
using HandlebarsTest.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace HandlebarsTest.Controllers
{

    [ApiController]

    [Route("api/[controller]")]
    public class HtmlMapperController : ControllerBase
    {
        private readonly ITemplateMapperService _userMappingService;
        public HtmlMapperController(ITemplateMapperService userMappingService) {
            this._userMappingService = userMappingService;
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
