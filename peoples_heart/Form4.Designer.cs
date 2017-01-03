namespace peoples_heart.Resources
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ExistingButton = new MetroFramework.Controls.MetroButton();
            this.NewButton = new MetroFramework.Controls.MetroButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.ExistingButton);
            this.metroPanel1.Controls.Add(this.NewButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(199, 76);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(570, 304);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(230, 226);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Log Out";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ExistingButton
            // 
            this.ExistingButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ExistingButton.Location = new System.Drawing.Point(161, 120);
            this.ExistingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExistingButton.Name = "ExistingButton";
            this.ExistingButton.Size = new System.Drawing.Size(212, 46);
            this.ExistingButton.TabIndex = 3;
            this.ExistingButton.Text = "Existing";
            this.ExistingButton.UseSelectable = true;
            this.ExistingButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NewButton
            // 
            this.NewButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NewButton.Location = new System.Drawing.Point(161, 38);
            this.NewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(212, 49);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.UseSelectable = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Notification";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 30);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "People\'s Heart";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.metroPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ExistingButton;
        private MetroFramework.Controls.MetroButton NewButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}