// See https://aka.ms/new-console-template for more information
using DAL;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("hello");

        using (var dbContext = new DBAccessDAL())
        {
            //await DeleteDatabaseAsync(dbContext);
            await CreateDatabaseAsync(dbContext);
        }
    }

    static async Task CreateDatabaseAsync(DBAccessDAL dbContext)
    {
        string databaseName = dbContext.Database.GetDbConnection().Database;
        Console.WriteLine($"Creating database: {databaseName}");

        bool result = await dbContext.Database.EnsureCreatedAsync();

        string resultString = result ? "SUCCESS" : "FAILED";
        Console.WriteLine($"Database Creation Result: {resultString}");
    }

    static async Task DeleteDatabaseAsync(DBAccessDAL dbContext)
    {
        string database = dbContext.Database.GetDbConnection().Database;
        Console.Write($"Delete : {database} (y) ?");
        string input = Console.ReadLine();

        if (input.ToLower() == "y")
        {
            bool deleteResult = await dbContext.Database.EnsureDeletedAsync();
            string deletionInfo = deleteResult ? "deleted" : "don't delete";
            Console.WriteLine($"{database} {deletionInfo}");
        }
    }


}