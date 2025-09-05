namespace MP_KT3_2025;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string DateOfBirth { get; set; }

    public User(int id, string firstName, string lastName, string email, string dateOfBirth)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
    }
}
