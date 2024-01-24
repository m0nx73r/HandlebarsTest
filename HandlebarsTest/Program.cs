using HandlebarsDotNet;
using Newtonsoft;
using HtmlMapperUsingHandlebars.Services.Interface;
using HtmlMapperUsingHandlebars.Services.Implemented;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITemplateMapperService, TemplateMapperService>();

Handlebars.RegisterHelper("isFirst", (writer, context, parameters) => {
    if(parameters.At<int>(0) == 0)
    {
        writer.WriteSafeString("font-weight: bold");
    }
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
