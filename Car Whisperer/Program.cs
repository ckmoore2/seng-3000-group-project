using Car_Whisperer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Car_Whisperer.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CarWhispererDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CarWhispererDbContext") ?? throw new InvalidOperationException("Connection string 'CarWhispererDbContext' not found.")));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PasswordManager>();

var pwdMgr = new PasswordManager();
var results = pwdMgr.HashPassword("IcantTellU");
Console.WriteLine("Hash below...");
Console.WriteLine(results.hashString);
Console.WriteLine("Salt below...");
Console.WriteLine(results.saltString);
Console.WriteLine();

builder.Services.AddCors( policy => 
{
        policy.AddPolicy("carwhisperer-allowall", config => 
        {
            config.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });
});

#region JWT Validation
/*******************************************
 *  Start JWT Security Configuration
 *  ****************************************/
var secret = "MyVerySuperSecureSecretSharedKey";
var secretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
var issuer = "http://www.ecu.edu";
var audience = "http://www.ecu.edu";

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.ClaimsIssuer = issuer;
    options.MapInboundClaims = true;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = secretKey,

        ValidateIssuer = true,
        ValidIssuer = issuer,

        ValidateAudience = true,
        ValidAudience = audience,

        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };

    options.Events = new JwtBearerEvents
    {
        OnTokenValidated = context =>
        {
            return Task.CompletedTask;
        },
        OnAuthenticationFailed = context =>
        {
            return Task.CompletedTask;

            // ToDo: can check for different kinds of failures
        }
    };
});

/*****************************************
 *  End JWT Security Configuration
 *  **************************************/
#endregion

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireClaim("rol", "Admin"));
    options.AddPolicy("Manager", policy => policy.RequireClaim("rol", "Manager", "Admin"));
    options.AddPolicy("Authenticated", policy => policy.RequireClaim("rol", "User", "Manager", "Admin"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("carwhisperer-allowall");

app.UseMiddleware<TestMiddleware>();
app.UseTestMiddleware();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
