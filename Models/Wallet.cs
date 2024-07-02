using System.ComponentModel.DataAnnotations;

namespace NRGnet_Finances.Models
{
    public class Wallet
    {
        [Key]
        public Guid ID { get; set; }

        public string? Name { get; set; }

        public string? Instance { get; set; }
        public double? Balance { get; set; }
        public string? Currency { get; set; }
        public bool IsInvestment { get; set; }

        //public virtual ICollection<Member>? Members { get; set; }
        public virtual ICollection<Income>? Incomes { get; set; }
        public virtual ICollection<Expense>? Expenses { get; set; }
    }
}