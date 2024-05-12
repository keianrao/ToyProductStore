using MySql.Data.MySqlClient;
using System.Text;

static MySqlConnection StartupConnection()
{
    StringBuilder connstr = new StringBuilder();
    connstr.Append("server=127.0.0.1");
    connstr.Append(";uid=root");
    connstr.Append(";pwd=Kopitiam_347");
    connstr.Append(";database=Products");

    MySqlConnection returnee = new MySqlConnection();
    returnee.ConnectionString = connstr.ToString();
    returnee.Open();
    return returnee;
}

MySqlConnection conn;
try {
    conn = StartupConnection();
}
catch (MySqlException eSql) {
    Console.WriteLine(eSql);
}