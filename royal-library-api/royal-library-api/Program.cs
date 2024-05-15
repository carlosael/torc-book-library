using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Domain.Handlers;
using RoyalLibrary.Domain.Interfaces;
using RoyalLibrary.Repository;
using RoyalLibrary.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddTransient<IListener<BookSearchEvent>, BookSearchEventListener>();
builder.Services.AddTransient<IListener>(sp => sp.GetService<IListener<BookSearchEvent>>());
builder.Services.AddTransient<IDispatcher, Dispatcher>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
