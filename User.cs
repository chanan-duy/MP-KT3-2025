using System.ComponentModel.DataAnnotations;

namespace MP_KT3_2025;

public class User
{
    [Key] public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateOnly DateOfBirth { get; set; }
}
