using Blazorise.Material;
using Blazorise.Icons.Material;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault( args );

AddBlazorise( builder.Services );

await builder.Build().RunAsync();

void AddBlazorise( IServiceCollection services )
{
    services
        .AddBlazorise();
    services
        .AddMaterialProviders()
        .AddMaterialIcons();
}