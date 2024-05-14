using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewTable.Models
{
    public class Record
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        public DateTime Date { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PaidTo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PaidFrom { get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public bool Check;
        
        [Column(TypeName = "nvarchar(50)")]
        public string Account { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public required string Pay;

        [Column(TypeName = "nvarchar(50)")]
        public required string Category { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public required string FileName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Notes { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public double GBP { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public double EUR { get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public double USD { get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public double VAT { get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public double Fees { get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public double Total { get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public DateTime InvDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public bool Rec;
        [Column(TypeName = "nvarchar(50)")]
        public DateTime LastReceived { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public DateTime ReceiptDate { get; set; }
        

    }
}
