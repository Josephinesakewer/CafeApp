namespace CafeApp
{
    partial class CookerForm
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
            SuspendLayout();
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.Location = new Point(25, 76);
            OrdersList.Margin = new Padding(4, 4, 4, 4);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(206, 36);
            OrdersList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 1;
            label1.Text = "Заказ";
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(258, 73);
            ExecuteButton.Margin = new Padding(4, 4, 4, 4);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(139, 41);
            ExecuteButton.TabIndex = 2;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(405, 73);
            CancelButton.Margin = new Padding(4, 4, 4, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(129, 41);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CookerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 151);
            Controls.Add(CancelButton);
            Controls.Add(ExecuteButton);
            Controls.Add(label1);
            Controls.Add(OrdersList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CookerForm";
            Text = "CookerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox OrdersList;
        private Label label1;
        private Button ExecuteButton;
        private Button CancelButton;
    }
}