using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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

string key = "this is my custom Secret key for authnetication";
var symKey = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(key));

builder.Services.AddAuthentication(auth =>
    {
        auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    }
).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, auth =>
{
    auth.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,

        ValidIssuer = "SysAdm",
        ValidAudience = "users",
        IssuerSigningKey = symKey
    };
});


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

    app.UseAuthentication();
    app.UseAuthorization();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
