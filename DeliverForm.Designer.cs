namespace CafeApp
{
    partial class DeliverForm
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
            OrdersList = new ComboBox();
            label1 = new Label();
            ExecuteButton = new Button();
            CancelButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.Location = new Point(27, 73);
            OrdersList.Margin = new Padding(4);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(191, 29);
            OrdersList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Заказ";
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(226, 67);
            ExecuteButton.Margin = new Padding(4);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(132, 46);
            ExecuteButton.TabIndex = 2;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(366, 67);
            CancelButton.Margin = new Padding(4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(125, 46);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(226, 136);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(132, 32);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DeliverForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(527, 220);
            Controls.Add(ExitButton);
            Controls.Add(CancelButton);
            Controls.Add(ExecuteButton);
            Controls.Add(label1);
            Controls.Add(OrdersList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DeliverForm";
            Text = "DeliverForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox OrdersList;
        private Label label1;
        private Button ExecuteButton;
        private Button CancelButton;
        private Button ExitButton;
    }
}