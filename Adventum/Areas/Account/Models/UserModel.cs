using System.ComponentModel.DataAnnotations;

namespace Adventum.Areas.Account.Models;

public class UserModel
{
    public string UserId { get; set; }
    [Display(Name = "Потребителско име")]
    public string Username { get; set; }
    [Display(Name = "Име")]
    public string FirstName { get; set; }
    [Display(Name = "Фамилия")]
    public string LastName { get; set; }
    [Display(Name = "Email")]
    public string Email { get; set; }
    [Display(Name = "Регистриран като")]
    public string RoleName { get; set; }
}