namespace Edelstein.Data.Models.Components;

public class Subscription
{
    public string? MasterBillingSubscriptionLabel { get; set; }
    public int PurchaseCount { get; set; }
    public long LastPurchaseDateTime { get; set; }
    public long StartDateTime { get; set; }
    public long ExpireDateTime { get; set; }
}
