using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProcessFailureDatabase.Client;
using ProcessFailureDatabase.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HTTP and Auth when added
builder.Services.AddScoped(sp => new HttpClient
    { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Dependency Injection
builder.Services.AddScoped<IValueStreamService, ValueStreamService>();

// Additional Package Services

// Last
await builder.Build().RunAsync();