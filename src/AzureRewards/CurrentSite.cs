using System;

namespace AzureRewards.Controllers
{
    internal class CurrentSite
    {
        public static bool HostedInAzure() {
            return !String.IsNullOrEmpty(WebsiteName);
        }
        public static string WebsiteName
        {
            get
            {
                return Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME");
            }
        }

        public static string WebsiteSku
        {
            get
            {
                return Environment.GetEnvironmentVariable("WEBSITE_SKU");
            }
        }
}
}