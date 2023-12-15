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
            SuspendLayout();
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.Location = new Point(37, 69);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(140, 28);
            OrdersList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "Заказ";
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(253, 69);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(96, 33);
            ExecuteButton.TabIndex = 2;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(396, 69);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(91, 33);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DeliverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 174);
            Controls.Add(CancelButton);
            Controls.Add(ExecuteButton);
            Controls.Add(label1);
            Controls.Add(OrdersList);
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
    }
}