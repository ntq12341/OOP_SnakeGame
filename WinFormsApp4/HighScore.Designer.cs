namespace WinFormsApp4
{
    partial class HighScore
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
            listView_highScore = new ListView();
            label_exit = new Label();
            SuspendLayout();
            // 
            // listView_highScore
            // 
            listView_highScore.Location = new Point(12, 72);
            listView_highScore.Name = "listView_highScore";
            listView_highScore.Size = new Size(500, 400);
            listView_highScore.TabIndex = 0;
            listView_highScore.UseCompatibleStateImageBehavior = false;
            // 
            // label_exit
            // 
            label_exit.BorderStyle = BorderStyle.FixedSingle;
            label_exit.Location = new Point(362, 17);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(121, 36);
            label_exit.TabIndex = 1;
            label_exit.Text = "Exit";
            label_exit.TextAlign = ContentAlignment.MiddleCenter;
            label_exit.Click += label_exit_Click;
            // 
            // HighScore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 485);
            Controls.Add(label_exit);
            Controls.Add(listView_highScore);
            Name = "HighScore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "High Score";
            KeyPreview = false;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_highScore;
        private Label label_exit;
    }
}