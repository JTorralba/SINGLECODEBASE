using SCB.Shared.Services;

namespace SCB.Web.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetBlazorType()
        {
            return "Blazor Server";
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
