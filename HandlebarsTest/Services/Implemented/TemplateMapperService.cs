using HandlebarsDotNet;
using HandlebarsTest.Services.Interface;
using Newtonsoft.Json.Linq;
namespace HandlebarsTest.Services.Implemented
{
    public class TemplateMapperService : ITemplateMapperService
    {
        //        private const string _defaultTemplate = @"<!DOCTYPE html>
        //<html lang=""en"">
        //<head>
        //    <meta charset=""UTF-8"">
        //    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        //    <title>Employee Details</title>
        //    <link href=""https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css"" rel=""stylesheet"">
        //</head>
        //<body class=""bg-gray-100 p-4"">
        //    <div class=""container mx-auto"">
        //        <h1 class=""text-2xl font-bold mb-4"">Employee Details:</h1>

        //        <div class=""flex flex-wrap -mx-4"">
        //            {{#each employees}}
        //                <div class=""w-full md:w-1/2 px-4 mb-4"">
        //                    <div class=""bg-white p-6 rounded-lg shadow-md"">
        //                        <table class=""w-full"">
        //                            <tbody>
        //                                <tr>
        //                                    <th>Name</th>
        //                                    <td>{{this.Name}}</td>
        //                                </tr>
        //                                <tr>
        //                                    <th>Age</th>
        //                                    <td>{{this.Age}}</td>
        //                                </tr>
        //                                <tr>
        //                                    <th>Salary</th>
        //                                    <td>{{this.Salary}}</td>
        //                                </tr>
        //                                <tr>
        //                                    <th>Occupation</th>
        //                                    <td>{{this.Occupation}}</td>
        //                                </tr>
        //                                <tr>
        //                                    <th>ProductCode</th>
        //                                    <td>{{this.ProductCode}}</td>
        //                                </tr>
        //                                <tr>
        //                                    <th>PolicyExpiryDate</th>
        //                                    <td>{{this.PolicyExpiryDate}}</td>
        //                                </tr>
        //                            </tbody>
        //                        </table>
        //                    </div>
        //                </div>
        //            {{/each}}
        //        </div>
        //    </div>
        //</body>
        //</html>";

        public TemplateMapperService() {
            Handlebars.RegisterHelper("isFirst", (writer, context, parameters) => {
                if (parameters.At<int>(0) == 0)
                {
                    writer.WriteSafeString("font-weight: bold");
                }
            });
        }
        public string MapTemplate(string template, JObject data)
        {
            HandlebarsTemplate<object, object> compiledTemplate = Handlebars.Compile(template);

            // Pass the jsonData directly to Handlebars
            return compiledTemplate(data);
        }

    }
}
