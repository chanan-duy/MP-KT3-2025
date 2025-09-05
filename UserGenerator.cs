using Bogus;

namespace MP_KT3_2025;

public static class UserGenerator
{
    public static void GenerateRandomUsers(List<User> ret, int count)
    {
        var faker = new Faker<User>()
            .RuleFor(u => u.Id, Guid.CreateVersion7)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.DateOfBirth,
                f => f.Date.BetweenDateOnly(new DateOnly(2007, 1, 1), new DateOnly(2014, 1, 1)));

        for (var i = 0; i < count; i++)
        {
            ret.Add(faker.Generate());
        }
    }
}
