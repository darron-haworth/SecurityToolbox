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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecToolForm));
            this.tabIpTools = new System.Windows.Forms.TabControl();
            this.ipTools = new System.Windows.Forms.TabPage();
            this.dgIpResults = new System.Windows.Forms.DataGridView();
            this.linkCopyIpToClip = new System.Windows.Forms.LinkLabel();
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
            this.tsFileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.iPLookupAPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTabHeader = new System.Windows.Forms.Label();
            this.rootIpAddressLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbIncludeBlacklist = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblElapsedValue = new System.Windows.Forms.Label();
            this.tabIpTools.SuspendLayout();
            this.ipTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIpResults)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootIpAddressLookupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIpTools
            // 
            this.tabIpTools.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabIpTools.Controls.Add(this.ipTools);
            this.tabIpTools.Controls.Add(this.encodingTools);
            this.tabIpTools.Location = new System.Drawing.Point(5, 47);
            this.tabIpTools.Name = "tabIpTools";
            this.tabIpTools.SelectedIndex = 0;
            this.tabIpTools.Size = new System.Drawing.Size(1850, 793);
            this.tabIpTools.TabIndex = 0;
            this.tabIpTools.SelectedIndexChanged += new System.EventHandler(this.tabIpTools_SelectedIndexChanged);
            // 
            // ipTools
            // 
            this.ipTools.Controls.Add(this.lblElapsedValue);
            this.ipTools.Controls.Add(this.lblElapsed);
            this.ipTools.Controls.Add(this.lblCountValue);
            this.ipTools.Controls.Add(this.lblCount);
            this.ipTools.Controls.Add(this.cbIncludeBlacklist);
            this.ipTools.Controls.Add(this.dgIpResults);
            this.ipTools.Controls.Add(this.linkCopyIpToClip);
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
            this.ipTools.Size = new System.Drawing.Size(1842, 767);
            this.ipTools.TabIndex = 0;
            this.ipTools.Text = "IP Tools";
            this.ipTools.UseVisualStyleBackColor = true;
            // 
            // dgIpResults
            // 
            this.dgIpResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgIpResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIpResults.Location = new System.Drawing.Point(202, 32);
            this.dgIpResults.Name = "dgIpResults";
            this.dgIpResults.Size = new System.Drawing.Size(1618, 693);
            this.dgIpResults.TabIndex = 11;
            // 
            // linkCopyIpToClip
            // 
            this.linkCopyIpToClip.AutoSize = true;
            this.linkCopyIpToClip.Location = new System.Drawing.Point(1698, 734);
            this.linkCopyIpToClip.Name = "linkCopyIpToClip";
            this.linkCopyIpToClip.Size = new System.Drawing.Size(122, 13);
            this.linkCopyIpToClip.TabIndex = 10;
            this.linkCopyIpToClip.TabStop = true;
            this.linkCopyIpToClip.Text = "Copy output to clipboard";
            this.linkCopyIpToClip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopyIpToClip_LinkClicked);
            // 
            // btnIpReset
            // 
            this.btnIpReset.Location = new System.Drawing.Point(283, 731);
            this.btnIpReset.Name = "btnIpReset";
            this.btnIpReset.Size = new System.Drawing.Size(75, 23);
            this.btnIpReset.TabIndex = 7;
            this.btnIpReset.Text = "Reset Form";
            this.btnIpReset.UseVisualStyleBackColor = true;
            this.btnIpReset.Click += new System.EventHandler(this.btnIpReset_Click);
            // 
            // btnIpLookup
            // 
            this.btnIpLookup.Location = new System.Drawing.Point(202, 731);
            this.btnIpLookup.Name = "btnIpLookup";
            this.btnIpLookup.Size = new System.Drawing.Size(75, 23);
            this.btnIpLookup.TabIndex = 6;
            this.btnIpLookup.Text = "IP Lookup";
            this.btnIpLookup.UseVisualStyleBackColor = true;
            this.btnIpLookup.Click += new System.EventHandler(this.btnIpLookup_Click);
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
            this.txtIpOutput.Location = new System.Drawing.Point(1663, 32);
            this.txtIpOutput.MaxLength = 3196602;
            this.txtIpOutput.Multiline = true;
            this.txtIpOutput.Name = "txtIpOutput";
            this.txtIpOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIpOutput.Size = new System.Drawing.Size(45, 678);
            this.txtIpOutput.TabIndex = 1;
            this.txtIpOutput.Visible = false;
            // 
            // txtIpInput
            // 
            this.txtIpInput.Location = new System.Drawing.Point(18, 32);
            this.txtIpInput.MaxLength = 2196602;
            this.txtIpInput.Multiline = true;
            this.txtIpInput.Name = "txtIpInput";
            this.txtIpInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIpInput.Size = new System.Drawing.Size(163, 693);
            this.txtIpInput.TabIndex = 0;
            // 
            // encodingTools
            // 
            this.encodingTools.Location = new System.Drawing.Point(4, 22);
            this.encodingTools.Name = "encodingTools";
            this.encodingTools.Size = new System.Drawing.Size(1842, 767);
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
            this.menuStrip.Size = new System.Drawing.Size(1884, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileOptions,
            this.tsExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsFileOptions
            // 
            this.tsFileOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPLookupAPIKeyToolStripMenuItem});
            this.tsFileOptions.Name = "tsFileOptions";
            this.tsFileOptions.Size = new System.Drawing.Size(116, 22);
            this.tsFileOptions.Text = "Options";
            // 
            // iPLookupAPIKeyToolStripMenuItem
            // 
            this.iPLookupAPIKeyToolStripMenuItem.Name = "iPLookupAPIKeyToolStripMenuItem";
            this.iPLookupAPIKeyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.iPLookupAPIKeyToolStripMenuItem.Text = "IP Lookup API Key";
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(116, 22);
            this.tsExit.Text = "Exit";
            // 
            // lblTabHeader
            // 
            this.lblTabHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTabHeader.AutoSize = true;
            this.lblTabHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTabHeader.Location = new System.Drawing.Point(833, 32);
            this.lblTabHeader.Name = "lblTabHeader";
            this.lblTabHeader.Size = new System.Drawing.Size(187, 34);
            this.lblTabHeader.TabIndex = 2;
            this.lblTabHeader.Text = "IP Lookup Tools";
            this.lblTabHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTabHeader.UseCompatibleTextRendering = true;
            // 
            // rootIpAddressLookupBindingSource
            // 
            this.rootIpAddressLookupBindingSource.DataSource = typeof(SecurityToolbox.Models.RootIpAddressLookup);
            // 
            // cbIncludeBlacklist
            // 
            this.cbIncludeBlacklist.AutoSize = true;
            this.cbIncludeBlacklist.Location = new System.Drawing.Point(422, 736);
            this.cbIncludeBlacklist.Name = "cbIncludeBlacklist";
            this.cbIncludeBlacklist.Size = new System.Drawing.Size(163, 17);
            this.cbIncludeBlacklist.TabIndex = 12;
            this.cbIncludeBlacklist.Text = "Include Blacklist Info (slower)";
            this.cbIncludeBlacklist.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(638, 740);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(77, 13);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Lookup Count:";
            // 
            // lblCountValue
            // 
            this.lblCountValue.AutoSize = true;
            this.lblCountValue.Location = new System.Drawing.Point(713, 740);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblCountValue.TabIndex = 14;
            this.lblCountValue.Text = "1";
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(946, 740);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(77, 13);
            this.lblElapsed.TabIndex = 15;
            this.lblElapsed.Text = "Elapsed Time: ";
            // 
            // lblElapsedValue
            // 
            this.lblElapsedValue.AutoSize = true;
            this.lblElapsedValue.Location = new System.Drawing.Point(1018, 740);
            this.lblElapsedValue.Name = "lblElapsedValue";
            this.lblElapsedValue.Size = new System.Drawing.Size(28, 13);
            this.lblElapsedValue.TabIndex = 16;
            this.lblElapsedValue.Text = "0:00";
            // 
            // SecToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1884, 889);
            this.Controls.Add(this.lblTabHeader);
            this.Controls.Add(this.tabIpTools);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SecToolForm";
            this.Text = "Security Toolbox";
            this.tabIpTools.ResumeLayout(false);
            this.ipTools.ResumeLayout(false);
            this.ipTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIpResults)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootIpAddressLookupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabIpTools;
        private System.Windows.Forms.TabPage ipTools;
        private System.Windows.Forms.LinkLabel linkCopyIpToClip;
        private System.Windows.Forms.Button btnIpReset;
        private System.Windows.Forms.Button btnIpLookup;
        private System.Windows.Forms.ComboBox cboDelimeter;
        private System.Windows.Forms.Label lblOutputDelimeter;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtIpInput;
        private System.Windows.Forms.TabPage encodingTools;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsFileOptions;
        private System.Windows.Forms.ToolStripMenuItem iPLookupAPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Label lblTabHeader;
        private System.Windows.Forms.TextBox txtIpOutput;
        private System.Windows.Forms.BindingSource rootIpAddressLookupBindingSource;
        private System.Windows.Forms.DataGridView dgIpResults;
        private System.Windows.Forms.CheckBox cbIncludeBlacklist;
        private System.Windows.Forms.Label lblElapsedValue;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Label lblCount;
    }
}

