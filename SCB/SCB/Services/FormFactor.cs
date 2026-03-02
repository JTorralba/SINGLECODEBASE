using SCB.Shared.Services;

namespace SCB.Services
{
    public class FormFactor : IFormFactor
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
