using MySql.Data.MySqlClient;
using System.Text;

static MySqlConnection StartupConnection()
// Bubbles MySqlException
{
    StringBuilder connstr = new StringBuilder();
    connstr.Append("server=127.0.0.1");
    connstr.Append(";uid=Keian");
    connstr.Append(";pwd=Kopitiam_128");
    // Obviously a connstr is not supposed to expose a DB user's
    // password like this, but what options do we have for logging
    // in with Connection/NET..?
    connstr.Append(";database=Products");

    MySqlConnection returnee = new MySqlConnection();
    returnee.ConnectionString = connstr.ToString();
    returnee.Open();
    return returnee;
}

MySqlConnection conn = StartupConnection();