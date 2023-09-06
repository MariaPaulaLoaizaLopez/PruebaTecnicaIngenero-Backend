using GestionLogistica.Business.Services;
using GestionLogistica.Database.Context;
using GestionLogistica.Database.Repositories;
using GestionLogistica.Database.Repositories.Interfaces;
using GestionLogistica.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddDbContext<GestionLogisticaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("GestionContext"))
) ;

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IAlmacenamientoRepository, AlmacenamientoRepository>();
builder.Services.AddScoped<IAlmacenamientoService, AlmacenamientoService>();
builder.Services.AddScoped<IMedioDeTransporteRepository, MedioDeTransporteRepository>();
builder.Services.AddScoped<IMedioDeTransporteService, MedioDeTransporteService>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IPlanDeEntregaRepository, PlanDeEntregaRepository>();
builder.Services.AddScoped<IPlanDeEntregaService, PlanDeEntregaService>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
