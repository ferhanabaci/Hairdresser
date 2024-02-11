using SSayan.Persistence;
using SSayan.Application;
using Microsoft.IdentityModel.Tokens;
using System.Text;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication("admin")
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true,// olu?turulacak token degerini  kimlerin/kullan?cag?n? hangi sitelerin kullan?lacag? degerdir. www.bilmemne.com
            ValidateIssuer = true, // olu?turulacak token degerini kimin dag?tacag?n? ifade edecegimz aland?r. www.myapi.com
            ValidateLifetime = true,// olu?turalacak token süresi
            ValidateIssuerSigningKey = true, //  olu?turalacak token degerinin uygulamam?za ait oldugunu ifade edecek security key verisini dogrulanmas?d?r


            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"]))

        };
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
