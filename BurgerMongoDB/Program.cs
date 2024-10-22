using BurgerAPI.Services.OrderService;
using BurgerMongoDB.DBContext;
using BurgerMongoDB.Services.OptiosBurger;
using BurgerMongoDB.Services.User;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuration Mongo Database
builder.Services.Configure<DBStoreSettings>(builder.Configuration.GetSection("MongoConnection"));

builder.Services.AddSingleton<IDatabase>(sp =>
    sp.GetRequiredService<IOptions<DBStoreSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("MongoConnection:ConnectionString")));

//Interfaces and Services
builder.Services.AddScoped<IUserService, userService>();
builder.Services.AddScoped<IOptionsBurgerService, optionsBurgerService>();

builder.Services.AddScoped<IOrder, OrderService>();

//Use Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("burgerAPP", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("burgerAPP");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
