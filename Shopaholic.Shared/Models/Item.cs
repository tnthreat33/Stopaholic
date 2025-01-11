
namespace Stopaholic.Shared.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string PurchaseLink { get; set; } = string.Empty;
        public decimal TotalCost { get; set; }
        public PriorityLevel Priority { get; set; }
        public int UserId { get; set; }
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

}
