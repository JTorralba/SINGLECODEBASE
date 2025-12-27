using SINGLECODEBASE.Shared.Services;

namespace SINGLECODEBASE.Services
{
    internal class FormFactor : IFormFactor
    {
        public string GetBlazorType()
        {
            return $"Blazor Hybrid";
        }

        public string GetDeviceType()
        {

            return DeviceInfo.Idiom.ToString();
        }

        public string GetPlatformType()
        {
            return $"{DeviceInfo.Platform} {DeviceInfo.VersionString}";
        }
    }
}
