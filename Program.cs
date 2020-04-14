using System;
using System.Data;
using System.Data.SqlClient;

namespace consoleSqlConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"Data source=localhost; Initial catalog=DBName; Integrated Security=True"                                               DB
            const string conString = @"Data source=172.16.137.139; Initial catalog=AlifAcademy; user id=sa; password=Root123.";
            SqlConnection con = new SqlConnection(conString);

            con.Open();//Открывает соединение
            if (con.State == ConnectionState.Open)
            {
                System.Console.WriteLine("Connected successfully!!!");
            }
            else
            {
                System.Console.WriteLine("Ooops, troubles with connection!!!");
            }
            string commandText = "Select * from Person";
            SqlCommand command = new SqlCommand(commandText, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //System.Console.WriteLine($"ID:{reader.GetValue(0)}, FirstName:{reader.GetValue(1)}, LastName:{reader.GetValue(2)}");
                System.Console.WriteLine($"ID:{reader.GetValue("Id")}, FirstName:{reader.GetValue("FirstName")}, LastName:{reader.GetValue("LastName")}");
            }
            reader.Close();

            string insertSqlCommand = string.Format($"insert into Person([FirstName],[LastName],[Gender]) Values('{"Test"}', '{"Test"}',{1})");
            command = new SqlCommand(insertSqlCommand, con);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                System.Console.WriteLine("Insert command successfull!!!");
            }
        }
    }
}
