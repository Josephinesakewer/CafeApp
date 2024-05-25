namespace CafeApp
{
    partial class AuthForm
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
            label1 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ExitButton = new Button();
            buttonReg = new Button();
            buttonInput = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(123, 38);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(241, 29);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(123, 84);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(241, 29);
            textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(ExitButton);
            groupBox1.Controls.Add(buttonReg);
            groupBox1.Controls.Add(buttonInput);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 225);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(415, 60);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 37);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(158, 131);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(268, 49);
            buttonReg.TabIndex = 5;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // buttonInput
            // 
            buttonInput.Location = new Point(6, 131);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(132, 49);
            buttonInput.TabIndex = 4;
            buttonInput.Text = "Войти";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(609, 249);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "AuthForm";
            Text = "Форма аутентификации";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private GroupBox groupBox1;
        private Button buttonReg;
        private Button buttonInput;
        private Button ExitButton;
    }
}
