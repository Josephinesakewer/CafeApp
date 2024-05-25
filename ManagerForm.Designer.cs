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
            deliverList = new ComboBox();
            label3 = new Label();
            CookerList = new ComboBox();
            textBoxStatus = new TextBox();
            label4 = new Label();
            ChooseDeliveryButton = new Button();
            ChooseCookerButton = new Button();
            СancelDeliveryButton = new Button();
            CancelCookerButton = new Button();
            CloseButton = new Button();
            UpdateButton = new Button();
            label5 = new Label();
            textBoxDeliver = new TextBox();
            label6 = new Label();
            textBoxCooker = new TextBox();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Заказы";
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.Location = new Point(24, 30);
            OrdersList.Margin = new Padding(3, 2, 3, 2);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(133, 23);
            OrdersList.TabIndex = 1;
            OrdersList.SelectedIndexChanged += OrdersList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Доставщик";
            // 
            // deliverList
            // 
            deliverList.FormattingEnabled = true;
            deliverList.Location = new Point(24, 88);
            deliverList.Margin = new Padding(3, 2, 3, 2);
            deliverList.Name = "deliverList";
            deliverList.Size = new Size(133, 23);
            deliverList.TabIndex = 3;
            deliverList.SelectedIndexChanged += deliveryman_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 121);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Повар";
            // 
            // CookerList
            // 
            CookerList.FormattingEnabled = true;
            CookerList.Location = new Point(24, 138);
            CookerList.Margin = new Padding(3, 2, 3, 2);
            CookerList.Name = "CookerList";
            CookerList.Size = new Size(133, 23);
            CookerList.TabIndex = 5;
            CookerList.SelectedIndexChanged += Cooker_SelectedIndexChanged;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(193, 30);
            textBoxStatus.Margin = new Padding(3, 2, 3, 2);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(110, 23);
            textBoxStatus.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 13);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 7;
            label4.Text = "Статус заказа";
            // 
            // ChooseDeliveryButton
            // 
            ChooseDeliveryButton.Location = new Point(349, 89);
            ChooseDeliveryButton.Margin = new Padding(3, 2, 3, 2);
            ChooseDeliveryButton.Name = "ChooseDeliveryButton";
            ChooseDeliveryButton.Size = new Size(88, 22);
            ChooseDeliveryButton.TabIndex = 8;
            ChooseDeliveryButton.Text = "Выбрать";
            ChooseDeliveryButton.UseVisualStyleBackColor = true;
            ChooseDeliveryButton.Click += ChooseDeliveryButton_Click;
            // 
            // ChooseCookerButton
            // 
            ChooseCookerButton.Location = new Point(349, 137);
            ChooseCookerButton.Margin = new Padding(3, 2, 3, 2);
            ChooseCookerButton.Name = "ChooseCookerButton";
            ChooseCookerButton.Size = new Size(82, 22);
            ChooseCookerButton.TabIndex = 9;
            ChooseCookerButton.Text = "Выбрать";
            ChooseCookerButton.UseVisualStyleBackColor = true;
            ChooseCookerButton.Click += ChooseCookerButton_Click;
            // 
            // СancelDeliveryButton
            // 
            СancelDeliveryButton.Location = new Point(488, 87);
            СancelDeliveryButton.Margin = new Padding(3, 2, 3, 2);
            СancelDeliveryButton.Name = "СancelDeliveryButton";
            СancelDeliveryButton.Size = new Size(82, 22);
            СancelDeliveryButton.TabIndex = 10;
            СancelDeliveryButton.Text = "Отменить";
            СancelDeliveryButton.UseVisualStyleBackColor = true;
            СancelDeliveryButton.Click += СancelDeliveryButton_Click;
            // 
            // CancelCookerButton
            // 
            CancelCookerButton.Location = new Point(488, 137);
            CancelCookerButton.Margin = new Padding(3, 2, 3, 2);
            CancelCookerButton.Name = "CancelCookerButton";
            CancelCookerButton.Size = new Size(82, 22);
            CancelCookerButton.TabIndex = 11;
            CancelCookerButton.Text = "Отменить";
            CancelCookerButton.UseVisualStyleBackColor = true;
            CancelCookerButton.Click += CancelCookerButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(417, 42);
            CloseButton.Margin = new Padding(3, 2, 3, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(99, 22);
            CloseButton.TabIndex = 12;
            CloseButton.Text = "Закрыть заказ";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(349, 5);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(107, 22);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Обновить заказ";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 70);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 15;
            label5.Text = "Выбранный доставщик";
            // 
            // textBoxDeliver
            // 
            textBoxDeliver.Location = new Point(193, 88);
            textBoxDeliver.Margin = new Padding(3, 2, 3, 2);
            textBoxDeliver.Name = "textBoxDeliver";
            textBoxDeliver.Size = new Size(110, 23);
            textBoxDeliver.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 121);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 17;
            label6.Text = "Выбранный повар";
            // 
            // textBoxCooker
            // 
            textBoxCooker.Location = new Point(194, 138);
            textBoxCooker.Margin = new Padding(3, 2, 3, 2);
            textBoxCooker.Name = "textBoxCooker";
            textBoxCooker.Size = new Size(110, 23);
            textBoxCooker.TabIndex = 16;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(488, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(594, 195);
            Controls.Add(ExitButton);
            Controls.Add(label6);
            Controls.Add(textBoxCooker);
            Controls.Add(label5);
            Controls.Add(textBoxDeliver);
            Controls.Add(UpdateButton);
            Controls.Add(CloseButton);
            Controls.Add(CancelCookerButton);
            Controls.Add(СancelDeliveryButton);
            Controls.Add(ChooseCookerButton);
            Controls.Add(ChooseDeliveryButton);
            Controls.Add(label4);
            Controls.Add(textBoxStatus);
            Controls.Add(CookerList);
            Controls.Add(label3);
            Controls.Add(deliverList);
            Controls.Add(label2);
            Controls.Add(OrdersList);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox OrdersList;
        private Label label2;
        private ComboBox deliverList;
        private Label label3;
        private ComboBox CookerList;
        private TextBox textBoxStatus;
        private Label label4;
        private Button ChooseDeliveryButton;
        private Button ChooseCookerButton;
        private Button СancelDeliveryButton;
        private Button CancelCookerButton;
        private Button CloseButton;
        private Button UpdateButton;
        private Label label5;
        private TextBox textBoxDeliver;
        private Label label6;
        private TextBox textBoxCooker;
        private Button ExitButton;
    }
}