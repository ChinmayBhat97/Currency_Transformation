using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Currency_Transformation.Models
{
    public class Transaction
    {
        [Key]
        [DisplayName("Transaction ID")]
        public int TransactionId  { get; set; }

        [Column(TypeName="nvarchar(15)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This field is required")]
        public  string  AccountNumber{ get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("IFSC")]
        [Required(ErrorMessage = "This field is required")]
        public string swiftcode { get; set; }
        [DisplayName("Amount")]
        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }
        [DisplayName("Date & Time")]
        
        public DateTime Date { get; set; }
    }
}
