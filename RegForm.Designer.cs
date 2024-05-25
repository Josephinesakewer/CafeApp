namespace CafeApp
{
    partial class RegForm
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
            groupBox1 = new GroupBox();
            Exit_Button = new Button();
            textBoxAddress = new TextBox();
            label5 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            buttonReg = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Exit_Button);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonReg);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(497, 313);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(304, 239);
            Exit_Button.Margin = new Padding(4);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(167, 47);
            Exit_Button.TabIndex = 12;
            Exit_Button.Text = "Выход";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(131, 191);
            textBoxAddress.Margin = new Padding(4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(330, 29);
            textBoxAddress.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 191);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 10;
            label5.Text = "Адрес";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(131, 149);
            textBoxPhone.Margin = new Padding(4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(330, 29);
            textBoxPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 149);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 8;
            label4.Text = "Телефон";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(131, 23);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(330, 29);
            textBoxName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 26);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 6;
            label3.Text = "Имя";
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(18, 239);
            buttonReg.Margin = new Padding(4);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(278, 47);
            buttonReg.TabIndex = 5;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(131, 65);
            textBoxLogin.Margin = new Padding(4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(330, 29);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(131, 107);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(330, 29);
            textBoxPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 68);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 107);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(539, 344);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegForm";
            Text = "RegForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonReg;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private TextBox textBoxAddress;
        private Label label5;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxName;
        private Label label3;
        private Button Exit_Button;
    }
}