namespace SCB.Shared.Services
{
    public interface IFormFactor
    {
        public string GetBlazorType();

        public string GetDeviceType();

        public string GetPlatformType();
    }
}
