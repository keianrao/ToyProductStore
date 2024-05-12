/* copyright

ToyProductStore
Written in 2024 by Keian Rao <keian.rao@gmail.com>

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>.

copyright */

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

MySqlCommand query = new MySqlCommand();
query.CommandText = "SELECT * FROM Stock;";
query.Connection = conn;
MySqlDataReader results = query.ExecuteReader();
while (results.Read())
{
    Console.WriteLine(results[1] + " (#" + results[0] + ")");
    Console.WriteLine(results[2]);
    Console.WriteLine("RM" + results[3] + " ea ");
    Console.WriteLine();
}
