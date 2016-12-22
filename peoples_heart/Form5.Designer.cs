namespace peoples_heart.Resources
{
    partial class Form5
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.NoOfMedicine = new MetroFramework.Controls.MetroLabel();
            this.MedicineName = new MetroFramework.Controls.MetroLabel();
            this.StartDate = new MetroFramework.Controls.MetroLabel();
            this.EndDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.DoneButton = new MetroFramework.Controls.MetroButton();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.MedicineNameInput = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.BeforeMeal = new MetroFramework.Controls.MetroCheckBox();
            this.MedicineNo = new MetroFramework.Controls.MetroLabel();
            this.TakingTime = new MetroFramework.Controls.MetroLabel();
            this.TakingTimeInput = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.AddNewButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.TakingTimeInput);
            this.metroPanel1.Controls.Add(this.TakingTime);
            this.metroPanel1.Controls.Add(this.MedicineNo);
            this.metroPanel1.Controls.Add(this.BeforeMeal);
            this.metroPanel1.Controls.Add(this.metroCheckBox1);
            this.metroPanel1.Controls.Add(this.metroDateTime2);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.MedicineNameInput);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.EndDate);
            this.metroPanel1.Controls.Add(this.StartDate);
            this.metroPanel1.Controls.Add(this.MedicineName);
            this.metroPanel1.Controls.Add(this.NoOfMedicine);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(32, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(845, 276);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // NoOfMedicine
            // 
            this.NoOfMedicine.AutoSize = true;
            this.NoOfMedicine.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NoOfMedicine.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.NoOfMedicine.Location = new System.Drawing.Point(85, 19);
            this.NoOfMedicine.Name = "NoOfMedicine";
            this.NoOfMedicine.Size = new System.Drawing.Size(142, 25);
            this.NoOfMedicine.TabIndex = 2;
            this.NoOfMedicine.Text = "No of Medicine";
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSize = true;
            this.MedicineName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MedicineName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MedicineName.Location = new System.Drawing.Point(85, 58);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(145, 25);
            this.MedicineName.TabIndex = 3;
            this.MedicineName.Text = "Medicine Name";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StartDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.StartDate.Location = new System.Drawing.Point(85, 99);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(88, 25);
            this.StartDate.TabIndex = 4;
            this.StartDate.Text = "End Date";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.EndDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.EndDate.Location = new System.Drawing.Point(85, 142);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(94, 25);
            this.EndDate.TabIndex = 5;
            this.EndDate.Text = "Start Date";
            this.EndDate.Click += new System.EventHandler(this.EndDate_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(85, 226);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 25);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Medicine";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DoneButton.Location = new System.Drawing.Point(117, 386);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(152, 41);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseSelectable = true;
            this.DoneButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CancelButton.Location = new System.Drawing.Point(608, 386);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(153, 41);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            // 
            // MedicineNameInput
            // 
            // 
            // 
            // 
            this.MedicineNameInput.CustomButton.Image = null;
            this.MedicineNameInput.CustomButton.Location = new System.Drawing.Point(422, 1);
            this.MedicineNameInput.CustomButton.Name = "";
            this.MedicineNameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MedicineNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MedicineNameInput.CustomButton.TabIndex = 1;
            this.MedicineNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MedicineNameInput.CustomButton.UseSelectable = true;
            this.MedicineNameInput.CustomButton.Visible = false;
            this.MedicineNameInput.Lines = new string[0];
            this.MedicineNameInput.Location = new System.Drawing.Point(285, 59);
            this.MedicineNameInput.MaxLength = 32767;
            this.MedicineNameInput.Name = "MedicineNameInput";
            this.MedicineNameInput.PasswordChar = '\0';
            this.MedicineNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MedicineNameInput.SelectedText = "";
            this.MedicineNameInput.SelectionLength = 0;
            this.MedicineNameInput.SelectionStart = 0;
            this.MedicineNameInput.ShortcutsEnabled = true;
            this.MedicineNameInput.Size = new System.Drawing.Size(444, 23);
            this.MedicineNameInput.TabIndex = 9;
            this.MedicineNameInput.UseSelectable = true;
            this.MedicineNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MedicineNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(285, 96);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(321, 30);
            this.metroDateTime1.TabIndex = 10;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(285, 139);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(321, 30);
            this.metroDateTime2.TabIndex = 11;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox1.Location = new System.Drawing.Point(463, 230);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(89, 17);
            this.metroCheckBox1.TabIndex = 13;
            this.metroCheckBox1.Text = "After Meal";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // BeforeMeal
            // 
            this.BeforeMeal.AutoSize = true;
            this.BeforeMeal.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.BeforeMeal.Location = new System.Drawing.Point(285, 230);
            this.BeforeMeal.Name = "BeforeMeal";
            this.BeforeMeal.Size = new System.Drawing.Size(98, 17);
            this.BeforeMeal.TabIndex = 14;
            this.BeforeMeal.Text = "Before Meal";
            this.BeforeMeal.UseSelectable = true;
            // 
            // MedicineNo
            // 
            this.MedicineNo.AutoSize = true;
            this.MedicineNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MedicineNo.Location = new System.Drawing.Point(285, 21);
            this.MedicineNo.Name = "MedicineNo";
            this.MedicineNo.Size = new System.Drawing.Size(27, 20);
            this.MedicineNo.TabIndex = 15;
            this.MedicineNo.Text = "00";
            this.MedicineNo.Click += new System.EventHandler(this.MedicineNo_Click);
            // 
            // TakingTime
            // 
            this.TakingTime.AutoSize = true;
            this.TakingTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TakingTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TakingTime.Location = new System.Drawing.Point(85, 185);
            this.TakingTime.Name = "TakingTime";
            this.TakingTime.Size = new System.Drawing.Size(112, 25);
            this.TakingTime.TabIndex = 16;
            this.TakingTime.Text = "Taking Time";
            // 
            // TakingTimeInput
            // 
            // 
            // 
            // 
            this.TakingTimeInput.CustomButton.Image = null;
            this.TakingTimeInput.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.TakingTimeInput.CustomButton.Name = "";
            this.TakingTimeInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TakingTimeInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TakingTimeInput.CustomButton.TabIndex = 1;
            this.TakingTimeInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TakingTimeInput.CustomButton.UseSelectable = true;
            this.TakingTimeInput.CustomButton.Visible = false;
            this.TakingTimeInput.Lines = new string[0];
            this.TakingTimeInput.Location = new System.Drawing.Point(285, 187);
            this.TakingTimeInput.MaxLength = 32767;
            this.TakingTimeInput.Name = "TakingTimeInput";
            this.TakingTimeInput.PasswordChar = '\0';
            this.TakingTimeInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TakingTimeInput.SelectedText = "";
            this.TakingTimeInput.SelectionLength = 0;
            this.TakingTimeInput.SelectionStart = 0;
            this.TakingTimeInput.ShortcutsEnabled = true;
            this.TakingTimeInput.Size = new System.Drawing.Size(188, 23);
            this.TakingTimeInput.TabIndex = 17;
            this.TakingTimeInput.UseSelectable = true;
            this.TakingTimeInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TakingTimeInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(493, 180);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(113, 30);
            this.metroComboBox1.TabIndex = 18;
            this.metroComboBox1.UseSelectable = true;
            // 
            // AddNewButton
            // 
            this.AddNewButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddNewButton.Location = new System.Drawing.Point(364, 386);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(165, 41);
            this.AddNewButton.TabIndex = 3;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseSelectable = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form4";
            this.Text = "New";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel EndDate;
        private MetroFramework.Controls.MetroLabel StartDate;
        private MetroFramework.Controls.MetroLabel MedicineName;
        private MetroFramework.Controls.MetroLabel NoOfMedicine;
        private MetroFramework.Controls.MetroTextBox MedicineNameInput;
        private MetroFramework.Controls.MetroButton DoneButton;
        private MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel MedicineNo;
        private MetroFramework.Controls.MetroCheckBox BeforeMeal;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel TakingTime;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox TakingTimeInput;
        private MetroFramework.Controls.MetroButton AddNewButton;
    }
}