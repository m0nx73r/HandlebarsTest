using Newtonsoft.Json.Linq;

namespace HtmlMapperUsingHandlebars.Models.RequestModels
{
    public class TemplateMappingRequestModel
    {
        //[Required]
        //to do: custom annotation can be built 
        public string Template { get; set; }

        //[Required]
        public object Body { get; set; }
    }
}
