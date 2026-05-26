namespace EBK_EXAM_C_26
{
    partial class LoginForm
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
            button1 = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(87, 233);
            button1.Name = "button1";
            button1.Size = new Size(187, 34);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(43, 121);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(269, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(43, 177);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(269, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(141, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 37);
            label1.TabIndex = 3;
            label1.Text = "Вход";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(43, 97);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 4;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(43, 153);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // Логин
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 315);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(button1);
            Name = "Логин";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
