using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ClassLibraryYouBim
{
    public static class BulkCopy
    {
        public static void BulKCopyXml(string xmlFilePath, string databaseName, string tableName, string serverName)
        {
            if (!File.Exists(xmlFilePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }

            string connectionString = "server=" + serverName + ";database=" + databaseName + ";integrated security=true";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataSet dataset = new DataSet();

                dataset.ReadXml(xmlFilePath);

                DataTable table = dataset.Tables[tableName];

                con.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
                {
                    bulkCopy.DestinationTableName = tableName;
                    foreach (DataColumn column in table.Columns)
                    {
                        bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                    }
                    bulkCopy.WriteToServer(table);
                }
            }
        }
    }
}
