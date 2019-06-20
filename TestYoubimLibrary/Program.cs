using System;
using ClassLibraryYouBim;
namespace TestYoubimLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indicate the full path of the xml file:");
            string xmlPath = Console.ReadLine();

            Console.WriteLine("Indicate the database name");
            string dbName = Console.ReadLine();

            Console.WriteLine("Indicate the table name");
            string tableName = Console.ReadLine();

            Console.WriteLine("Indicate the server name");
            string serverName = Console.ReadLine();

            BulkCopy.BulKCopyXml(xmlPath, dbName, tableName, serverName);
            Console.WriteLine("Process end.");
        }
    }
}
