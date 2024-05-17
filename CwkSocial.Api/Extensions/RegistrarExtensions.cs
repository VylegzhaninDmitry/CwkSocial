using CwkSocial.Api.Registrars;

namespace CwkSocial.Api.Extensions;

public static class RegistrarExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
    {
        var registrars = scanningType.Assembly.GetTypes()
            .Where(i => i.IsAssignableTo(typeof(IWebApplicationBuilderRegistrar)) && i is { IsAbstract: false, IsInterface: false })
            .Select(Activator.CreateInstance)
            .Cast<IWebApplicationBuilderRegistrar>();

        foreach (var registrar in registrars)
        {
            registrar.RegisterServices(builder);
        }
    }

    public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
    {
        var registrars = scanningType.Assembly.GetTypes()
            .Where(i => i.IsAssignableTo(typeof(IWebApplicationRegistrar)) && i is { IsAbstract: false, IsInterface: false })
            .Select(Activator.CreateInstance)
            .Cast<IWebApplicationRegistrar>();

        foreach (var registrar in registrars)
        {
            registrar.RegisterPipelineComponents(app);
        }
    }
}