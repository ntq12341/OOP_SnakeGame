
namespace WinFormsApp3
{
    partial class SnakeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_playZone = new Panel();
            label_score = new Label();
            label_maxScore = new Label();
            label_player = new Label();
            label_exit = new Label();
            SuspendLayout();
            // 
            // panel_playZone
            // 
            panel_playZone.BorderStyle = BorderStyle.FixedSingle;
            panel_playZone.Location = new Point(12, 46);
            panel_playZone.Name = "panel_playZone";
            panel_playZone.Size = new Size(760, 680);
            panel_playZone.TabIndex = 0;
            // 
            // label_score
            // 
            label_score.BorderStyle = BorderStyle.FixedSingle;
            label_score.Location = new Point(12, 10);
            label_score.Name = "label_score";
            label_score.Size = new Size(100, 30);
            label_score.TabIndex = 1;
            label_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_maxScore
            // 
            label_maxScore.BorderStyle = BorderStyle.FixedSingle;
            label_maxScore.Location = new Point(464, 10);
            label_maxScore.Name = "label_maxScore";
            label_maxScore.Size = new Size(136, 30);
            label_maxScore.TabIndex = 2;
            label_maxScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_player
            // 
            label_player.BorderStyle = BorderStyle.FixedSingle;
            label_player.Location = new Point(130, 10);
            label_player.Name = "label_player";
            label_player.Size = new Size(312, 30);
            label_player.TabIndex = 3;
            label_player.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_exit
            // 
            label_exit.BorderStyle = BorderStyle.FixedSingle;
            label_exit.Location = new Point(642, 9);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(80, 31);
            label_exit.TabIndex = 4;
            label_exit.Text = "Exit";
            label_exit.TextAlign = ContentAlignment.MiddleCenter;
            label_exit.Click += button_exit_Click;
            // 
            // SnakeGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 735);
            Controls.Add(label_exit);
            Controls.Add(label_player);
            Controls.Add(label_maxScore);
            Controls.Add(label_score);
            Controls.Add(panel_playZone);
            KeyPreview = true;
            Name = "SnakeGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SnakeGame";
            ResumeLayout(false);
        }

        void F1()
        {
            label_score.Text = $"Score:{0}";
            label_maxScore.Text = $"Max Score:{player1.MaxScore}";
            label_player.Text = $"Player : {player1.Name}";
            KeyUp += mySnake.Recieve;
        }

        #endregion
        private Panel panel_playZone;
        private Label label_score;
        private Label label_maxScore;
        private Label label_player;
        private Label label_exit;
    }
}