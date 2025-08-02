using SINGLECODEBASE.Shared.Services;

namespace SINGLECODEBASE.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            //DeviceInfo.Idiom.ToString()
            return $"Blazor MAUI {DeviceInfo.Idiom}";
        }

        public string GetPlatform()
        {
            return $"{DeviceInfo.Platform} {DeviceInfo.VersionString}";
        }
    }
}
