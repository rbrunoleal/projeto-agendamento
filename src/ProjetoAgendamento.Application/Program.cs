using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Data.DepedencyInjection;
using ProjetoAgendamento.Domain.ProfileMappings;
using ProjetoAgendamento.Service.DepedencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<DbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresDB")));

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new DtoToEntity());
    cfg.AddProfile(new EntityToResponse());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

ConfigureRepository.ConfigureDependenciesRepository(builder.Services);
ConfigureService.ConfigureDependenciesService(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
