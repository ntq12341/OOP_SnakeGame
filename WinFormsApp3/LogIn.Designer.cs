namespace WinFormsApp3
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Name = new TextBox();
            textBox_Password = new TextBox();
            label_Name = new Label();
            label_Password = new Label();
            button_LogIn = new Button();
            button_SignUp = new Button();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(188, 59);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(326, 31);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(188, 131);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(326, 31);
            textBox_Password.TabIndex = 1;
            textBox_Password.PasswordChar = '*';
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(51, 62);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(59, 25);
            label_Name.TabIndex = 2;
            label_Name.Text = "Name";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(51, 134);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(87, 25);
            label_Password.TabIndex = 3;
            label_Password.Text = "Password";
            // 
            // button_LogIn
            // 
            button_LogIn.AutoSize = true;
            button_LogIn.Location = new Point(258, 201);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(137, 41);
            button_LogIn.TabIndex = 4;
            button_LogIn.Text = "Log In";
            button_LogIn.UseVisualStyleBackColor = true;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // button_SignUp
            // 
            button_SignUp.AutoSize = true;
            button_SignUp.Location = new Point(258, 273);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new Size(137, 39);
            button_SignUp.TabIndex = 5;
            button_SignUp.Text = "Sign Up";
            button_SignUp.UseVisualStyleBackColor = true;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(607, 358);
            Controls.Add(button_SignUp);
            Controls.Add(button_LogIn);
            Controls.Add(label_Password);
            Controls.Add(label_Name);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Name);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyPreview = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Password;
        private Label label_Name;
        private Label label_Password;
        private Button button_LogIn;
        private Button button_SignUp;
    }
}
