using SINGLECODEBASE.Shared.Services;

namespace SINGLECODEBASE.Web.Client.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetBlazorType()
        {
            return "Blazor WASM";
        }

        public string GetDeviceType()
        {
            return "Browser";
        }

        public string GetPlatformType()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
