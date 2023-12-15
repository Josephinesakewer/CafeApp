namespace CafeApp
{
    partial class ManagerForm
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
            label1 = new Label();
            OrdersList = new ComboBox();
            label2 = new Label();
            deliveryman = new ComboBox();
            label3 = new Label();
            Cooker = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            ChooseDeliveryButton = new Button();
            ChooseCookerButton = new Button();
            СancelDeliveryButton = new Button();
            CancelCookerButton = new Button();
            CloseButton = new Button();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Заказы";
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.Location = new Point(28, 48);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(151, 28);
            OrdersList.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 94);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Доставщик";
            // 
            // deliveryman
            // 
            deliveryman.FormattingEnabled = true;
            deliveryman.Location = new Point(28, 117);
            deliveryman.Name = "deliveryman";
            deliveryman.Size = new Size(151, 28);
            deliveryman.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 175);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Повар";
            // 
            // Cooker
            // 
            Cooker.FormattingEnabled = true;
            Cooker.Location = new Point(28, 198);
            Cooker.Name = "Cooker";
            Cooker.Size = new Size(151, 28);
            Cooker.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 25);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 7;
            label4.Text = "Статус заказа";
            // 
            // ChooseDeliveryButton
            // 
            ChooseDeliveryButton.Location = new Point(250, 116);
            ChooseDeliveryButton.Name = "ChooseDeliveryButton";
            ChooseDeliveryButton.Size = new Size(101, 29);
            ChooseDeliveryButton.TabIndex = 8;
            ChooseDeliveryButton.Text = "Выбрать";
            ChooseDeliveryButton.UseVisualStyleBackColor = true;
            ChooseDeliveryButton.Click += ChooseDeliveryButton_Click;
            // 
            // ChooseCookerButton
            // 
            ChooseCookerButton.Location = new Point(257, 198);
            ChooseCookerButton.Name = "ChooseCookerButton";
            ChooseCookerButton.Size = new Size(94, 29);
            ChooseCookerButton.TabIndex = 9;
            ChooseCookerButton.Text = "Выбрать";
            ChooseCookerButton.UseVisualStyleBackColor = true;
            ChooseCookerButton.Click += ChooseCookerButton_Click;
            // 
            // СancelDeliveryButton
            // 
            СancelDeliveryButton.Location = new Point(427, 116);
            СancelDeliveryButton.Name = "СancelDeliveryButton";
            СancelDeliveryButton.Size = new Size(94, 29);
            СancelDeliveryButton.TabIndex = 10;
            СancelDeliveryButton.Text = "Отменить";
            СancelDeliveryButton.UseVisualStyleBackColor = true;
            СancelDeliveryButton.Click += СancelDeliveryButton_Click;
            // 
            // CancelCookerButton
            // 
            CancelCookerButton.Location = new Point(427, 197);
            CancelCookerButton.Name = "CancelCookerButton";
            CancelCookerButton.Size = new Size(94, 29);
            CancelCookerButton.TabIndex = 11;
            CancelCookerButton.Text = "Отменить";
            CancelCookerButton.UseVisualStyleBackColor = true;
            CancelCookerButton.Click += CancelCookerButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(427, 47);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 12;
            CloseButton.Text = "Закрыть ";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(561, 116);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Обновить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 260);
            Controls.Add(UpdateButton);
            Controls.Add(CloseButton);
            Controls.Add(CancelCookerButton);
            Controls.Add(СancelDeliveryButton);
            Controls.Add(ChooseCookerButton);
            Controls.Add(ChooseDeliveryButton);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(Cooker);
            Controls.Add(label3);
            Controls.Add(deliveryman);
            Controls.Add(label2);
            Controls.Add(OrdersList);
            Controls.Add(label1);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox OrdersList;
        private Label label2;
        private ComboBox deliveryman;
        private Label label3;
        private ComboBox Cooker;
        private TextBox textBox1;
        private Label label4;
        private Button ChooseDeliveryButton;
        private Button ChooseCookerButton;
        private Button СancelDeliveryButton;
        private Button CancelCookerButton;
        private Button CloseButton;
        private Button UpdateButton;
    }
}