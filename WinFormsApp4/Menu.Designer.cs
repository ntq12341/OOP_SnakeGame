namespace WinFormsApp4
{
    partial class Menu
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
            button_level1 = new Button();
            button_level2 = new Button();
            button_level3 = new Button();
            Button_quit = new Button();
            button_logOut = new Button();
            button_highScore = new Button();
            SuspendLayout();
            // 
            // button_level1
            // 
            button_level1.Location = new Point(216, 57);
            button_level1.Name = "button_level1";
            button_level1.Size = new Size(112, 34);
            button_level1.TabIndex = 0;
            button_level1.Text = "Level 1";
            button_level1.UseVisualStyleBackColor = true;
            button_level1.Click += button_level1_Click;
            // 
            // button_level2
            // 
            button_level2.Location = new Point(216, 116);
            button_level2.Name = "button_level2";
            button_level2.Size = new Size(112, 34);
            button_level2.TabIndex = 1;
            button_level2.Text = "Level 2";
            button_level2.UseVisualStyleBackColor = true;
            button_level2.Click += button_level2_Click;
            // 
            // button_level3
            // 
            button_level3.Location = new Point(216, 188);
            button_level3.Name = "button_level3";
            button_level3.Size = new Size(112, 34);
            button_level3.TabIndex = 2;
            button_level3.Text = "Level 3";
            button_level3.UseVisualStyleBackColor = true;
            button_level3.Click += button_level3_Click;
            // 
            // Button_quit
            // 
            Button_quit.Location = new Point(216, 398);
            Button_quit.Name = "Button_quit";
            Button_quit.Size = new Size(112, 38);
            Button_quit.TabIndex = 3;
            Button_quit.Text = "Quit";
            Button_quit.UseVisualStyleBackColor = true;
            Button_quit.Click += Button_quit_Click;
            // 
            // button_logOut
            // 
            button_logOut.Location = new Point(216, 326);
            button_logOut.Name = "button_logOut";
            button_logOut.Size = new Size(112, 40);
            button_logOut.TabIndex = 4;
            button_logOut.Text = "Log Out";
            button_logOut.UseVisualStyleBackColor = true;
            button_logOut.Click += button_logOut_Click;
            // 
            // button_highScore
            // 
            button_highScore.Location = new Point(216, 257);
            button_highScore.Name = "button_highScore";
            button_highScore.Size = new Size(112, 40);
            button_highScore.TabIndex = 5;
            button_highScore.Text = "High Score";
            button_highScore.UseVisualStyleBackColor = true;
            button_highScore.Click += button_highScore_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(565, 484);
            Controls.Add(button_highScore);
            Controls.Add(button_logOut);
            Controls.Add(Button_quit);
            Controls.Add(button_level3);
            Controls.Add(button_level2);
            Controls.Add(button_level1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            KeyPreview = false;
            ResumeLayout(false);
        }

        #endregion

        private Button button_level1;
        private Button button_level2;
        private Button button_level3;
        private Button Button_quit;
        private Button button_logOut;
        private Button button_highScore;
    }
}