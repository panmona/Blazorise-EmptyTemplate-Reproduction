using Blazorise;
using BlazoriseBugReportMaterial_250109.Components;
using Blazorise.Material;
using Blazorise.Icons.Material;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

AddBlazorise( builder.Services );

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler( "/Error", createScopeForErrors: true );
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies( typeof( BlazoriseBugReportMaterial_250109.Client._Imports ).Assembly );

app.Run();

void AddBlazorise( IServiceCollection services )
{
    services
        .AddBlazorise();
    services
        .AddMaterialProviders()
        .AddMaterialIcons();
}