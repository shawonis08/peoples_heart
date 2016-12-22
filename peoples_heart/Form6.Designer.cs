namespace peoples_heart
{
    partial class Form6
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
            this.MedicineTake = new MetroFramework.Controls.MetroLabel();
            this.MedicineNo = new MetroFramework.Controls.MetroLabel();
            this.NameOfMedicine = new MetroFramework.Controls.MetroLabel();
            this.MealTime = new MetroFramework.Controls.MetroLabel();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MealTime);
            this.metroPanel1.Controls.Add(this.NameOfMedicine);
            this.metroPanel1.Controls.Add(this.MedicineNo);
            this.metroPanel1.Controls.Add(this.MedicineTake);
            this.metroPanel1.Controls.Add(this.MedicineName);
            this.metroPanel1.Controls.Add(this.NoOfMedicine);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(32, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(810, 248);
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
            this.NoOfMedicine.Location = new System.Drawing.Point(95, 52);
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
            this.MedicineName.Location = new System.Drawing.Point(95, 107);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(145, 25);
            this.MedicineName.TabIndex = 3;
            this.MedicineName.Text = "Medicine Name";
            // 
            // MedicineTake
            // 
            this.MedicineTake.AutoSize = true;
            this.MedicineTake.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MedicineTake.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MedicineTake.Location = new System.Drawing.Point(95, 165);
            this.MedicineTake.Name = "MedicineTake";
            this.MedicineTake.Size = new System.Drawing.Size(132, 25);
            this.MedicineTake.TabIndex = 4;
            this.MedicineTake.Text = "Medicine Take";
            // 
            // MedicineNo
            // 
            this.MedicineNo.AutoSize = true;
            this.MedicineNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MedicineNo.Location = new System.Drawing.Point(332, 54);
            this.MedicineNo.Name = "MedicineNo";
            this.MedicineNo.Size = new System.Drawing.Size(27, 20);
            this.MedicineNo.TabIndex = 5;
            this.MedicineNo.Text = "00";
            // 
            // NameOfMedicine
            // 
            this.NameOfMedicine.AutoSize = true;
            this.NameOfMedicine.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameOfMedicine.Location = new System.Drawing.Point(332, 109);
            this.NameOfMedicine.Name = "NameOfMedicine";
            this.NameOfMedicine.Size = new System.Drawing.Size(139, 20);
            this.NameOfMedicine.TabIndex = 6;
            this.NameOfMedicine.Text = "Name Of Medicine";
            // 
            // MealTime
            // 
            this.MealTime.AutoSize = true;
            this.MealTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MealTime.Location = new System.Drawing.Point(332, 167);
            this.MealTime.Name = "MealTime";
            this.MealTime.Size = new System.Drawing.Size(138, 20);
            this.MealTime.TabIndex = 7;
            this.MealTime.Text = "Before/After Meal";
            // 
            // CancelButton
            // 
            this.CancelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CancelButton.Location = new System.Drawing.Point(346, 373);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(198, 45);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form6";
            this.Text = "Existing";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel MealTime;
        private MetroFramework.Controls.MetroLabel NameOfMedicine;
        private MetroFramework.Controls.MetroLabel MedicineNo;
        private MetroFramework.Controls.MetroLabel MedicineTake;
        private MetroFramework.Controls.MetroLabel MedicineName;
        private MetroFramework.Controls.MetroLabel NoOfMedicine;
        private MetroFramework.Controls.MetroButton CancelButton;
    }
}