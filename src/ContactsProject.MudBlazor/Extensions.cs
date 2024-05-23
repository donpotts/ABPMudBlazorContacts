using ContactsWebClientMudBlazor.Services;
using Blazored.LocalStorage;
using ContactsWebClientMudBlazor.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace ContactsWebClientMudBlazor;

public static class Extensions
{
    public static void AddBlazorServices(this IServiceCollection services, string baseAddress)
    {
        services.AddMudServices();
        services.AddScoped<AppService>();

        services.AddScoped(sp
            => new HttpClient { BaseAddress = new Uri(baseAddress) });

        services.AddAuthorizationCore();
        services
            .AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();
        
    }
    public static void AddBrowserStorageService(this IServiceCollection services)
    {
        services.AddBlazoredLocalStorage();
        services.AddScoped<IStorageService, BrowserStorageService>();
    }
}
