using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WinFormsApp4
{
    /// <summary>
    /// Kết nối cơ sở dữ liệu
    /// </summary>
    internal class SqlConnector
    {
        // Đường dãn tới file chứa cơ sở dữ liệu
        //    static string dir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName; 

        // đường kết nối tới file cơ sở dữ liệu
        //   static string connectPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="""+dir+@"\AccountPassword.mdf"";Integrated Security=True";

        static string connectPath = "Server=localhost;Database=thongtindangnhap;Userid=root;Password=doanvantu1706;";

        // Kết nối tới cơ sở dữ liệu
        public static MySqlConnection GetSqlConnection()
        {
            return new MySqlConnection(connectPath);
        }
    }
}
