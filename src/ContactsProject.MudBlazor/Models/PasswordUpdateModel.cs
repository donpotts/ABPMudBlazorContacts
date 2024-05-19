using System.ComponentModel.DataAnnotations;

namespace ContactsWebClientMudBlazor.Models;

public class PasswordUpdateModel
{
    [MaxLength(20)]
    [Required]
    [Display(Name = "Current Password")]
    public string? CurrentPassword { get; set; }

    [MaxLength(20)]
    [Required]
    [Display(Name = "New Password")]
    public string? NewPassword { get; set; }
}
