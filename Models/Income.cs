using System.ComponentModel.DataAnnotations;

namespace NRGnet_Finances.Models
{
    public class Income
    {
        [Key]
        public Guid ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TimeStamp { get; set; }

        public double Amount { get; set; }
        public string? Category { get; set; }
        public string? Source { get; set; }
        public string? Description { get; set; }
        
        public Guid WalletID { get; set; }
        public Wallet? Wallet { get; set; }
    }
}