using Bogus;

namespace MP_KT3_2025;

public static class UserGenerator
{
    public static void GenerateRandomUsers(List<User> ret, int count)
    {
        var faker = new Faker<User>()
            .RuleFor(u => u.Uuid, Guid.CreateVersion7)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.DateOfBirth, f => f.Date.RecentDateOnly(20).ToString("O"));

        for (var i = 0; i < count; i++)
        {
            ret.Add(faker.Generate());
        }
    }
}
