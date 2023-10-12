using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Library.BLL.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}