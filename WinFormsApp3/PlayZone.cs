using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    /// <summary>
    /// Lớp static chứa các thành phần trong vùng chơi game
    /// </summary>
    internal static class PlayZone
    {
        // form nền
        public static SnakeGame BaseForm;

        // người chơi
        public static Player player;

        // bảng điểm
        public static Label scoreLabel;

        // panel nền
        public static Panel BasePanel;

        // khu vực con rắn di chuyển
        public static Label[][] Map;

        // con rắn
        public static List<Label> Snake;

        // ô làm mục tiêu
        public static Label Target;

        public static void CreatePlayZone()
        {
            // Khởi tạo khu vực di chuyển của con rắn
            var size1 = BasePanel.Size.Width ;// chiều rộng của panel
            var size2 = BasePanel.Size.Height; // chiều rộng của panel
            
            Map = new Label[size2 / 20][]; // tạo 1 ma trận
            for (int j = 0; j < Map.Length; j++)
            {
                // khởi tạo mỗi ô của ma trận
                Map[j] = new Label[size1 / 20];
                for (int i = 0; i < Map[0].Length; i++)
                {
                    Map[j][i] = new Label();
                    Map[j][i].Location = new Point(i * 20, j * 20);
                    Map[j][i].Name = $"{j}-{i}";
                    Map[j][i].Size = new Size(20, 20);
                    Map[j][i].TabIndex = i + j * Map.Length;
                    Map[j][i].BackColor = Color.LightBlue;
                    Map[j][i].BorderStyle = BorderStyle.None;
                }
            }

            // khởi tạo con rắn
            Snake = new List<Label>();  

            // thêm các ô của ma trận vào panel
            for (int j = 0; j < Map.Length; j++)
            {
                for (int i = 0; i < Map[j].Length; i++)
                {
                    BasePanel.Controls.Add(Map[j][i]);
                }
            }


            // Khởi tạo mục tiêu
            Random random = new Random();
            int t1 = random.Next(0, Map.Length - 1);
            int t2 = random.Next(0, Map[0].Length - 1);
            Target = Map[t1][t2];
            Target.BackColor = Color.Gray;
        }

        /// <summary>
        /// Hàm vẽ con rắn
        /// </summary>
        public static void DecorateSnake()
        {
            for (int i = 0; i < Snake.Count; i++)
            {
                // Đầu rắn cần có màu khác so với phần còn lại để phân biệt
                if (i == 0)
                {
                    Snake[i].BackColor = Color.White;
                }
                else
                {
                    Snake[i].BackColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Thêm 1 ô vào cuối con rắn
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="i1"></param>
        public static void AddSnakeAtTail(int j1, int i1)
        {
            Snake.Add(Map[j1][i1]);
            Map[j1][i1].BackColor = Color.Black;
            DecorateSnake();
        }

        /// <summary>
        /// Thêm 1 ô vào đầu con rắn
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="i1"></param>
        public static void AddSnakeAtHead(int j1, int i1)
        {
            Snake.Add(Map[j1][i1]);
            Map[j1][i1].BackColor = Color.Black;
            List<Label> l1 = new List<Label>(Snake);
            for (int i = 0; i < Snake.Count; i++)
            {
                Snake[i] = l1[(i + Snake.Count - 1) % Snake.Count];
            }
            DecorateSnake();
        }

        /// <summary>
        /// Xóa 1 ô khỏi con rắn
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="i1"></param>
        public static void RemoveFromSnake(int j1, int i1)
        {
            Snake.Remove(Map[j1][i1]);
            Map[j1][i1].BackColor = Color.LightBlue;
        }

        /// <summary>
        /// Hàm thay đổi mục tiêu khi bị ăn trúng
        /// </summary>
        public static void MoveTarget()
        {
            int ti = Target.Location.X/20;
            int tj = Target.Location.Y/20;
            Map[tj][ti].BackColor = Color.LightBlue;
            Random random = new Random();
            ti = random.Next(0, Map[0].Length -1);
            tj = random.Next(0, Map.Length-1);
            Target = Map[tj][ti];
            Target.BackColor = Color.Gray;
        }

    }
}
