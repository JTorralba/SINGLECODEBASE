using System.Net.NetworkInformation;
using System.Net.Sockets;

using SCB.Shared.Services;

namespace SCB.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetBlazorType()
        {
            return "Blazor Hybrid";
        }

        public string GetDeviceType()
        {
            return DeviceInfo.Idiom.ToString();
        }

        public string GetPlatformType()
        {
            return $"{DeviceInfo.Platform} {DeviceInfo.VersionString}";
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
            try
            {
                using var HTTPClient = new HttpClient();

                HTTPClient.Timeout = TimeSpan.FromSeconds(5);

                string IP = await HTTPClient.GetStringAsync("https://api.ipify.org");

                return IP.Trim();
            }
            catch
            {
                return "WAN?";
            }
        }

        public string GetIP_LAN_MAUI()
        {
            try
            {
                foreach (var NetworkInterface in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (NetworkInterface.OperationalStatus == OperationalStatus.Up && (NetworkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || NetworkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet || NetworkInterface.NetworkInterfaceType == NetworkInterfaceType.Wwanpp || NetworkInterface.NetworkInterfaceType == NetworkInterfaceType.Wwanpp2 || NetworkInterface.NetworkInterfaceType == NetworkInterfaceType.Unknown))
                    {
                        foreach (var IP in NetworkInterface.GetIPProperties().UnicastAddresses)
                        {
                            if (IP.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                return IP.Address.ToString();
                            }
                        }
                    }
                }
                return "LAN?";
            }
            catch
            {
                return "LAN?";
            }
        }
    }
}
