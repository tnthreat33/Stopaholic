using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopaholic.Shared.Models
{
    public class MonthlyList
    {
        public int MonthlyListId { get; set; }
        public DateTime Month { get; set; }
        public List<Item> Items { get; set; }
        public decimal TotalCost => Items?.Sum(item => item.TotalCost) ?? 0;
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
