namespace Chapter_6_Project_3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.ShiftsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.JobsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NextShiftBtn = new System.Windows.Forms.Button();
            this.ReportTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayButton);
            this.groupBox1.Controls.Add(this.AssignBtn);
            this.groupBox1.Controls.Add(this.ShiftsNumUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.JobsComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(131, 63);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(115, 67);
            this.DisplayButton.TabIndex = 5;
            this.DisplayButton.Text = "Display Bees";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // AssignBtn
            // 
            this.AssignBtn.Enabled = false;
            this.AssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AssignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignBtn.Location = new System.Drawing.Point(10, 64);
            this.AssignBtn.Name = "AssignBtn";
            this.AssignBtn.Size = new System.Drawing.Size(115, 66);
            this.AssignBtn.TabIndex = 4;
            this.AssignBtn.Text = "Assign Job";
            this.AssignBtn.UseVisualStyleBackColor = true;
            this.AssignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            // 
            // ShiftsNumUpDown
            // 
            this.ShiftsNumUpDown.Location = new System.Drawing.Point(193, 37);
            this.ShiftsNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ShiftsNumUpDown.Name = "ShiftsNumUpDown";
            this.ShiftsNumUpDown.Size = new System.Drawing.Size(53, 20);
            this.ShiftsNumUpDown.TabIndex = 3;
            this.ShiftsNumUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shifts";
            // 
            // JobsComboBox
            // 
            this.JobsComboBox.FormattingEnabled = true;
            this.JobsComboBox.Items.AddRange(new object[] {
            "Baby Bee Tutoring",
            "Egg Care",
            "Hive Maintenance",
            "Honey Manufacturing",
            "Nectar Collection",
            "Sting Patrol"});
            this.JobsComboBox.Location = new System.Drawing.Point(10, 37);
            this.JobsComboBox.Name = "JobsComboBox";
            this.JobsComboBox.Size = new System.Drawing.Size(152, 21);
            this.JobsComboBox.TabIndex = 1;
            this.JobsComboBox.SelectedIndexChanged += new System.EventHandler(this.JobsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Job";
            // 
            // NextShiftBtn
            // 
            this.NextShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextShiftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextShiftBtn.Location = new System.Drawing.Point(286, 12);
            this.NextShiftBtn.Name = "NextShiftBtn";
            this.NextShiftBtn.Size = new System.Drawing.Size(137, 136);
            this.NextShiftBtn.TabIndex = 2;
            this.NextShiftBtn.Text = "Work The Next Shift";
            this.NextShiftBtn.UseVisualStyleBackColor = true;
            // 
            // ReportTxtBox
            // 
            this.ReportTxtBox.Location = new System.Drawing.Point(16, 154);
            this.ReportTxtBox.Multiline = true;
            this.ReportTxtBox.Name = "ReportTxtBox";
            this.ReportTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTxtBox.Size = new System.Drawing.Size(407, 183);
            this.ReportTxtBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 349);
            this.Controls.Add(this.ReportTxtBox);
            this.Controls.Add(this.NextShiftBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox JobsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AssignBtn;
        private System.Windows.Forms.NumericUpDown ShiftsNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextShiftBtn;
        private System.Windows.Forms.TextBox ReportTxtBox;
        private System.Windows.Forms.Button DisplayButton;
    }
}

