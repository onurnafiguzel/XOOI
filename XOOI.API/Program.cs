using Microsoft.EntityFrameworkCore;
using System.Reflection;
using XOOI.API.Data;
using XOOI.API.Data.Repository;
using XOOI.API.Data.UnitOfWork;

namespace XOOI.API;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddControllers();
		builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));		
	
		builder.Services.AddDbContext<AppDbContext>(options =>
			options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

		builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
		builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));	

        builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

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
	}
}
