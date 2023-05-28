using System.ComponentModel.DataAnnotations;

namespace Adventum.Models;

public class RegisterModel
{
    [Required]
    [Display(Name = "������������� ���")]
    [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
    public string Username { get; set; }

    [Required]
    [MaxLength(25)]
    [Display(Name = "���")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(25)]
    [Display(Name = "�������")]
    public string LastName { get; set; }


    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
        MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "������")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "�������� ������")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}