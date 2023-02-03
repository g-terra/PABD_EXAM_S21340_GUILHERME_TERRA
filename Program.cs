using s21340_exam.Configurations;
using s21340_exam.Middlewares.ExceptionHandling;
using s21340_exam.Middlewares.TransactionsHandling;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterContext(builder.Configuration);

builder.Services.RegisterRepositories();

builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseTransactionHandler();

app.UseGlobalErrorHandler();

app.MapControllers();

app.Run();