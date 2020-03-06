using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {

        [Required(ErrorMessage ="Required")]
        [Display(Prompt ="Enter First Name", Name ="First Name" )]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Required")]
        [Display(Prompt = "Enter Last Name", Name ="Last Name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required (ErrorMessage="Required")]
        [Display(Prompt ="te@techelevator.com", Name ="Email")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Prompt = "te@techelevator.com", Name = "Confirm Email")]
        [Compare ("EmailAddress")]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [StringLength(1000, MinimumLength =8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }



        [Required]
        [DataType(DataType.Date)]
        [Display(Prompt ="01/01/2001", Name ="Birthday")]

        public DateTime BirthDate { get; set; }

        [Required]
        [Range(1,10)]
        [Display(Prompt ="4", Name ="# of Tickets")]
        public int NumberOfTickets { get; set; }
    }
}