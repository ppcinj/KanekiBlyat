using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace ParelloZmorge.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "\"{0}\" muss mindestens {2} Zeichen lang sein.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Neues Kennwort")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Neues Kennwort bestätigen")]
        [Compare("NewPassword", ErrorMessage = "Das neue Kennwort stimmt nicht mit dem Bestätigungskennwort überein.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Aktuelles Kennwort")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "\"{0}\" muss mindestens {2} Zeichen lang sein.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Neues Kennwort")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Neues Kennwort bestätigen")]
        [Compare("NewPassword", ErrorMessage = "Das neue Kennwort stimmt nicht mit dem Bestätigungskennwort überein.")]
        public string ConfirmPassword { get; set; }
    }
}