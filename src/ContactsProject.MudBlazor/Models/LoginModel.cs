using System.ComponentModel.DataAnnotations;

namespace ContactsWebClientMudBlazor.Models;

public class LoginModel
{
    [MaxLength(30)]
    [Required]
    [Display(Name = "User Name")]
    public string? UserName { get; set; }

    [MaxLength(20)]
    [Required]
    public string? Password { get; set; }

    public string? ClientId { get; set; } = "ContactsProject_App";
    public string? ClientSecret { get; set; } = "1q2w3e*";
    public string? GrantType { get; set; } = "password";
    public string? Scope { get; set; } = "ContactsProject";

}
