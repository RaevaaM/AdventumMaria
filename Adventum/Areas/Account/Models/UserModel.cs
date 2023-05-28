using System.ComponentModel.DataAnnotations;

namespace Adventum.Areas.Account.Models;

public class UserModel
{
    public string UserId { get; set; }
    [Display(Name = "������������� ���")]
    public string Username { get; set; }
    [Display(Name = "���")]
    public string FirstName { get; set; }
    [Display(Name = "�������")]
    public string LastName { get; set; }
    [Display(Name = "Email")]
    public string Email { get; set; }
    [Display(Name = "����������� ����")]
    public string RoleName { get; set; }
}