
using Microsoft.EntityFrameworkCore;
using Online_Shopping.Repos;
using Online_Shopping.Models;
using Online_Shopping_v2.UnitOfWork;
using Microsoft.OpenApi.Models;

namespace Online_Shopping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(op=>op.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes=true);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(op => 
            {
                op.EnableAnnotations();
                op.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title= "Online shopping API",
                    Version = "v1",
                    Description=" APIs for my online shopping web app ",
                    TermsOfService= new Uri("https://www.google.com"),
                    Contact = new OpenApiContact { 
                    Name="Mohamed Salah",
                    Email="mohamedelmorgel2001@gmail.com"
                    }

                });
            
            
            
            });
           

            builder.Services.AddDbContext<shopContext>(op => op.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("shopConnection")));
            //builder.Services.AddScoped<productRepo>();
            //builder.Services.AddScoped<catalogRepo>();
            //builder.Services.AddScoped<GenericRepo>();
            builder.Services.AddScoped<UnitWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
