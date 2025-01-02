using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        // Các đối tượng phục vụ cho truy vấn
        Modify modify = new Modify();
        List<Player> players;
        string query;

        /// <summary>
        /// Sự kiện khi nhấn vào button Sign Up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            // Nhạn thông tin nhập vào
            string account = textBox_Name.Text;
            string password = textBox_Password.Text;

            if (string.IsNullOrEmpty(account) )
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
           
            // Kiểm tra tài khoản đã có chưa
            query = $"SELECT * FROM AccountInfor WHERE Account = '{account}'";
            players = modify.ListPlayers(query);
            if (players.Count > 0 )
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }

            // Thêm thông tin người chơi vào bảng dữ liệu
            query = $"INSERT INTO AccountInfor (Account,Password,MaxScore) VALUES ('{account}','{password}',0)";
            modify.Command(query);
            MessageBox.Show("Đăng ký thành công");
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }
    }
}
