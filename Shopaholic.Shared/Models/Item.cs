using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopaholic.Shared.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public string PurchaseLink { get; set; }
        public decimal TotalCost { get; set; }
        public PriorityLevel Priority { get; set; }
        public int MonthlyWantListId { get; set; }
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

}
