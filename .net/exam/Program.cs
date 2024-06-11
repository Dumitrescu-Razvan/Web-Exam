namespace exam;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Allow all CORS
        //? No ideea why it doesn't work
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(
                builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });

        // Allow only localhost
        //* This works
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowLocalhost",
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
        });

        //! NO AUTHENTICATION ADDED
        //TODO: Maybe add authentication
        // builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        //     .AddCookie(options =>
        //     {
        //         options.Cookie.SameSite = SameSiteMode.None;
        //         options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        //         options.Cookie.HttpOnly = true;
        //         options.Cookie.Name = "auth_cookie";
        //         options.LoginPath = "/login";
        //     });

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseCors("AllowLocalhost");


        app.UseHttpsRedirection();
        app.UseRouting();
        //! NO AUTHENTICATION ADDED
        // app.UseAuthentication();
        // app.UseAuthorization();

        app.MapControllers();
        app.Run();
    }
}