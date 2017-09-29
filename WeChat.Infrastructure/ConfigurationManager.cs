using Microsoft.Extensions.Configuration;

namespace WeChat.Infrastructure
{
    public static class ConfigurationManager
    {
        private static readonly IConfigurationRoot Config = null;
        static ConfigurationManager()
        {
            // Microsoft.Extensions.Configuration扩展包提供的
            var builder = new ConfigurationBuilder()
                .AddJsonFile("app.json");
            Config = builder.Build();
        }

        public static IConfigurationRoot AppSettings => Config;

        public static string Get(string key)
        {
            return Config[key];
        }

        /// <summary>
        /// Extensions
        /// </summary>
        public static dynamic ConnectionStrings => Config["ConnectionStrings"];
    }
}