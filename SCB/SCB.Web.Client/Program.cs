using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SCB.Shared.Services;
using SCB.Web.Client.Services;

namespace SCB.Web.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add device-specific services used by the SCB.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            await builder.Build().RunAsync();
        }
    }
}
