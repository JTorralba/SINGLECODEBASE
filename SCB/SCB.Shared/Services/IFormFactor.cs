namespace SCB.Shared.Services
{
    public interface IFormFactor
    {
        public string GetBlazorType();

        public string GetDeviceType();

        public string GetPlatformType();

        public string GetIP_WAN();

        public string GetIP_LAN();

        public Task<string> GetIP_WAN_MAUI();

        public string GetIP_LAN_MAUI();
    }
}
