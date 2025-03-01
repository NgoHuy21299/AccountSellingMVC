namespace AccountSellingMVC.Entities
{
    public class Account : EntityAuditBase<int>
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string? RecoveryEmail { get; set; } = default!;
        public ICollection<AccountWebsite> AccountWebsites { get; set; } = new List<AccountWebsite>();
    }
}