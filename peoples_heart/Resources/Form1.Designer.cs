﻿namespace peoples_heart.Resources
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.PatientName = new MetroFramework.Controls.MetroLabel();
            this.PatientAge = new MetroFramework.Controls.MetroLabel();
            this.RequestPin = new MetroFramework.Controls.MetroLabel();
            this.ConfirmPin = new MetroFramework.Controls.MetroLabel();
            this.PatientNameInput = new MetroFramework.Controls.MetroTextBox();
            this.PatientAgeInput = new MetroFramework.Controls.MetroTextBox();
            this.RequestPinInput = new MetroFramework.Controls.MetroTextBox();
            this.ConfirmPinInput = new MetroFramework.Controls.MetroTextBox();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.ConfirmButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ConfirmPinInput);
            this.metroPanel1.Controls.Add(this.RequestPinInput);
            this.metroPanel1.Controls.Add(this.PatientAgeInput);
            this.metroPanel1.Controls.Add(this.PatientNameInput);
            this.metroPanel1.Controls.Add(this.ConfirmPin);
            this.metroPanel1.Controls.Add(this.RequestPin);
            this.metroPanel1.Controls.Add(this.PatientAge);
            this.metroPanel1.Controls.Add(this.PatientName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(33, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(857, 276);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PatientName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PatientName.Location = new System.Drawing.Point(113, 45);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(125, 25);
            this.PatientName.TabIndex = 2;
            this.PatientName.Text = "Patient Name";
            this.PatientName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientName.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // PatientAge
            // 
            this.PatientAge.AutoSize = true;
            this.PatientAge.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PatientAge.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PatientAge.Location = new System.Drawing.Point(113, 98);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.Size = new System.Drawing.Size(108, 25);
            this.PatientAge.TabIndex = 3;
            this.PatientAge.Text = "Patient Age";
            // 
            // RequestPin
            // 
            this.RequestPin.AutoSize = true;
            this.RequestPin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RequestPin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RequestPin.Location = new System.Drawing.Point(113, 147);
            this.RequestPin.Name = "RequestPin";
            this.RequestPin.Size = new System.Drawing.Size(113, 25);
            this.RequestPin.TabIndex = 4;
            this.RequestPin.Text = "Request PIN";
            this.RequestPin.Click += new System.EventHandler(this.RequestPin_Click);
            // 
            // ConfirmPin
            // 
            this.ConfirmPin.AutoSize = true;
            this.ConfirmPin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ConfirmPin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ConfirmPin.Location = new System.Drawing.Point(113, 203);
            this.ConfirmPin.Name = "ConfirmPin";
            this.ConfirmPin.Size = new System.Drawing.Size(115, 25);
            this.ConfirmPin.TabIndex = 5;
            this.ConfirmPin.Text = "Confirm PIN";
            this.ConfirmPin.Click += new System.EventHandler(this.ConfirmPin_Click);
            // 
            // PatientNameInput
            // 
            // 
            // 
            // 
            this.PatientNameInput.CustomButton.Image = null;
            this.PatientNameInput.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.PatientNameInput.CustomButton.Name = "";
            this.PatientNameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientNameInput.CustomButton.TabIndex = 1;
            this.PatientNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientNameInput.CustomButton.UseSelectable = true;
            this.PatientNameInput.CustomButton.Visible = false;
            this.PatientNameInput.Lines = new string[0];
            this.PatientNameInput.Location = new System.Drawing.Point(305, 46);
            this.PatientNameInput.MaxLength = 32767;
            this.PatientNameInput.Name = "PatientNameInput";
            this.PatientNameInput.PasswordChar = '\0';
            this.PatientNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientNameInput.SelectedText = "";
            this.PatientNameInput.SelectionLength = 0;
            this.PatientNameInput.SelectionStart = 0;
            this.PatientNameInput.ShortcutsEnabled = true;
            this.PatientNameInput.Size = new System.Drawing.Size(422, 23);
            this.PatientNameInput.TabIndex = 6;
            this.PatientNameInput.UseSelectable = true;
            this.PatientNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PatientAgeInput
            // 
            // 
            // 
            // 
            this.PatientAgeInput.CustomButton.Image = null;
            this.PatientAgeInput.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.PatientAgeInput.CustomButton.Name = "";
            this.PatientAgeInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientAgeInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientAgeInput.CustomButton.TabIndex = 1;
            this.PatientAgeInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientAgeInput.CustomButton.UseSelectable = true;
            this.PatientAgeInput.CustomButton.Visible = false;
            this.PatientAgeInput.Lines = new string[0];
            this.PatientAgeInput.Location = new System.Drawing.Point(305, 99);
            this.PatientAgeInput.MaxLength = 32767;
            this.PatientAgeInput.Name = "PatientAgeInput";
            this.PatientAgeInput.PasswordChar = '\0';
            this.PatientAgeInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientAgeInput.SelectedText = "";
            this.PatientAgeInput.SelectionLength = 0;
            this.PatientAgeInput.SelectionStart = 0;
            this.PatientAgeInput.ShortcutsEnabled = true;
            this.PatientAgeInput.Size = new System.Drawing.Size(422, 23);
            this.PatientAgeInput.TabIndex = 7;
            this.PatientAgeInput.UseSelectable = true;
            this.PatientAgeInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientAgeInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RequestPinInput
            // 
            // 
            // 
            // 
            this.RequestPinInput.CustomButton.Image = null;
            this.RequestPinInput.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.RequestPinInput.CustomButton.Name = "";
            this.RequestPinInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RequestPinInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RequestPinInput.CustomButton.TabIndex = 1;
            this.RequestPinInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RequestPinInput.CustomButton.UseSelectable = true;
            this.RequestPinInput.CustomButton.Visible = false;
            this.RequestPinInput.Lines = new string[0];
            this.RequestPinInput.Location = new System.Drawing.Point(305, 148);
            this.RequestPinInput.MaxLength = 32767;
            this.RequestPinInput.Name = "RequestPinInput";
            this.RequestPinInput.PasswordChar = '\0';
            this.RequestPinInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RequestPinInput.SelectedText = "";
            this.RequestPinInput.SelectionLength = 0;
            this.RequestPinInput.SelectionStart = 0;
            this.RequestPinInput.ShortcutsEnabled = true;
            this.RequestPinInput.Size = new System.Drawing.Size(422, 23);
            this.RequestPinInput.TabIndex = 8;
            this.RequestPinInput.UseSelectable = true;
            this.RequestPinInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RequestPinInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConfirmPinInput
            // 
            // 
            // 
            // 
            this.ConfirmPinInput.CustomButton.Image = null;
            this.ConfirmPinInput.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.ConfirmPinInput.CustomButton.Name = "";
            this.ConfirmPinInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ConfirmPinInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConfirmPinInput.CustomButton.TabIndex = 1;
            this.ConfirmPinInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConfirmPinInput.CustomButton.UseSelectable = true;
            this.ConfirmPinInput.CustomButton.Visible = false;
            this.ConfirmPinInput.Lines = new string[0];
            this.ConfirmPinInput.Location = new System.Drawing.Point(305, 204);
            this.ConfirmPinInput.MaxLength = 32767;
            this.ConfirmPinInput.Name = "ConfirmPinInput";
            this.ConfirmPinInput.PasswordChar = '\0';
            this.ConfirmPinInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConfirmPinInput.SelectedText = "";
            this.ConfirmPinInput.SelectionLength = 0;
            this.ConfirmPinInput.SelectionStart = 0;
            this.ConfirmPinInput.ShortcutsEnabled = true;
            this.ConfirmPinInput.Size = new System.Drawing.Size(422, 23);
            this.ConfirmPinInput.TabIndex = 9;
            this.ConfirmPinInput.UseSelectable = true;
            this.ConfirmPinInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConfirmPinInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CancelButton
            // 
            this.CancelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CancelButton.Location = new System.Drawing.Point(529, 384);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(135, 41);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel ";
            this.CancelButton.UseSelectable = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ConfirmButton.Location = new System.Drawing.Point(244, 384);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(146, 41);
            this.ConfirmButton.TabIndex = 11;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Register";
            this.TransparencyKey = System.Drawing.Color.Azure;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel ConfirmPin;
        private MetroFramework.Controls.MetroLabel RequestPin;
        private MetroFramework.Controls.MetroLabel PatientAge;
        private MetroFramework.Controls.MetroLabel PatientName;
        private MetroFramework.Controls.MetroTextBox ConfirmPinInput;
        private MetroFramework.Controls.MetroTextBox RequestPinInput;
        private MetroFramework.Controls.MetroTextBox PatientAgeInput;
        private MetroFramework.Controls.MetroTextBox PatientNameInput;
        private MetroFramework.Controls.MetroButton ConfirmButton;
        private MetroFramework.Controls.MetroButton CancelButton;
    }
}