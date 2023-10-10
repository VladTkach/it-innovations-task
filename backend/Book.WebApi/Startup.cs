using Book.WebApi.Extensions;

namespace Book.WebApi;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddBookContext(_configuration);
        services.RegisterAutoMapper();
        
        services.RegisterCustomServices();
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddControllers();
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
        
        app.UseBookContext();

        app.UseEndpoints(cfg => { cfg.MapControllers(); });
    }
}