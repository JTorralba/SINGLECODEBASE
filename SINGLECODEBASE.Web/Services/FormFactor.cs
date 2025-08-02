using SINGLECODEBASE.Shared.Services;

namespace SINGLECODEBASE.Web.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "Blazor Server";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
