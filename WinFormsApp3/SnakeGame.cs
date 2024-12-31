using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class SnakeGame : Form
    {
        public Player player1;
        MySnake mySnake = new MySnake();

        public SnakeGame()
        {
            player1 = new Player(); 
            InitializeComponent();
            PlayZone.BaseForm = this;
            PlayZone.BasePanel = this.panel_playZone;
            PlayZone.scoreLabel = this.label_score;
            PlayZone.player = player1;
            PlayZone.CreatePlayZone();
            mySnake.Init(2);
            F1();
        }
        public SnakeGame(Player player, int level)
        {
            player1 = player;
            InitializeComponent();
            PlayZone.BaseForm = this;
            PlayZone.BasePanel = this.panel_playZone;
            PlayZone.scoreLabel = this.label_score;
            PlayZone.player = player1;
            PlayZone.CreatePlayZone();
            mySnake.Init(level);
            F1();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(player1);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
