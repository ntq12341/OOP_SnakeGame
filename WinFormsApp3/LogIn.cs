namespace WinFormsApp3
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sự kiện click vào button Log In
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhập vào
            string account = textBox_Name.Text;
            string password = textBox_Password.Text;

            Modify modify = new Modify();

            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            // Truy vấn tất cả người chơi để tìm theo tên và mật khẩu
            string query = $"SELECT * FROM AccountInfor WHERE Account = '{account}' AND Password = '{password}'";
            if(modify.ListPlayers(query).Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");

                // Người chơi đăng nhập thành công và hiện menu
                Player p1 = modify.ListPlayers(query)[0];
                Menu menu = new Menu(p1);

                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
            }
        }

        /// <summary>
        /// Sự kiện click vào button Sign Up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
