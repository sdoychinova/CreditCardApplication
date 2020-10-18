using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        [Required(ErrorMessage ="Enter your first name")]
        [Display(Name ="First name")]
        [StringLength(100)]
        public string FisrtName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [StringLength(100)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your date of birth")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Enter your annual income")]
        [Display(Name = "Annual Income")]
        [Column(TypeName = "money")]
        public decimal AnnualIncome { get; set; }

        public Card ApplicationCardResult { get; set; }
    }
}
