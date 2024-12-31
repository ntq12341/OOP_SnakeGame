using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    /// <summary>
    /// Lớp phụ trách thực thi các câu lệnh SQL
    /// </summary>
    internal class Modify
    {
        public Modify() { }

        // Câu lệnh SQL
        SqlCommand sqlCommand;

        // Biến giúp đọc dữ liệu từ file cơ sở dữ liệu
        SqlDataReader reader;

        /// <summary>
        /// Trả về danh sách thông tin tất cả người chơi từ bảng dữ liệu
        /// </summary>
        /// <param name="query">Câu lệnh SQL</param>
        /// <returns></returns>
        public List<Player> ListPlayers(string query)
        {
            List<Player> players = new List<Player>();
            using(SqlConnection sqlConnection = SqlConnector.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);  
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    players.Add(new Player(reader.GetString(0),reader.GetString(1),reader.GetInt32(2)));
                }
                sqlConnection.Close();
            }
            return players; 
        }

        /// <summary>
        /// Trả về danh sách top những người chơi có điểm cao nhất
        /// </summary>
        /// <param name="query">Câu lệnh SQL</param>
        /// <returns></returns>
        public List<Player> TopPlayers(string query)
        {
            List<Player> players = new List<Player>();
            using (SqlConnection sqlConnection = SqlConnector.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    players.Add(new Player(reader.GetString(0),"", reader.GetInt32(1)));
                }
                sqlConnection.Close();
            }
            return players;
        }

        /// <summary>
        /// Thực hiện các câu lệnh SQL không phải truy vấn
        /// </summary>
        /// <param name="query">Câu lệnh SQL</param>
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = SqlConnector.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
