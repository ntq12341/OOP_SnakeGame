using MySql.Data.MySqlClient;

namespace WinFormsApp4
{
    /// <summary>
    /// Lớp phụ trách thực thi các câu lệnh SQL
    /// </summary>
    internal class Modify
    {
        public Modify() { }

        // Câu lệnh SQL
        MySqlCommand sqlCommand;

        // Biến giúp đọc dữ liệu từ file cơ sở dữ liệu
        MySqlDataReader reader;

        /// <summary>
        /// Trả về danh sách thông tin tất cả người chơi từ bảng dữ liệu
        /// </summary>
        /// <param name="query">Câu lệnh SQL</param>
        /// <returns></returns>
        public List<Player> ListPlayers(string query)
        {
            List<Player> players = new List<Player>();
            using(MySqlConnection sqlConnection = SqlConnector.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);  
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
            using (MySqlConnection sqlConnection = SqlConnector.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
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
            using (MySqlConnection sqlConnection = SqlConnector.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
