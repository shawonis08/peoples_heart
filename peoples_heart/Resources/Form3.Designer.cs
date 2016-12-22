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
            this.NewButton = new MetroFramework.Controls.MetroButton();
            this.ExistingButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ExistingButton);
            this.metroPanel1.Controls.Add(this.NewButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(199, 101);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(545, 282);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // NewButton
            // 
            this.NewButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NewButton.Location = new System.Drawing.Point(171, 74);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(212, 49);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.UseSelectable = true;
            // 
            // ExistingButton
            // 
            this.ExistingButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ExistingButton.Location = new System.Drawing.Point(171, 156);
            this.ExistingButton.Name = "ExistingButton";
            this.ExistingButton.Size = new System.Drawing.Size(212, 46);
            this.ExistingButton.TabIndex = 3;
            this.ExistingButton.Text = "Existing";
            this.ExistingButton.UseSelectable = true;
            this.ExistingButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "People\'s Heart";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ExistingButton;
        private MetroFramework.Controls.MetroButton NewButton;
    }
}