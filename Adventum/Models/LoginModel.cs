using System.ComponentModel.DataAnnotations;

namespace Adventum.Models;

public class LoginModel
{
    [Display(Name = "������������� ���")]
    [Required] public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "������")]
    public string Password { get; set; }

    [Display(Name = "������� ��?")] public bool RememberMe { get; set; }
}