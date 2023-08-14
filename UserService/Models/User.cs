using System.ComponentModel.DataAnnotations;

namespace UserService.Models;

public class User
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string SecondName { get; set; }
    [MaxLength(20)]
    public required string Phone { get; set; }
}
