using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3;

namespace WinFormsApp3
{
    /// <summary>
    /// Người chơi 
    /// </summary>
    public class Player
    {
        string _name; // tên tài khoản
        string _password; // mật khẩu
        int _maxScore; // điểm số cao nhất

        public Player()
        {
            _name = "admim";
            _password = "";
            _maxScore = 0;
        }

        public Player(string name, string password)
        {
            _name = name;
            _password = password;
            _maxScore = 0;  
        }

        public Player(string name, string password, int maxScore)
        {
            _name = name;
            _password = password;
            _maxScore = maxScore;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int MaxScore
        {
            get { return _maxScore; }
            set { _maxScore = value; }
        }
        /// <summary>
        /// Cập nhật điểm cao nhất
        /// </summary>
        /// <param name="maxScore">Điểm cao nhất mới</param>
        public void UpdateMaxScore(int maxScore)
        {
            _maxScore = maxScore;
            Modify.Command($"UPDATE AccountInfor SET MaxScore = {_maxScore} WHERE Account = '{_name}'");
        }

    }
}