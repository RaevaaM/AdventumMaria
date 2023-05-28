using System.ComponentModel.DataAnnotations;

namespace Adventum.Models;

public class LoginModel
{
    [Display(Name = "Потребителско име")]
    [Required] public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Парола")]
    public string Password { get; set; }

    [Display(Name = "Запомни ме?")] public bool RememberMe { get; set; }
}