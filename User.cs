using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MP_KT3_2025;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    [Key] public Guid Id { get; set; }
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string Email { get; set; }
    [Required] public DateOnly DateOfBirth { get; set; }

    public bool IsValidDateOfBirth()
    {
        const int allowedAge = 14;

        var today = DateOnly.FromDateTime(DateTime.Today);
        var age = today.Year - DateOfBirth.Year;

        if (DateOfBirth > today.AddYears(-age))
        {
            age--;
        }

        return age >= allowedAge;
    }
}
