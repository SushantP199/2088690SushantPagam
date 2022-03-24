using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Restaurant.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var Configuration = builder.Configuration;

builder.Services.AddDbContext<SecDbContext>(
    options =>
    options.UseSqlServer(Configuration.GetConnectionString("con")
  )
);

builder.Services.AddIdentity<AppUser, IdentityRole>(setup =>
{
    setup.Password.RequireDigit = true;
    setup.SignIn.RequireConfirmedEmail = true;
    setup.User.RequireUniqueEmail = true;
    setup.Lockout.MaxFailedAccessAttempts = 5;
    setup.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
})
.AddEntityFrameworkStores<SecDbContext>();

string key = Configuration["JwtSettings:Key"];
string issuer = Configuration["JwtSettings:Issuer"];
string audience = Configuration["JwtSettings:Audience"];
int durationInMinutes = int.Parse(Configuration["JwtSettings:DurationInMinutes"]);
byte[] keyBytes = System.Text.Encoding.ASCII.GetBytes(key);
SecurityKey securityKey = new SymmetricSecurityKey(keyBytes);

builder.Services.AddAuthentication(setup =>
{
    setup.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    setup.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    setup.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    setup.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    setup.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(setup => setup.TokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateIssuerSigningKey = true,
    ValidAudience = audience,
    ValidIssuer = issuer,
    IssuerSigningKey = securityKey
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
