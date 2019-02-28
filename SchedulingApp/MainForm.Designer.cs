﻿namespace SchedulingApp
{
    partial class MainForm
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
            this.mainWelcomeLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvViewMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.dgvViewWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.dgvViewDayRadioButton = new System.Windows.Forms.RadioButton();
            this.dgvViewGroupBox = new System.Windows.Forms.GroupBox();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.mainAddButton = new System.Windows.Forms.Button();
            this.mainEditButton = new System.Windows.Forms.Button();
            this.mainDeleteButton = new System.Windows.Forms.Button();
            this.mainLogoutButton = new System.Windows.Forms.Button();
            this.mainCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dgvViewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWelcomeLabel
            // 
            this.mainWelcomeLabel.AutoSize = true;
            this.mainWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.mainWelcomeLabel.Name = "mainWelcomeLabel";
            this.mainWelcomeLabel.Size = new System.Drawing.Size(96, 24);
            this.mainWelcomeLabel.TabIndex = 0;
            this.mainWelcomeLabel.Text = "Welcome!";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 53);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 244);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgvViewMonthRadioButton
            // 
            this.dgvViewMonthRadioButton.AutoSize = true;
            this.dgvViewMonthRadioButton.Location = new System.Drawing.Point(40, 19);
            this.dgvViewMonthRadioButton.Name = "dgvViewMonthRadioButton";
            this.dgvViewMonthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.dgvViewMonthRadioButton.TabIndex = 3;
            this.dgvViewMonthRadioButton.TabStop = true;
            this.dgvViewMonthRadioButton.Text = "Month";
            this.dgvViewMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // dgvViewWeekRadioButton
            // 
            this.dgvViewWeekRadioButton.AutoSize = true;
            this.dgvViewWeekRadioButton.Location = new System.Drawing.Point(115, 19);
            this.dgvViewWeekRadioButton.Name = "dgvViewWeekRadioButton";
            this.dgvViewWeekRadioButton.Size = new System.Drawing.Size(54, 17);
            this.dgvViewWeekRadioButton.TabIndex = 4;
            this.dgvViewWeekRadioButton.TabStop = true;
            this.dgvViewWeekRadioButton.Text = "Week";
            this.dgvViewWeekRadioButton.UseVisualStyleBackColor = true;
            // 
            // dgvViewDayRadioButton
            // 
            this.dgvViewDayRadioButton.AutoSize = true;
            this.dgvViewDayRadioButton.Location = new System.Drawing.Point(186, 19);
            this.dgvViewDayRadioButton.Name = "dgvViewDayRadioButton";
            this.dgvViewDayRadioButton.Size = new System.Drawing.Size(44, 17);
            this.dgvViewDayRadioButton.TabIndex = 5;
            this.dgvViewDayRadioButton.TabStop = true;
            this.dgvViewDayRadioButton.Text = "Day";
            this.dgvViewDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // dgvViewGroupBox
            // 
            this.dgvViewGroupBox.Controls.Add(this.dgvViewDayRadioButton);
            this.dgvViewGroupBox.Controls.Add(this.dgvViewWeekRadioButton);
            this.dgvViewGroupBox.Controls.Add(this.dgvViewMonthRadioButton);
            this.dgvViewGroupBox.Location = new System.Drawing.Point(379, 34);
            this.dgvViewGroupBox.Name = "dgvViewGroupBox";
            this.dgvViewGroupBox.Size = new System.Drawing.Size(257, 42);
            this.dgvViewGroupBox.TabIndex = 6;
            this.dgvViewGroupBox.TabStop = false;
            this.dgvViewGroupBox.Text = "View";
            // 
            // mainExitButton
            // 
            this.mainExitButton.Location = new System.Drawing.Point(653, 343);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(75, 23);
            this.mainExitButton.TabIndex = 10;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // mainAddButton
            // 
            this.mainAddButton.Location = new System.Drawing.Point(170, 227);
            this.mainAddButton.Name = "mainAddButton";
            this.mainAddButton.Size = new System.Drawing.Size(75, 23);
            this.mainAddButton.TabIndex = 11;
            this.mainAddButton.Text = "Add";
            this.mainAddButton.UseVisualStyleBackColor = true;
            // 
            // mainEditButton
            // 
            this.mainEditButton.Location = new System.Drawing.Point(170, 256);
            this.mainEditButton.Name = "mainEditButton";
            this.mainEditButton.Size = new System.Drawing.Size(75, 23);
            this.mainEditButton.TabIndex = 12;
            this.mainEditButton.Text = "Edit";
            this.mainEditButton.UseVisualStyleBackColor = true;
            // 
            // mainDeleteButton
            // 
            this.mainDeleteButton.Location = new System.Drawing.Point(170, 285);
            this.mainDeleteButton.Name = "mainDeleteButton";
            this.mainDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.mainDeleteButton.TabIndex = 13;
            this.mainDeleteButton.Text = "Delete";
            this.mainDeleteButton.UseVisualStyleBackColor = true;
            // 
            // mainLogoutButton
            // 
            this.mainLogoutButton.Location = new System.Drawing.Point(561, 343);
            this.mainLogoutButton.Name = "mainLogoutButton";
            this.mainLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.mainLogoutButton.TabIndex = 14;
            this.mainLogoutButton.Text = "Logout";
            this.mainLogoutButton.UseVisualStyleBackColor = true;
            this.mainLogoutButton.Click += new System.EventHandler(this.mainLogoutButton_Click);
            // 
            // mainCustomerButton
            // 
            this.mainCustomerButton.Location = new System.Drawing.Point(35, 256);
            this.mainCustomerButton.Name = "mainCustomerButton";
            this.mainCustomerButton.Size = new System.Drawing.Size(99, 23);
            this.mainCustomerButton.TabIndex = 15;
            this.mainCustomerButton.Text = "View Customers";
            this.mainCustomerButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(761, 385);
            this.Controls.Add(this.mainCustomerButton);
            this.Controls.Add(this.mainLogoutButton);
            this.Controls.Add(this.mainDeleteButton);
            this.Controls.Add(this.mainEditButton);
            this.Controls.Add(this.mainAddButton);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.dgvViewGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.mainWelcomeLabel);
            this.Name = "MainForm";
            this.Text = "Schedule App | Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dgvViewGroupBox.ResumeLayout(false);
            this.dgvViewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainWelcomeLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton dgvViewMonthRadioButton;
        private System.Windows.Forms.RadioButton dgvViewWeekRadioButton;
        private System.Windows.Forms.RadioButton dgvViewDayRadioButton;
        private System.Windows.Forms.GroupBox dgvViewGroupBox;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.Button mainAddButton;
        private System.Windows.Forms.Button mainEditButton;
        private System.Windows.Forms.Button mainDeleteButton;
        private System.Windows.Forms.Button mainLogoutButton;
        private System.Windows.Forms.Button mainCustomerButton;
    }
}