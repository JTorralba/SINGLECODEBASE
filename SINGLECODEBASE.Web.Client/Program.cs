using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using SINGLECODEBASE.Web.Client.Services;
using SINGLECODEBASE.Shared.Services;

namespace SINGLECODEBASE.Web.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            await builder.Build().RunAsync();
        }
    }
}
