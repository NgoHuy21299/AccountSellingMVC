namespace AccountSellingMVC.Entities
{
    public class Website : EntityAuditBase<int>
    {
        public string Name { get; set; } = default!;
        public string Url { get; set; } = default!;
        public ICollection<AccountWebsite> AccountWebsites { get; set; } = new List<AccountWebsite>();
    }
}