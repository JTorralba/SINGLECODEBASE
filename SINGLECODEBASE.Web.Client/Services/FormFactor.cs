using SINGLECODEBASE.Shared.Services;

namespace SINGLECODEBASE.Web.Client.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "Blazor WASM";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
