using Microsoft.AspNetCore.Routing.Template;
using Newtonsoft.Json.Linq;

namespace HtmlMapperUsingHandlebars.Services.Interface
{
    public interface ITemplateMapperService
    {
        public string MapTemplate(string template, JObject data);
    }
}
