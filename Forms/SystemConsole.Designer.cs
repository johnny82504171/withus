namespace Withus.Forms
{
    partial class SystemConsole
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
            this.menuStrip_SystemConsole = new System.Windows.Forms.MenuStrip();
            this.menuItem_SystemConsole_Tray = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_SystemConsole = new System.Windows.Forms.RichTextBox();
            this.menuStrip_SystemConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_SystemConsole
            // 
            this.menuStrip_SystemConsole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_SystemConsole_Tray});
            this.menuStrip_SystemConsole.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SystemConsole.Name = "menuStrip_SystemConsole";
            this.menuStrip_SystemConsole.Size = new System.Drawing.Size(578, 24);
            this.menuStrip_SystemConsole.TabIndex = 0;
            this.menuStrip_SystemConsole.Text = "menuStrip2";
            // 
            // menuItem_SystemConsole_Tray
            // 
            this.menuItem_SystemConsole_Tray.Name = "menuItem_SystemConsole_Tray";
            this.menuItem_SystemConsole_Tray.Size = new System.Drawing.Size(55, 20);
            this.menuItem_SystemConsole_Tray.Text = "최소화";
            this.menuItem_SystemConsole_Tray.Click += new System.EventHandler(this.menuItem_SystemConsole_Tray_Click);
            // 
            // richTextBox_SystemConsole
            // 
            this.richTextBox_SystemConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_SystemConsole.Location = new System.Drawing.Point(0, 24);
            this.richTextBox_SystemConsole.Multiline = false;
            this.richTextBox_SystemConsole.Name = "richTextBox_SystemConsole";
            this.richTextBox_SystemConsole.ReadOnly = true;
            this.richTextBox_SystemConsole.Size = new System.Drawing.Size(578, 101);
            this.richTextBox_SystemConsole.TabIndex = 1;
            this.richTextBox_SystemConsole.TabStop = false;
            this.richTextBox_SystemConsole.Text = "";
            // 
            // SystemConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 125);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox_SystemConsole);
            this.Controls.Add(this.menuStrip_SystemConsole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemConsole";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "시스템 메세지";
            this.Load += new System.EventHandler(this.SystemConsole_Load_Event);
            this.menuStrip_SystemConsole.ResumeLayout(false);
            this.menuStrip_SystemConsole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_SystemConsole;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SystemConsole_Tray;
        public System.Windows.Forms.RichTextBox richTextBox_SystemConsole;
    }
}