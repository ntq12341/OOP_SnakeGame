using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    using static PlayZone; // sử dụng các thành phần static của lớp PlayZone

    /// <summary>
    /// Con rắn trong trò chơi
    /// </summary>
    internal class MySnake : IGameObject, IAnimal
    {
        // Trạng thái của con rắn
        // 0 là đứng yên
        // 1 là sang phải
        // 2 là sang trái
        // 3 là đi lên
        // 4 là đi xuống
        int currentState;

        // Trạng thái trước đó của con rắn
        int pastState;

        // Kích thước con rắn
        public int size;

        // tốc độ con rắn
        int speed;

        /// <summary>
        /// hàm khởi tạo con rắn
        /// </summary>
        /// <param name="speedPara">tốc độ rắn</param>
        public void Init(int speedPara)
        {
            // Khởi tạo các giá trị ban đầu
            Random random = new Random();
            size = 2;
            speed = speedPara;
            pastState = 0;
            currentState = 1;

            // Khởi tạo hình dáng và vị trí con rắn lúc bắt đầu 
            int firstPositionX = random.Next(0, Map[0].Length - 1);
            int firstPositionY = random.Next(0, Map.Length - 1);
            AddSnakeAtHead(firstPositionY, firstPositionX);
            AddSnakeAtHead(firstPositionY, (firstPositionX+1)% Map[0].Length);
            MoveRight();
            
        }

        /// <summary>
        /// kiểm tra con rắn ghi điểm
        /// </summary>
        public void Score()
        {
            // nếu mục tiêu bị rắn ăn thì sẽ thay đổi vị trí sao cho nằm ngoài con rắn
            while (Snake.Contains(Target))
            {
                // tăng kích thước con rắn lên 1 đơn vị 
                increaseSize();

                // chọn 1 vị trí mới cho mục tiêu
                MoveTarget();

                // cập nhật bảng điểm
                scoreLabel.Text = $"Score:{size * 5 - 10}";
            }
        }

        /// <summary>
        /// kiểm tra con rắn chết
        /// </summary>
        public void Dead()
        {
            for (int i = 1; i < Snake.Count; i++)
            {
                if (Snake[0].Location == Snake[i].Location)
                {
                    if ((size - 2) * 5 > player.MaxScore)
                    {
                        player.UpdateMaxScore((size - 2) * 5);
                    }
                    MessageBox.Show($" Game Over!\n\nYou have {(size - 2) * 5} scores");
                    BaseForm.Hide();
                    Menu menu = new Menu(player);
                    menu.ShowDialog();
                    BaseForm.Close();
                    return;
                }
            }
        }

        /// <summary>
        /// con rắn di chuyển sang phải
        /// </summary>
        public async void MoveRight()
        {
            int j1, i1, j2, i2;
            while (currentState == 1)
            {
                j1 = Snake[0].Location.Y / 20;
                i1 = Snake[0].Location.X / 20;
                j2 = Snake[Snake.Count - 1].Location.Y / 20;
                i2 = Snake[Snake.Count - 1].Location.X / 20;
                RemoveFromSnake(j2, i2);
                AddSnakeAtHead(j1, (i1 + 1) % Map[0].Length);
                Score();
                Dead();
                await Task.Delay(50 / speed);
            }
        }

        /// <summary>
        /// con rắn di chuyển sang trái
        /// </summary>
        public async void MoveLeft()
        {
            int j1, i1, j2, i2;
            while (currentState == 2)
            {
                j1 = Snake[0].Location.Y / 20;
                i1 = Snake[0].Location.X / 20;
                j2 = Snake[Snake.Count - 1].Location.Y / 20;
                i2 = Snake[Snake.Count - 1].Location.X / 20;
                RemoveFromSnake(j2, i2);
                AddSnakeAtHead(j1, (i1 + Map[0].Length - 1) % Map[0].Length);
                Score();
                Dead();
                await Task.Delay(50 / speed);
            }
        }

        /// <summary>
        /// con rắn di chuyển lên trên
        /// </summary>
        public async void MoveUp()
        {
            int j1, i1, j2, i2;
            while (currentState == 3)
            {
                j1 = Snake[0].Location.Y / 20;
                i1 = Snake[0].Location.X / 20;
                j2 = Snake[Snake.Count - 1].Location.Y / 20;
                i2 = Snake[Snake.Count - 1].Location.X / 20;
                RemoveFromSnake(j2, i2);
                AddSnakeAtHead((j1 + Map.Length - 1) % Map.Length, i1);
                Score();
                Dead();
                await Task.Delay(50 / speed);
            }
        }

        /// <summary>
        /// con rắn di chuyển xuống dưới
        /// </summary>
        public async void MoveDown()
        {
            int j1, i1, j2, i2;
            while (currentState == 4)
            {
                j1 = Snake[0].Location.Y / 20;
                i1 = Snake[0].Location.X / 20;
                j2 = Snake[Snake.Count - 1].Location.Y / 20;
                i2 = Snake[Snake.Count - 1].Location.X / 20;
                RemoveFromSnake(j2, i2);
                AddSnakeAtHead((j1 + 1) % Map.Length, i1);
                Score();
                Dead();
                await Task.Delay(50 / speed);
            }
        }

        /// <summary>
        /// Tăng kích thước con rắn
        /// </summary>
        void increaseSize()
        {
            int i1, j1;
            j1 = Snake[0].Location.Y / 20;
            i1 = Snake[0].Location.X / 20;

            // khi con rắn đang đi sang phải
            if (currentState == 1)
            {
                AddSnakeAtHead(j1, (i1 + 1) % Map[0].Length);
            }
            // khi con rắn đang đi sang trái 
            else if (currentState == 2)
            {
                AddSnakeAtHead(j1, (i1 + Map[0].Length - 1) % Map[0].Length);
            }
            // khi con rắn đang đi lên
            else if (currentState == 3)
            {
                AddSnakeAtHead((j1 + Map.Length - 1) % Map.Length, i1);
            }
            // khi con rắn đang đi xuống
            else if (currentState == 4)
            {
                AddSnakeAtHead((j1 + 1) % Map.Length, i1);
            }

            // Tăng kích thước lên 1
            size++;
            DecorateSnake();
        }


        /// <summary>
        /// Hàm nhận sự kiện từ bàn phím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Recieve(object sender, KeyEventArgs e)
        {
            // Di chuyển sang phải
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (currentState != 1 && currentState != 2 && currentState != 0)
                {
                    currentState = 1;
                    MoveRight();
                }
            }
            // Di chuyển sang trái
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (currentState != 2 && currentState != 1 && currentState != 0)
                {
                    currentState = 2;
                    MoveLeft();
                }
            }
            // Di chuyển đi lên 
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (currentState != 3 && currentState != 4 && currentState != 0)
                {
                    currentState = 3;
                    MoveUp();
                }
            }
            // Di chuyển xuống dưới
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (currentState != 3 && currentState != 4 && currentState != 0)
                {
                    currentState = 4;
                    MoveDown();
                }
            }
            // Tạm dừng hoặc tiếp tục
            else if (e.KeyCode == Keys.Space || e.KeyCode == Keys.P)
            {
                if (currentState != 0)
                {
                    pastState = currentState;
                    currentState = 0;
                }
                else
                {
                    currentState = pastState;
                    switch (currentState)
                    {
                        case 1: MoveRight(); break;
                        case 2: MoveLeft(); break;
                        case 3: MoveUp(); break;
                        case 4: MoveDown(); break;
                    }
                }
            }
        }

    }
}
