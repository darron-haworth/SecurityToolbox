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
            this.lblTabHeader = new System.Windows.Forms.Label();
            this.lblElapsedValue = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.cbIncludeBlacklist = new System.Windows.Forms.CheckBox();
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
            this.txtEncodingHeader = new System.Windows.Forms.Label();
            this.btnXmlPretty = new System.Windows.Forms.Button();
            this.btnEncodingReset = new System.Windows.Forms.Button();
            this.btnUrlDecode = new System.Windows.Forms.Button();
            this.btnUrlEncode = new System.Windows.Forms.Button();
            this.btnB64Decode = new System.Windows.Forms.Button();
            this.btnB64Encode = new System.Windows.Forms.Button();
            this.btnHexDecode = new System.Windows.Forms.Button();
            this.btnHexEncode = new System.Windows.Forms.Button();
            this.lblEncodingOutputFieldText = new System.Windows.Forms.Label();
            this.txtEncodingOutput = new System.Windows.Forms.TextBox();
            this.lblEncodingInputFieldText = new System.Windows.Forms.Label();
            this.txtEncodingInput = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.iPLookupAPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.rootIpAddressLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabIpTools.SuspendLayout();
            this.ipTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIpResults)).BeginInit();
            this.encodingTools.SuspendLayout();
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
            this.ipTools.Controls.Add(this.lblTabHeader);
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
            this.ipTools.Text = "Public IP Lookup";
            this.ipTools.UseVisualStyleBackColor = true;
            // 
            // lblTabHeader
            // 
            this.lblTabHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTabHeader.AutoSize = true;
            this.lblTabHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTabHeader.Location = new System.Drawing.Point(805, 0);
            this.lblTabHeader.Name = "lblTabHeader";
            this.lblTabHeader.Size = new System.Drawing.Size(151, 27);
            this.lblTabHeader.TabIndex = 2;
            this.lblTabHeader.Text = "Public IP Lookup";
            this.lblTabHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTabHeader.UseCompatibleTextRendering = true;
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
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(946, 740);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(77, 13);
            this.lblElapsed.TabIndex = 15;
            this.lblElapsed.Text = "Elapsed Time: ";
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
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(638, 740);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(77, 13);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Lookup Count:";
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
            this.encodingTools.Controls.Add(this.txtEncodingHeader);
            this.encodingTools.Controls.Add(this.btnXmlPretty);
            this.encodingTools.Controls.Add(this.btnEncodingReset);
            this.encodingTools.Controls.Add(this.btnUrlDecode);
            this.encodingTools.Controls.Add(this.btnUrlEncode);
            this.encodingTools.Controls.Add(this.btnB64Decode);
            this.encodingTools.Controls.Add(this.btnB64Encode);
            this.encodingTools.Controls.Add(this.btnHexDecode);
            this.encodingTools.Controls.Add(this.btnHexEncode);
            this.encodingTools.Controls.Add(this.lblEncodingOutputFieldText);
            this.encodingTools.Controls.Add(this.txtEncodingOutput);
            this.encodingTools.Controls.Add(this.lblEncodingInputFieldText);
            this.encodingTools.Controls.Add(this.txtEncodingInput);
            this.encodingTools.Location = new System.Drawing.Point(4, 22);
            this.encodingTools.Name = "encodingTools";
            this.encodingTools.Size = new System.Drawing.Size(1842, 767);
            this.encodingTools.TabIndex = 1;
            this.encodingTools.Text = "Encoding Tools";
            this.encodingTools.UseVisualStyleBackColor = true;
            // 
            // txtEncodingHeader
            // 
            this.txtEncodingHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEncodingHeader.AutoSize = true;
            this.txtEncodingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncodingHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtEncodingHeader.Location = new System.Drawing.Point(811, 7);
            this.txtEncodingHeader.Name = "txtEncodingHeader";
            this.txtEncodingHeader.Size = new System.Drawing.Size(139, 27);
            this.txtEncodingHeader.TabIndex = 12;
            this.txtEncodingHeader.Text = "Encoding Tools";
            this.txtEncodingHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtEncodingHeader.UseCompatibleTextRendering = true;
            // 
            // btnXmlPretty
            // 
            this.btnXmlPretty.Location = new System.Drawing.Point(930, 685);
            this.btnXmlPretty.Name = "btnXmlPretty";
            this.btnXmlPretty.Size = new System.Drawing.Size(88, 23);
            this.btnXmlPretty.TabIndex = 11;
            this.btnXmlPretty.Text = "XML Format";
            this.btnXmlPretty.UseVisualStyleBackColor = true;
            this.btnXmlPretty.Click += new System.EventHandler(this.btnXmlPretty_Click);
            // 
            // btnEncodingReset
            // 
            this.btnEncodingReset.Location = new System.Drawing.Point(29, 685);
            this.btnEncodingReset.Name = "btnEncodingReset";
            this.btnEncodingReset.Size = new System.Drawing.Size(88, 23);
            this.btnEncodingReset.TabIndex = 10;
            this.btnEncodingReset.Text = "Reset Form";
            this.btnEncodingReset.UseVisualStyleBackColor = true;
            this.btnEncodingReset.Click += new System.EventHandler(this.btnEncodingReset_Click);
            // 
            // btnUrlDecode
            // 
            this.btnUrlDecode.Location = new System.Drawing.Point(709, 685);
            this.btnUrlDecode.Name = "btnUrlDecode";
            this.btnUrlDecode.Size = new System.Drawing.Size(88, 23);
            this.btnUrlDecode.TabIndex = 9;
            this.btnUrlDecode.Text = "URL Decode";
            this.btnUrlDecode.UseVisualStyleBackColor = true;
            this.btnUrlDecode.Click += new System.EventHandler(this.btnUrlDecode_Click);
            // 
            // btnUrlEncode
            // 
            this.btnUrlEncode.Location = new System.Drawing.Point(615, 685);
            this.btnUrlEncode.Name = "btnUrlEncode";
            this.btnUrlEncode.Size = new System.Drawing.Size(88, 23);
            this.btnUrlEncode.TabIndex = 8;
            this.btnUrlEncode.Text = "URL Encode";
            this.btnUrlEncode.UseVisualStyleBackColor = true;
            this.btnUrlEncode.Click += new System.EventHandler(this.btnUrlEncode_Click);
            // 
            // btnB64Decode
            // 
            this.btnB64Decode.Location = new System.Drawing.Point(478, 685);
            this.btnB64Decode.Name = "btnB64Decode";
            this.btnB64Decode.Size = new System.Drawing.Size(88, 23);
            this.btnB64Decode.TabIndex = 7;
            this.btnB64Decode.Text = "B64 Decode";
            this.btnB64Decode.UseVisualStyleBackColor = true;
            this.btnB64Decode.Click += new System.EventHandler(this.btnB64Decode_Click);
            // 
            // btnB64Encode
            // 
            this.btnB64Encode.Location = new System.Drawing.Point(384, 685);
            this.btnB64Encode.Name = "btnB64Encode";
            this.btnB64Encode.Size = new System.Drawing.Size(88, 23);
            this.btnB64Encode.TabIndex = 6;
            this.btnB64Encode.Text = "B64 Encode";
            this.btnB64Encode.UseVisualStyleBackColor = true;
            this.btnB64Encode.Click += new System.EventHandler(this.btnB64Encode_Click);
            // 
            // btnHexDecode
            // 
            this.btnHexDecode.Location = new System.Drawing.Point(257, 685);
            this.btnHexDecode.Name = "btnHexDecode";
            this.btnHexDecode.Size = new System.Drawing.Size(88, 23);
            this.btnHexDecode.TabIndex = 5;
            this.btnHexDecode.Text = "HEX Decode";
            this.btnHexDecode.UseVisualStyleBackColor = true;
            this.btnHexDecode.Click += new System.EventHandler(this.btnHexDecode_Click);
            // 
            // btnHexEncode
            // 
            this.btnHexEncode.Location = new System.Drawing.Point(163, 685);
            this.btnHexEncode.Name = "btnHexEncode";
            this.btnHexEncode.Size = new System.Drawing.Size(88, 23);
            this.btnHexEncode.TabIndex = 4;
            this.btnHexEncode.Text = "HEX Encode";
            this.btnHexEncode.UseVisualStyleBackColor = true;
            this.btnHexEncode.Click += new System.EventHandler(this.btnHexEncode_Click);
            // 
            // lblEncodingOutputFieldText
            // 
            this.lblEncodingOutputFieldText.AutoSize = true;
            this.lblEncodingOutputFieldText.Location = new System.Drawing.Point(29, 230);
            this.lblEncodingOutputFieldText.Name = "lblEncodingOutputFieldText";
            this.lblEncodingOutputFieldText.Size = new System.Drawing.Size(55, 13);
            this.lblEncodingOutputFieldText.TabIndex = 3;
            this.lblEncodingOutputFieldText.Text = "Input Text";
            // 
            // txtEncodingOutput
            // 
            this.txtEncodingOutput.Location = new System.Drawing.Point(29, 249);
            this.txtEncodingOutput.Multiline = true;
            this.txtEncodingOutput.Name = "txtEncodingOutput";
            this.txtEncodingOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncodingOutput.Size = new System.Drawing.Size(1790, 416);
            this.txtEncodingOutput.TabIndex = 2;
            // 
            // lblEncodingInputFieldText
            // 
            this.lblEncodingInputFieldText.AutoSize = true;
            this.lblEncodingInputFieldText.Location = new System.Drawing.Point(29, 21);
            this.lblEncodingInputFieldText.Name = "lblEncodingInputFieldText";
            this.lblEncodingInputFieldText.Size = new System.Drawing.Size(55, 13);
            this.lblEncodingInputFieldText.TabIndex = 1;
            this.lblEncodingInputFieldText.Text = "Input Text";
            // 
            // txtEncodingInput
            // 
            this.txtEncodingInput.Location = new System.Drawing.Point(29, 40);
            this.txtEncodingInput.Multiline = true;
            this.txtEncodingInput.Name = "txtEncodingInput";
            this.txtEncodingInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncodingInput.Size = new System.Drawing.Size(1790, 171);
            this.txtEncodingInput.TabIndex = 0;
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
            // rootIpAddressLookupBindingSource
            // 
            this.rootIpAddressLookupBindingSource.DataSource = typeof(SecurityToolbox.Models.RootIpAddressLookup);
            // 
            // SecToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1884, 889);
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
            this.encodingTools.ResumeLayout(false);
            this.encodingTools.PerformLayout();
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
        private System.Windows.Forms.Button btnXmlPretty;
        private System.Windows.Forms.Button btnEncodingReset;
        private System.Windows.Forms.Button btnUrlDecode;
        private System.Windows.Forms.Button btnUrlEncode;
        private System.Windows.Forms.Button btnB64Decode;
        private System.Windows.Forms.Button btnB64Encode;
        private System.Windows.Forms.Button btnHexDecode;
        private System.Windows.Forms.Button btnHexEncode;
        private System.Windows.Forms.Label lblEncodingOutputFieldText;
        private System.Windows.Forms.TextBox txtEncodingOutput;
        private System.Windows.Forms.Label lblEncodingInputFieldText;
        private System.Windows.Forms.TextBox txtEncodingInput;
        private System.Windows.Forms.Label txtEncodingHeader;
    }
}

