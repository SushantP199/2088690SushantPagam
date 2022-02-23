using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
{
    Title = "Swagger with WebAPI",

    Version = "v1",

    Description = "Demostration of Swagger Interface",

    TermsOfService = null,

    Contact = new Microsoft.OpenApi.Models.OpenApiContact
    {
        Name = "Sushant Pagam",
        Email = "sushantpagam199@gmail.com",
        Url = new System.Uri("https://play.google.com/store/apps/developer?id=Sushant+Pagam")
    }
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
        {
            // specifying the Swagger JSON endpoint.
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
        }
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
