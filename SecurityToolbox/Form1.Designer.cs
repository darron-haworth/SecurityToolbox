namespace SecurityToolbox
{
    partial class SecToolForm
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
            this.tabIpTools = new System.Windows.Forms.TabControl();
            this.ipTools = new System.Windows.Forms.TabPage();
            this.linkCopyIpToClip = new System.Windows.Forms.LinkLabel();
            this.txtIpApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIpReset = new System.Windows.Forms.Button();
            this.btnIpLookup = new System.Windows.Forms.Button();
            this.cboDelimeter = new System.Windows.Forms.ComboBox();
            this.lblOutputDelimeter = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtIpOutput = new System.Windows.Forms.TextBox();
            this.txtIpInput = new System.Windows.Forms.TextBox();
            this.encodingTools = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabIpTools.SuspendLayout();
            this.ipTools.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIpTools
            // 
            this.tabIpTools.Controls.Add(this.ipTools);
            this.tabIpTools.Controls.Add(this.encodingTools);
            this.tabIpTools.Location = new System.Drawing.Point(12, 39);
            this.tabIpTools.Name = "tabIpTools";
            this.tabIpTools.SelectedIndex = 0;
            this.tabIpTools.Size = new System.Drawing.Size(1351, 793);
            this.tabIpTools.TabIndex = 0;
            // 
            // ipTools
            // 
            this.ipTools.Controls.Add(this.linkCopyIpToClip);
            this.ipTools.Controls.Add(this.txtIpApiKey);
            this.ipTools.Controls.Add(this.label1);
            this.ipTools.Controls.Add(this.btnIpReset);
            this.ipTools.Controls.Add(this.btnIpLookup);
            this.ipTools.Controls.Add(this.cboDelimeter);
            this.ipTools.Controls.Add(this.lblOutputDelimeter);
            this.ipTools.Controls.Add(this.lblOutput);
            this.ipTools.Controls.Add(this.lblInput);
            this.ipTools.Controls.Add(this.txtIpOutput);
            this.ipTools.Controls.Add(this.txtIpInput);
            this.ipTools.Location = new System.Drawing.Point(4, 22);
            this.ipTools.Name = "ipTools";
            this.ipTools.Size = new System.Drawing.Size(1343, 767);
            this.ipTools.TabIndex = 0;
            this.ipTools.Text = "IP Tools";
            this.ipTools.UseVisualStyleBackColor = true;
            // 
            // linkCopyIpToClip
            // 
            this.linkCopyIpToClip.AutoSize = true;
            this.linkCopyIpToClip.Location = new System.Drawing.Point(1138, 734);
            this.linkCopyIpToClip.Name = "linkCopyIpToClip";
            this.linkCopyIpToClip.Size = new System.Drawing.Size(122, 13);
            this.linkCopyIpToClip.TabIndex = 10;
            this.linkCopyIpToClip.TabStop = true;
            this.linkCopyIpToClip.Text = "Copy output to clipboard";
            // 
            // txtIpApiKey
            // 
            this.txtIpApiKey.Location = new System.Drawing.Point(675, 734);
            this.txtIpApiKey.Name = "txtIpApiKey";
            this.txtIpApiKey.Size = new System.Drawing.Size(297, 20);
            this.txtIpApiKey.TabIndex = 9;
            this.txtIpApiKey.Text = "Loads from App.config";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 739);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "API Key:";
            // 
            // btnIpReset
            // 
            this.btnIpReset.Location = new System.Drawing.Point(293, 730);
            this.btnIpReset.Name = "btnIpReset";
            this.btnIpReset.Size = new System.Drawing.Size(75, 23);
            this.btnIpReset.TabIndex = 7;
            this.btnIpReset.Text = "Reset Form";
            this.btnIpReset.UseVisualStyleBackColor = true;
            // 
            // btnIpLookup
            // 
            this.btnIpLookup.Location = new System.Drawing.Point(202, 731);
            this.btnIpLookup.Name = "btnIpLookup";
            this.btnIpLookup.Size = new System.Drawing.Size(75, 23);
            this.btnIpLookup.TabIndex = 6;
            this.btnIpLookup.Text = "IP Lookup";
            this.btnIpLookup.UseVisualStyleBackColor = true;
            // 
            // cboDelimeter
            // 
            this.cboDelimeter.FormattingEnabled = true;
            this.cboDelimeter.Items.AddRange(new object[] {
            "Tab",
            "Comma"});
            this.cboDelimeter.Location = new System.Drawing.Point(114, 731);
            this.cboDelimeter.Name = "cboDelimeter";
            this.cboDelimeter.Size = new System.Drawing.Size(67, 21);
            this.cboDelimeter.TabIndex = 5;
            this.cboDelimeter.Text = "Tab";
            // 
            // lblOutputDelimeter
            // 
            this.lblOutputDelimeter.AutoSize = true;
            this.lblOutputDelimeter.Location = new System.Drawing.Point(18, 734);
            this.lblOutputDelimeter.Name = "lblOutputDelimeter";
            this.lblOutputDelimeter.Size = new System.Drawing.Size(89, 13);
            this.lblOutputDelimeter.TabIndex = 4;
            this.lblOutputDelimeter.Text = "Output Delimeter:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(204, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 13);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(102, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input - IP Addresses";
            // 
            // txtIpOutput
            // 
            this.txtIpOutput.Location = new System.Drawing.Point(202, 32);
            this.txtIpOutput.MaxLength = 3196602;
            this.txtIpOutput.Multiline = true;
            this.txtIpOutput.Name = "txtIpOutput";
            this.txtIpOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIpOutput.Size = new System.Drawing.Size(1058, 678);
            this.txtIpOutput.TabIndex = 1;
            // 
            // txtIpInput
            // 
            this.txtIpInput.Location = new System.Drawing.Point(18, 32);
            this.txtIpInput.MaxLength = 2196602;
            this.txtIpInput.Multiline = true;
            this.txtIpInput.Name = "txtIpInput";
            this.txtIpInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIpInput.Size = new System.Drawing.Size(163, 678);
            this.txtIpInput.TabIndex = 0;
            // 
            // encodingTools
            // 
            this.encodingTools.Location = new System.Drawing.Point(4, 22);
            this.encodingTools.Name = "encodingTools";
            this.encodingTools.Size = new System.Drawing.Size(1343, 767);
            this.encodingTools.TabIndex = 1;
            this.encodingTools.Text = "Encoding Tools";
            this.encodingTools.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1375, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SecToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1375, 844);
            this.Controls.Add(this.tabIpTools);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SecToolForm";
            this.Text = "Security Toolbox";
            this.tabIpTools.ResumeLayout(false);
            this.ipTools.ResumeLayout(false);
            this.ipTools.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabIpTools;
        private System.Windows.Forms.TabPage ipTools;
        private System.Windows.Forms.LinkLabel linkCopyIpToClip;
        private System.Windows.Forms.TextBox txtIpApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIpReset;
        private System.Windows.Forms.Button btnIpLookup;
        private System.Windows.Forms.ComboBox cboDelimeter;
        private System.Windows.Forms.Label lblOutputDelimeter;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtIpOutput;
        private System.Windows.Forms.TextBox txtIpInput;
        private System.Windows.Forms.TabPage encodingTools;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

