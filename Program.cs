namespace MP_KT3_2025;

public static class MainLogic
{
    public static void RunLogic()
    {
        var randomUsers = new List<User>();
        UserGenerator.GenerateRandomUsers(randomUsers, 10);

        Console.WriteLine();
    }
}

public static class Program
{
    private static void Main(string[] _)
    {
        MainLogic.RunLogic();
    }
}
