using SCB.Shared.Services;

namespace SCB.Web.Client.Services
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
