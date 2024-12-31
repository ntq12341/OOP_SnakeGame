using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace WinFormsApp3
{
    /// <summary>
    /// Kết nối cơ sở dữ liệu
    /// </summary>
    internal class SqlConnector
    {
        // Đường dãn tới file chứa cơ sở dữ liệu
        static string dir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName; 
        
        // đường kết nối tới file cơ sở dữ liệu
        static string connectPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="""+dir+@"\AccountPassword.mdf"";Integrated Security=True";
 
        // Kết nối tới cơ sở dữ liệu
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectPath);
        }
    }
}
