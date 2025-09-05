namespace MP_KT3_2025;

public static class MainLogic
{
    public static void RunLogic()
    {
        var randomUsers = new List<User>();
        UserGenerator.GenerateRandomUsers(randomUsers, 10);

        foreach (var randomUser in randomUsers)
        {
            Console.WriteLine($"{(randomUser.IsValidDateOfBirth() ? "good" : "failure")}:\t{randomUser.Email}\t{randomUser.DateOfBirth}");
        }

        Console.Write(Environment.NewLine);

        using var context = new AppDbContext();

        context.Database.EnsureDeleted();

        context.Database.EnsureCreated();

        // ok
        foreach (var randomUser in randomUsers.Where(x => x.IsValidDateOfBirth()))
        {
            context.Users.Add(randomUser);
        }

        context.SaveChanges();

        // exception
        foreach (var randomUser in randomUsers.Where(x => !x.IsValidDateOfBirth()))
        {
            context.Users.Add(randomUser);
        }

        context.SaveChanges();
    }
}

public static class Program
{
    private static void Main(string[] _)
    {
        MainLogic.RunLogic();
    }
}
