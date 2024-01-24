using Microsoft.AspNetCore.Routing.Template;
using Newtonsoft.Json.Linq;

namespace HandlebarsTest.Services.Interface
{
    public interface ITemplateMapperService
    {
        public string MapTemplate(string template, JObject data);
    }
}
