namespace AccountSellingMVC.Entities
{
    public class AccountWebsite
    {
        public int AccountId { get; set; }
        public Account Account { get; set; } = default!;
        
        public int WebsiteId { get; set; }
        public Website Website { get; set; } = default!;
    }
}