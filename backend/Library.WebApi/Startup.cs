using Library.BLL.Extensions;
using Library.WebApi.Extensions;
using Library.WebApi.Filter;

namespace Library.WebApi;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddLibraryContext(_configuration);
        services.RegisterAutoMapper();
        
        services.RegisterCustomServices();
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddControllers(o =>
        {
            o.Filters.Add(typeof(CustomExceptionFilter));
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

        app.UseRouting();
        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();
        
        app.UseLibraryContext();

        app.UseEndpoints(cfg => { cfg.MapControllers(); });
    }
}