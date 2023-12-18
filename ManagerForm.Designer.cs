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
            OrdersList.SelectedIndexChanged += OrdersList_SelectedIndexChanged;
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
            // deliverList
            // 
            deliverList.FormattingEnabled = true;
            deliverList.Location = new Point(28, 117);
            deliverList.Name = "deliverList";
            deliverList.Size = new Size(151, 28);
            deliverList.TabIndex = 3;
            deliverList.SelectedIndexChanged += deliveryman_SelectedIndexChanged;
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
            // CookerList
            // 
            CookerList.FormattingEnabled = true;
            CookerList.Location = new Point(28, 198);
            CookerList.Name = "CookerList";
            CookerList.Size = new Size(151, 28);
            CookerList.TabIndex = 5;
            CookerList.SelectedIndexChanged += Cooker_SelectedIndexChanged;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(237, 49);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(125, 27);
            textBoxStatus.TabIndex = 6;
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
            ChooseDeliveryButton.Location = new Point(427, 117);
            ChooseDeliveryButton.Name = "ChooseDeliveryButton";
            ChooseDeliveryButton.Size = new Size(101, 29);
            ChooseDeliveryButton.TabIndex = 8;
            ChooseDeliveryButton.Text = "Выбрать";
            ChooseDeliveryButton.UseVisualStyleBackColor = true;
            ChooseDeliveryButton.Click += ChooseDeliveryButton_Click;
            // 
            // ChooseCookerButton
            // 
            ChooseCookerButton.Location = new Point(427, 197);
            ChooseCookerButton.Name = "ChooseCookerButton";
            ChooseCookerButton.Size = new Size(94, 29);
            ChooseCookerButton.TabIndex = 9;
            ChooseCookerButton.Text = "Выбрать";
            ChooseCookerButton.UseVisualStyleBackColor = true;
            ChooseCookerButton.Click += ChooseCookerButton_Click;
            // 
            // СancelDeliveryButton
            // 
            СancelDeliveryButton.Location = new Point(558, 118);
            СancelDeliveryButton.Name = "СancelDeliveryButton";
            СancelDeliveryButton.Size = new Size(94, 29);
            СancelDeliveryButton.TabIndex = 10;
            СancelDeliveryButton.Text = "Отменить";
            СancelDeliveryButton.UseVisualStyleBackColor = true;
            СancelDeliveryButton.Click += СancelDeliveryButton_Click;
            // 
            // CancelCookerButton
            // 
            CancelCookerButton.Location = new Point(558, 197);
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
            UpdateButton.Location = new Point(573, 12);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Обновить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 94);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 15;
            label5.Text = "Выбранный доставщик";
            // 
            // textBoxDeliver
            // 
            textBoxDeliver.Location = new Point(237, 118);
            textBoxDeliver.Name = "textBoxDeliver";
            textBoxDeliver.Size = new Size(125, 27);
            textBoxDeliver.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 175);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 17;
            label6.Text = "Выбранный повар";
            // 
            // textBoxCooker
            // 
            textBoxCooker.Location = new Point(237, 199);
            textBoxCooker.Name = "textBoxCooker";
            textBoxCooker.Size = new Size(125, 27);
            textBoxCooker.TabIndex = 16;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 260);
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
    }
}