﻿namespace CafeApp
{
    partial class AdminForm
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
            TableWorker = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            SaveWorkerButton = new Button();
            ExitButtonWorker = new Button();
            TablesWorkers = new DataGridView();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            SaveRoleButton = new Button();
            ExitButtonStaff = new Button();
            TableStaff = new DataGridView();
            tabPage3 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            SaveMenu = new Button();
            ExitDish = new Button();
            TablesDish = new DataGridView();
            tabPage4 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            TableWorker.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablesWorkers).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableStaff).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablesDish).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TableWorker
            // 
            TableWorker.Controls.Add(tabPage1);
            TableWorker.Controls.Add(tabPage2);
            TableWorker.Controls.Add(tabPage3);
            TableWorker.Dock = DockStyle.Fill;
            TableWorker.Location = new Point(0, 0);
            TableWorker.Margin = new Padding(3, 2, 3, 2);
            TableWorker.Name = "TableWorker";
            TableWorker.RightToLeft = RightToLeft.No;
            TableWorker.RightToLeftLayout = true;
            TableWorker.SelectedIndex = 0;
            TableWorker.Size = new Size(700, 338);
            TableWorker.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(692, 310);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Персонал";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(TablesWorkers, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3695087F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.63049F));
            tableLayoutPanel1.Size = new Size(686, 306);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(SaveWorkerButton);
            panel1.Controls.Add(ExitButtonWorker);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 30);
            panel1.TabIndex = 1;
            // 
            // SaveWorkerButton
            // 
            SaveWorkerButton.Location = new Point(527, 1);
            SaveWorkerButton.Name = "SaveWorkerButton";
            SaveWorkerButton.Size = new Size(85, 29);
            SaveWorkerButton.TabIndex = 1;
            SaveWorkerButton.Text = "Сохранить";
            SaveWorkerButton.UseVisualStyleBackColor = true;
            SaveWorkerButton.Click += SaveWorkersButton_Click;
            // 
            // ExitButtonWorker
            // 
            ExitButtonWorker.Dock = DockStyle.Right;
            ExitButtonWorker.Location = new Point(608, 0);
            ExitButtonWorker.Margin = new Padding(3, 2, 3, 2);
            ExitButtonWorker.Name = "ExitButtonWorker";
            ExitButtonWorker.Size = new Size(72, 30);
            ExitButtonWorker.TabIndex = 0;
            ExitButtonWorker.Text = "Выход";
            ExitButtonWorker.UseVisualStyleBackColor = true;
            ExitButtonWorker.Click += ExitButtonWorker_Click;
            // 
            // TablesWorkers
            // 
            TablesWorkers.BackgroundColor = SystemColors.ControlLightLight;
            TablesWorkers.ColumnHeadersHeight = 29;
            TablesWorkers.Dock = DockStyle.Fill;
            TablesWorkers.Location = new Point(3, 36);
            TablesWorkers.Margin = new Padding(3, 2, 3, 2);
            TablesWorkers.Name = "TablesWorkers";
            TablesWorkers.RowHeadersWidth = 51;
            TablesWorkers.Size = new Size(680, 268);
            TablesWorkers.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(692, 310);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Роли";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(TableStaff, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9904079F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.00959F));
            tableLayoutPanel2.Size = new Size(693, 313);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(SaveRoleButton);
            panel2.Controls.Add(ExitButtonStaff);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 33);
            panel2.TabIndex = 0;
            // 
            // SaveRoleButton
            // 
            SaveRoleButton.Location = new Point(522, 1);
            SaveRoleButton.Name = "SaveRoleButton";
            SaveRoleButton.Size = new Size(86, 32);
            SaveRoleButton.TabIndex = 2;
            SaveRoleButton.Text = "Сохранить";
            SaveRoleButton.UseVisualStyleBackColor = true;
            SaveRoleButton.Click += SaveRoleButton_Click;
            // 
            // ExitButtonStaff
            // 
            ExitButtonStaff.Dock = DockStyle.Right;
            ExitButtonStaff.Location = new Point(604, 0);
            ExitButtonStaff.Margin = new Padding(3, 2, 3, 2);
            ExitButtonStaff.Name = "ExitButtonStaff";
            ExitButtonStaff.Size = new Size(83, 33);
            ExitButtonStaff.TabIndex = 0;
            ExitButtonStaff.Text = "Выход";
            ExitButtonStaff.UseVisualStyleBackColor = true;
            ExitButtonStaff.Click += ExitButtonStaff_Click;
            // 
            // TableStaff
            // 
            TableStaff.BackgroundColor = SystemColors.ButtonHighlight;
            TableStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableStaff.Dock = DockStyle.Fill;
            TableStaff.Location = new Point(3, 39);
            TableStaff.Margin = new Padding(3, 2, 3, 2);
            TableStaff.Name = "TableStaff";
            TableStaff.RowHeadersWidth = 51;
            TableStaff.Size = new Size(687, 272);
            TableStaff.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(692, 310);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Меню";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Controls.Add(TablesDish, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3695087F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 88.63049F));
            tableLayoutPanel4.Size = new Size(686, 306);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(SaveMenu);
            panel4.Controls.Add(ExitDish);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(680, 30);
            panel4.TabIndex = 1;
            // 
            // SaveMenu
            // 
            SaveMenu.Location = new Point(517, 0);
            SaveMenu.Name = "SaveMenu";
            SaveMenu.Size = new Size(85, 30);
            SaveMenu.TabIndex = 1;
            SaveMenu.Text = "Сохранить";
            SaveMenu.UseVisualStyleBackColor = true;
            SaveMenu.Click += SaveMenu_Click;
            // 
            // ExitDish
            // 
            ExitDish.Dock = DockStyle.Right;
            ExitDish.Location = new Point(598, 0);
            ExitDish.Margin = new Padding(3, 2, 3, 2);
            ExitDish.Name = "ExitDish";
            ExitDish.Size = new Size(82, 30);
            ExitDish.TabIndex = 0;
            ExitDish.Text = "Выход";
            ExitDish.UseVisualStyleBackColor = true;
            ExitDish.Click += ExitDish_Click;
            // 
            // TablesDish
            // 
            TablesDish.BackgroundColor = SystemColors.ControlLightLight;
            TablesDish.ColumnHeadersHeight = 29;
            TablesDish.Dock = DockStyle.Fill;
            TablesDish.Location = new Point(3, 36);
            TablesDish.Margin = new Padding(3, 2, 3, 2);
            TablesDish.Name = "TablesDish";
            TablesDish.RowHeadersWidth = 51;
            TablesDish.Size = new Size(680, 268);
            TablesDish.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(0, 0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(200, 100);
            tabPage4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 40);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(100, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(194, 359);
            dataGridView1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(TableWorker);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "AdminForm";
            TableWorker.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablesWorkers).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TableStaff).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablesDish).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TableWorker;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage2;
        private DataGridView TablesWorkers;
        private Panel panel1;
        private Button ExitButtonWorker;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private DataGridView TableStaff;
        private Button ExitButtonStaff;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private Button ExitDish;
        private DataGridView TablesDish;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Button button1;
        private DataGridView dataGridView1;
        private Button SaveWorkerButton;
        private Button SaveRoleButton;
        private Button SaveMenu;
    }
}