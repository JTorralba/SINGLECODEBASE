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

        public string GetIP_WAN()
        {
            return "0.0.0.0";
        }

        public string GetIP_LAN()
        {
            return "0.0.0.0";
        }

        public async Task<string> GetIP_WAN_MAUI()
        {
            return "0.0.0.0";
        }

        public string GetIP_LAN_MAUI()
        {
            return "0.0.0.0";
        }
    }
}
