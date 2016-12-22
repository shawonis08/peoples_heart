namespace peoples_heart.Resources
{
    partial class Form3
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
            this.PatientPin = new MetroFramework.Controls.MetroLabel();
            this.PatientPinInput = new MetroFramework.Controls.MetroTextBox();
            this.ConfirmButton = new MetroFramework.Controls.MetroButton();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.PatientNameInput = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.PatientNameInput);
            this.metroPanel1.Controls.Add(this.PatientPinInput);
            this.metroPanel1.Controls.Add(this.PatientPin);
            this.metroPanel1.Controls.Add(this.PatientName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(36, 97);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(829, 192);
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
            this.PatientName.Location = new System.Drawing.Point(110, 54);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(125, 25);
            this.PatientName.TabIndex = 2;
            this.PatientName.Text = "Patient Name";
            // 
            // PatientPin
            // 
            this.PatientPin.AutoSize = true;
            this.PatientPin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PatientPin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PatientPin.Location = new System.Drawing.Point(110, 101);
            this.PatientPin.Name = "PatientPin";
            this.PatientPin.Size = new System.Drawing.Size(105, 25);
            this.PatientPin.TabIndex = 3;
            this.PatientPin.Text = "Patient PIN";
            this.PatientPin.Click += new System.EventHandler(this.PatientPin_Click);
            // 
            // PatientPinInput
            // 
            // 
            // 
            // 
            this.PatientPinInput.CustomButton.Image = null;
            this.PatientPinInput.CustomButton.Location = new System.Drawing.Point(379, 1);
            this.PatientPinInput.CustomButton.Name = "";
            this.PatientPinInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientPinInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientPinInput.CustomButton.TabIndex = 1;
            this.PatientPinInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientPinInput.CustomButton.UseSelectable = true;
            this.PatientPinInput.CustomButton.Visible = false;
            this.PatientPinInput.Lines = new string[0];
            this.PatientPinInput.Location = new System.Drawing.Point(308, 103);
            this.PatientPinInput.MaxLength = 32767;
            this.PatientPinInput.Name = "PatientPinInput";
            this.PatientPinInput.PasswordChar = '\0';
            this.PatientPinInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientPinInput.SelectedText = "";
            this.PatientPinInput.SelectionLength = 0;
            this.PatientPinInput.SelectionStart = 0;
            this.PatientPinInput.ShortcutsEnabled = true;
            this.PatientPinInput.Size = new System.Drawing.Size(401, 23);
            this.PatientPinInput.TabIndex = 5;
            this.PatientPinInput.UseSelectable = true;
            this.PatientPinInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientPinInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PatientPinInput.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ConfirmButton.Location = new System.Drawing.Point(250, 350);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(131, 43);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseSelectable = true;
            // 
            // CancelButton
            // 
            this.CancelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CancelButton.Location = new System.Drawing.Point(537, 350);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(137, 43);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            // 
            // PatientNameInput
            // 
            // 
            // 
            // 
            this.PatientNameInput.CustomButton.Image = null;
            this.PatientNameInput.CustomButton.Location = new System.Drawing.Point(379, 1);
            this.PatientNameInput.CustomButton.Name = "";
            this.PatientNameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientNameInput.CustomButton.TabIndex = 1;
            this.PatientNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientNameInput.CustomButton.UseSelectable = true;
            this.PatientNameInput.CustomButton.Visible = false;
            this.PatientNameInput.Lines = new string[0];
            this.PatientNameInput.Location = new System.Drawing.Point(308, 54);
            this.PatientNameInput.MaxLength = 32767;
            this.PatientNameInput.Name = "PatientNameInput";
            this.PatientNameInput.PasswordChar = '\0';
            this.PatientNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientNameInput.SelectedText = "";
            this.PatientNameInput.SelectionLength = 0;
            this.PatientNameInput.SelectionStart = 0;
            this.PatientNameInput.ShortcutsEnabled = true;
            this.PatientNameInput.Size = new System.Drawing.Size(401, 23);
            this.PatientNameInput.TabIndex = 6;
            this.PatientNameInput.UseSelectable = true;
            this.PatientNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form2";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox PatientNameInput;
        private MetroFramework.Controls.MetroTextBox PatientPinInput;
        private MetroFramework.Controls.MetroLabel PatientPin;
        private MetroFramework.Controls.MetroLabel PatientName;
        private MetroFramework.Controls.MetroButton ConfirmButton;
        private MetroFramework.Controls.MetroButton CancelButton;
    }
}