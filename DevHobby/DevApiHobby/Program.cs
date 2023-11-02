using DevApiHobby.Models;
using DevApiHobby.Repositorys.Interface;
using DevApiHobby.Repositorys.Repository;
using DevApiHobby.Services.Interface;
using DevApiHobby.Services.Service;
using Microsoft.EntityFrameworkCore;

namespace DevApiHobby
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IMemberRepository, MemberRepository>();
            builder.Services.AddScoped<IMemberService, MemberService>();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<_94hobbyContext>(option => {
                option.UseSqlServer(builder.Configuration.GetConnectionString("_94Hobby"));
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
        }
    }
}