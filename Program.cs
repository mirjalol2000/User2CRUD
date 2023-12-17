using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using User2CRUD.Brokers.Storages;
using User2CRUD.Services.Foundations.Calculations;
using User2CRUD.Services.Foundations.Feedbacks;
using User2CRUD.Services.Foundations.Users;
using User2CRUD.Services.Orchestration;
using User2CRUD.Services.Processings.Calculations;
using User2CRUD.Services.Processings.Feedbacks;
using User2CRUD.Services.Processings.Users;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<IStorageBroker, StorageBroker>();

AddFoundations(builder);
AddProcessings(builder);
Orchestrations(builder);

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

static void AddFoundations(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserService, UserService>();
    builder.Services.AddTransient<ICalculationService, CalculationService>();
    builder.Services.AddTransient<IFeedbackService, FeedbackService>();
}

static void AddProcessings(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserProcessingService, UserProcessingService>();
    builder.Services.AddTransient<ICalculationProcessingService, CalculationProcessingService>();
    builder.Services.AddTransient<IFeedbackProcessingService, FeedbackProcessingService>();
}

static void Orchestrations(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<ICalculationOrchestrationService, CalculationOrchestrationService>();
}