namespace MakoIoT.Device.Platform.Interface.Configuration
{
    public class PlatformConfig
    {
        public string PlatformServiceUrl { get; set; }
        public string PlatformServiceApiKey { get; set; }

        public static string SectionName => "Platform";
    }
}
