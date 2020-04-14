using System;
using System.Data.SqlClient;

namespace consoleSqlConnect
{
    class Program
    {
        static void Main(string[] args)
        {//Integrated Security=True
           const string conString = @"Data source=172.16.137.139; Initial catalog=AlifAcademy; user id=sa; password=Root123.;
           SqlConnection con = new SqlConnection();
        }
    }
}
