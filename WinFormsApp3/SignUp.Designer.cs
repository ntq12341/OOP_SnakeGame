namespace WinFormsApp3
{
    partial class SignUp
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
            textBox_Name = new TextBox();
            textBox_Password = new TextBox();
            label_Name = new Label();
            label_Password = new Label();
            button_SignUp = new Button();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(190, 80);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(315, 31);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(188, 159);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(317, 31);
            textBox_Password.TabIndex = 1;
            textBox_Password.PasswordChar = '*';
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(55, 86);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(59, 25);
            label_Name.TabIndex = 2;
            label_Name.Text = "Name";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(54, 162);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(87, 25);
            label_Password.TabIndex = 3;
            label_Password.Text = "Password";
            // 
            // button_SignUp
            // 
            button_SignUp.Location = new Point(254, 244);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new Size(112, 34);
            button_SignUp.TabIndex = 4;
            button_SignUp.Text = "Sign Up";
            button_SignUp.UseVisualStyleBackColor = true;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 358);
            Controls.Add(button_SignUp);
            Controls.Add(label_Password);
            Controls.Add(label_Name);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Name);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            KeyPreview = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Password;
        private Label label_Name;
        private Label label_Password;
        private Button button_SignUp;
    }
}