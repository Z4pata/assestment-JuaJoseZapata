using System.Security.Claims;
using System.Text;
using assestment_JuaJoseZapata.Data;
using assestment_JuaJoseZapata.Repositories;
using assestment_JuaJoseZapata.Service;
using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

var DB_HOST = Environment.GetEnvironmentVariable("DB_HOST");
var DB_NAME = Environment.GetEnvironmentVariable("DB_NAME");
var DB_PORT = Environment.GetEnvironmentVariable("DB_PORT");
var DB_USER = Environment.GetEnvironmentVariable("DB_USER");
var DB_PASSWORD = Environment.GetEnvironmentVariable("DB_PASSWORD");

var stringConnection = $"server={DB_HOST};port={DB_PORT};database={DB_NAME};uid={DB_USER};password={DB_PASSWORD}";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(stringConnection, ServerVersion.Parse("8.0-mysql"));
});



// -------------- JWT ----------------

var JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER") ?? throw new InvalidOperationException("Issuer Not found");

var JWT_Key = Environment.GetEnvironmentVariable("JWT_KEY") ?? throw new InvalidOperationException("JWT Key Not found");
var Key = Encoding.UTF8.GetBytes(JWT_Key);


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Key),
        ValidIssuer = JWT_ISSUER,
        ValidateAudience = false,
        RequireExpirationTime = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});


// ---------------


// This options to prevent infinite loops in the controllers
builder.Services.AddControllers().AddJsonOptions(options =>
{
    // options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});;



// ----- Swagger


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Assestment", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});


// ------- policy
builder.Services.AddAuthorizationBuilder()
    .AddPolicy("DoctorPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "doctor"));


// Add services to the container.

builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddScoped<IPatientRepository, PatientService>();
builder.Services.AddScoped<IDoctorAvailabilityRepository, DoctorAvailabilityService>();



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
