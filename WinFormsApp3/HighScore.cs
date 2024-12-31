using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class HighScore : Form
    {
        // người chơi
        Player player1;

        public HighScore(Player player)
        {
            InitializeComponent();
            LoadHighScores();
            this.player1 = player;
        }

        /// <summary>
        /// Hàm tạo danh sách top người chơi điểm cao nhất
        /// </summary>
        void LoadHighScores()
        {
            // thực hiện câu lệnh truy vấn SQL
            Modify modify = new Modify();
            string query = "SELECT TOP 10 Account,MaxScore FROM AccountInfor ORDER BY MaxScore DESC";

            // danh sách top người chơi khi thực hiện truy vấn
            var highScores = modify.TopPlayers(query);

            // Thêm những người chơi vào danh sách
            listView_highScore.Columns.Add("Player", 300);
            listView_highScore.Columns.Add("Max Score", 150);
            foreach (var player in highScores)
            {
                var item = new ListViewItem(player.Name);
                item.SubItems.Add(player.MaxScore.ToString());
                listView_highScore.Items.Add(item);
            }

            // Thêm danh sách vào form
            listView_highScore.View = View.Details;
            Controls.Add(listView_highScore);
        }

        /// <summary>
        /// Sự kiện nhấn vào button Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(player1);
            menu.ShowDialog();  
            this.Close();
        }
    }
}
