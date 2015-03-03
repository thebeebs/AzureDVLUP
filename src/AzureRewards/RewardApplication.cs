namespace AzureRewards.Models
{
    public class RewardApplication
    {
        public RewardApplication(string WebsiteName) {
            this.Websitename = WebsiteName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailContact { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Websitename { get; set; }
        public bool Optin { get; set; }
    }
}