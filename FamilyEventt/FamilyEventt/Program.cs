using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using FamilyEventt.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<FamilyEventContext>(options=>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection1"))
    );
//Khai báo 
builder.Services.AddScoped<IDrink, DrinkService>();
builder.Services.AddScoped<IProduct, ProductService>();
builder.Services.AddScoped<IGame, GameService>();
builder.Services.AddScoped<IShow, ShowService>();
builder.Services.AddScoped<IFoodType, FoodTypeService>();
builder.Services.AddScoped<ILocation, LocationService>();
builder.Services.AddScoped<IEventBooker, EventBookerService>();
builder.Services.AddScoped<IFood, FoodService>();
builder.Services.AddScoped<IAccount, AccountService>();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(Options =>
{
    Options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer =builder.Configuration["Jwt:Issuer"],
        ValidAudience =builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FamilyEventApi v1"));
}

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FamilyEventApi v1"));

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(x => x

                                            .AllowAnyOrigin()
                                            .AllowAnyHeader()
                                            .AllowAnyMethod());

app.UseAuthentication();
//app.UseAuthorization();

app.MapControllers();

app.Run();


