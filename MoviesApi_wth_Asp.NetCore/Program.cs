using Microsoft.EntityFrameworkCore;

namespace MoviesApi_wth_Asp.NetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();


            //Use Connection string from Apsetting.json
            builder.Services.AddDbContext<MovieContext>(optionsn =>

                optionsn.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbCS"))
            );    

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
