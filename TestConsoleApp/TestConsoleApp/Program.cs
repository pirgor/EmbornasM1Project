using M1_Partial_Library.Data;
using M1_Partial_Library.DataAccess;
using M1_Partial_Library.Objects;
using Microsoft.Extensions.Configuration;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlData db = GetConnection();
            AddItem(db);
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }
        static SqlData GetConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            ISqlDataAccess dbAccess = new SqlDataAccess(config);
            SqlData db = new SqlData(dbAccess);
            return db;
        }

        private static void AddItem(SqlData db)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Code: ");
            string code = Console.ReadLine();

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("UnitPrice: ");
            int unitPrice = Console.Read();

            Item item = new Item
            {
                Name = name,
                Code = code,
                Brand = brand,
                UnitPrice = unitPrice
            };
            db.addItem(item);

        }

    }
}
