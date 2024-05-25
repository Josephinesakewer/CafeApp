namespace CafeApp
{
    partial class ClientForm
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
            labelClientWelcome = new Label();
            DishBox = new ComboBox();
            Блюда = new Label();
            CountDish = new NumericUpDown();
            label1 = new Label();
            TotalSum = new Label();
            AddDish = new Button();
            OrderButton = new Button();
            ClearButton = new Button();
            dataGridViewDishes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ExitButton = new Button();
            StatusOrder = new Label();
            ((System.ComponentModel.ISupportInitialize)CountDish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishes).BeginInit();
            SuspendLayout();
            // 
            // labelClientWelcome
            // 
            labelClientWelcome.AutoSize = true;
            labelClientWelcome.Location = new Point(13, 9);
            labelClientWelcome.Margin = new Padding(4, 0, 4, 0);
            labelClientWelcome.Name = "labelClientWelcome";
            labelClientWelcome.Size = new Size(62, 21);
            labelClientWelcome.TabIndex = 0;
            labelClientWelcome.Text = "Привет";
            // 
            // DishBox
            // 
            DishBox.FormattingEnabled = true;
            DishBox.Location = new Point(12, 81);
            DishBox.Name = "DishBox";
            DishBox.Size = new Size(151, 29);
            DishBox.TabIndex = 1;
            DishBox.SelectedIndexChanged += DishBox_SelectedIndexChanged;
            // 
            // Блюда
            // 
            Блюда.AutoSize = true;
            Блюда.Location = new Point(55, 49);
            Блюда.Name = "Блюда";
            Блюда.Size = new Size(57, 21);
            Блюда.TabIndex = 2;
            Блюда.Text = "Блюда";
            // 
            // CountDish
            // 
            CountDish.Location = new Point(186, 80);
            CountDish.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CountDish.Name = "CountDish";
            CountDish.Size = new Size(180, 29);
            CountDish.TabIndex = 3;
            CountDish.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 49);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 4;
            label1.Text = "Количество блюд ";
            // 
            // TotalSum
            // 
            TotalSum.AutoSize = true;
            TotalSum.Location = new Point(279, 9);
            TotalSum.Name = "TotalSum";
            TotalSum.Size = new Size(87, 21);
            TotalSum.TabIndex = 5;
            TotalSum.Text = "Стоимость";
            TotalSum.Click += TotalSum_Click;
            // 
            // AddDish
            // 
            AddDish.Location = new Point(402, 58);
            AddDish.Name = "AddDish";
            AddDish.Size = new Size(131, 53);
            AddDish.TabIndex = 7;
            AddDish.Text = "Добавить ";
            AddDish.UseVisualStyleBackColor = true;
            AddDish.Click += AddDish_Click;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(562, 56);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(127, 54);
            OrderButton.TabIndex = 8;
            OrderButton.Text = "Заказать";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(718, 58);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(127, 54);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // dataGridViewDishes
            // 
            dataGridViewDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDishes.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDishes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewDishes.Dock = DockStyle.Bottom;
            dataGridViewDishes.Location = new Point(0, 158);
            dataGridViewDishes.Name = "dataGridViewDishes";
            dataGridViewDishes.RowHeadersVisible = false;
            dataGridViewDishes.RowHeadersWidth = 51;
            dataGridViewDishes.Size = new Size(1058, 272);
            dataGridViewDishes.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название блюда";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Цена";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Общая сумма";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(886, 58);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(99, 51);
            ExitButton.TabIndex = 12;
            ExitButton.Text = "Выход ";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StatusOrder
            // 
            StatusOrder.AutoSize = true;
            StatusOrder.Location = new Point(562, 9);
            StatusOrder.Name = "StatusOrder";
            StatusOrder.Size = new Size(179, 21);
            StatusOrder.TabIndex = 13;
            StatusOrder.Text = "Степень готовки заказа";
            StatusOrder.Click += StatusOrder_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1058, 430);
            Controls.Add(StatusOrder);
            Controls.Add(ExitButton);
            Controls.Add(dataGridViewDishes);
            Controls.Add(ClearButton);
            Controls.Add(OrderButton);
            Controls.Add(AddDish);
            Controls.Add(TotalSum);
            Controls.Add(label1);
            Controls.Add(CountDish);
            Controls.Add(Блюда);
            Controls.Add(DishBox);
            Controls.Add(labelClientWelcome);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)CountDish).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientWelcome;
        private ComboBox DishBox;
        private Label Блюда;
        private NumericUpDown CountDish;
        private Label label1;
        private Label TotalSum;
        private Button AddDish;
        private Button OrderButton;
        private Button ClearButton;
        private DataGridView dataGridViewDishes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button ExitButton;
        private Label StatusOrder;
    }
}