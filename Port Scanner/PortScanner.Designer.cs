namespace Port_Scanner
{
    partial class PortScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortScanner));
            this.materialSkinTitleLbl = new MaterialSkin.Controls.MaterialLabel();
            this.tabToggle = new MaterialSkin.Controls.MaterialTabControl();
            this.ipInfoPage = new System.Windows.Forms.TabPage();
            this.proceedButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.foundIpLblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.clearButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.exitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.foundIpLbl = new System.Windows.Forms.Label();
            this.ipListBox = new System.Windows.Forms.ListBox();
            this.getIPButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.portInfoPage = new System.Windows.Forms.TabPage();
            this.scanProgressBar = new System.Windows.Forms.ProgressBar();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextbox = new System.Windows.Forms.TextBox();
            this.fromLabelDesc = new System.Windows.Forms.Label();
            this.toLabelDesc = new System.Windows.Forms.Label();
            this.ipAddressLabelDesc = new System.Windows.Forms.Label();
            this.scanPortsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.portCountListBox = new System.Windows.Forms.ListBox();
            this.materialTabSelect = new MaterialSkin.Controls.MaterialTabSelector();
            this.openPortsLabelDesc = new MaterialSkin.Controls.MaterialLabel();
            this.openPortsLabel = new System.Windows.Forms.Label();
            this.tabToggle.SuspendLayout();
            this.ipInfoPage.SuspendLayout();
            this.portInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialSkinTitleLbl
            // 
            this.materialSkinTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.materialSkinTitleLbl.Depth = 0;
            this.materialSkinTitleLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialSkinTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSkinTitleLbl.Location = new System.Drawing.Point(185, 1);
            this.materialSkinTitleLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSkinTitleLbl.Name = "materialSkinTitleLbl";
            this.materialSkinTitleLbl.Size = new System.Drawing.Size(156, 33);
            this.materialSkinTitleLbl.TabIndex = 0;
            this.materialSkinTitleLbl.Text = "Kyle\'s Port Scanner";
            // 
            // tabToggle
            // 
            this.tabToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabToggle.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabToggle.Controls.Add(this.ipInfoPage);
            this.tabToggle.Controls.Add(this.portInfoPage);
            this.tabToggle.Depth = 0;
            this.tabToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabToggle.Location = new System.Drawing.Point(2, 62);
            this.tabToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabToggle.Name = "tabToggle";
            this.tabToggle.SelectedIndex = 0;
            this.tabToggle.Size = new System.Drawing.Size(523, 288);
            this.tabToggle.TabIndex = 1;
            // 
            // ipInfoPage
            // 
            this.ipInfoPage.BackgroundImage = global::Port_Scanner.Properties.Resources.serverroom;
            this.ipInfoPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ipInfoPage.Controls.Add(this.proceedButton);
            this.ipInfoPage.Controls.Add(this.foundIpLblDesc);
            this.ipInfoPage.Controls.Add(this.clearButton);
            this.ipInfoPage.Controls.Add(this.exitButton);
            this.ipInfoPage.Controls.Add(this.foundIpLbl);
            this.ipInfoPage.Controls.Add(this.ipListBox);
            this.ipInfoPage.Controls.Add(this.getIPButton);
            this.ipInfoPage.Location = new System.Drawing.Point(4, 28);
            this.ipInfoPage.Name = "ipInfoPage";
            this.ipInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ipInfoPage.Size = new System.Drawing.Size(515, 256);
            this.ipInfoPage.TabIndex = 0;
            this.ipInfoPage.Text = "IP Info";
            this.ipInfoPage.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.AutoSize = true;
            this.proceedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.proceedButton.BackColor = System.Drawing.Color.Blue;
            this.proceedButton.Depth = 0;
            this.proceedButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proceedButton.Icon = null;
            this.proceedButton.Location = new System.Drawing.Point(180, 196);
            this.proceedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Primary = true;
            this.proceedButton.Size = new System.Drawing.Size(177, 36);
            this.proceedButton.TabIndex = 4;
            this.proceedButton.Text = "Proceed To Next Step";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Visible = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // foundIpLblDesc
            // 
            this.foundIpLblDesc.AutoSize = true;
            this.foundIpLblDesc.BackColor = System.Drawing.SystemColors.Highlight;
            this.foundIpLblDesc.Depth = 0;
            this.foundIpLblDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.foundIpLblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foundIpLblDesc.Location = new System.Drawing.Point(367, 24);
            this.foundIpLblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.foundIpLblDesc.Name = "foundIpLblDesc";
            this.foundIpLblDesc.Size = new System.Drawing.Size(79, 19);
            this.foundIpLblDesc.TabIndex = 6;
            this.foundIpLblDesc.Text = "Found IPs:";
            this.foundIpLblDesc.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearButton.BackColor = System.Drawing.Color.Blue;
            this.clearButton.Depth = 0;
            this.clearButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Icon = null;
            this.clearButton.Location = new System.Drawing.Point(23, 59);
            this.clearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearButton.Name = "clearButton";
            this.clearButton.Primary = true;
            this.clearButton.Size = new System.Drawing.Size(63, 36);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackColor = System.Drawing.Color.Blue;
            this.exitButton.Depth = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(96, 59);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Primary = true;
            this.exitButton.Size = new System.Drawing.Size(50, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // foundIpLbl
            // 
            this.foundIpLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.foundIpLbl.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundIpLbl.ForeColor = System.Drawing.Color.Blue;
            this.foundIpLbl.Location = new System.Drawing.Point(460, 17);
            this.foundIpLbl.Name = "foundIpLbl";
            this.foundIpLbl.Size = new System.Drawing.Size(39, 32);
            this.foundIpLbl.TabIndex = 3;
            this.foundIpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foundIpLbl.Visible = false;
            // 
            // ipListBox
            // 
            this.ipListBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipListBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.ipListBox.FormattingEnabled = true;
            this.ipListBox.ItemHeight = 17;
            this.ipListBox.Location = new System.Drawing.Point(191, 17);
            this.ipListBox.Name = "ipListBox";
            this.ipListBox.ScrollAlwaysVisible = true;
            this.ipListBox.Size = new System.Drawing.Size(166, 157);
            this.ipListBox.TabIndex = 3;
            // 
            // getIPButton
            // 
            this.getIPButton.AutoSize = true;
            this.getIPButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getIPButton.BackColor = System.Drawing.Color.Blue;
            this.getIPButton.Depth = 0;
            this.getIPButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIPButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getIPButton.Icon = null;
            this.getIPButton.Location = new System.Drawing.Point(15, 17);
            this.getIPButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getIPButton.Name = "getIPButton";
            this.getIPButton.Primary = true;
            this.getIPButton.Size = new System.Drawing.Size(150, 36);
            this.getIPButton.TabIndex = 0;
            this.getIPButton.Text = "Get My IP Address";
            this.getIPButton.UseVisualStyleBackColor = false;
            this.getIPButton.Click += new System.EventHandler(this.getIPButton_Click);
            // 
            // portInfoPage
            // 
            this.portInfoPage.Controls.Add(this.openPortsLabelDesc);
            this.portInfoPage.Controls.Add(this.openPortsLabel);
            this.portInfoPage.Controls.Add(this.scanProgressBar);
            this.portInfoPage.Controls.Add(this.fromTextBox);
            this.portInfoPage.Controls.Add(this.toTextBox);
            this.portInfoPage.Controls.Add(this.ipAddressTextbox);
            this.portInfoPage.Controls.Add(this.fromLabelDesc);
            this.portInfoPage.Controls.Add(this.toLabelDesc);
            this.portInfoPage.Controls.Add(this.ipAddressLabelDesc);
            this.portInfoPage.Controls.Add(this.scanPortsButton);
            this.portInfoPage.Controls.Add(this.portCountListBox);
            this.portInfoPage.Location = new System.Drawing.Point(4, 28);
            this.portInfoPage.Name = "portInfoPage";
            this.portInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.portInfoPage.Size = new System.Drawing.Size(515, 256);
            this.portInfoPage.TabIndex = 1;
            this.portInfoPage.Text = "Scanner";
            this.portInfoPage.UseVisualStyleBackColor = true;
            // 
            // scanProgressBar
            // 
            this.scanProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scanProgressBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scanProgressBar.Location = new System.Drawing.Point(19, 220);
            this.scanProgressBar.Name = "scanProgressBar";
            this.scanProgressBar.Size = new System.Drawing.Size(462, 29);
            this.scanProgressBar.Step = 2;
            this.scanProgressBar.TabIndex = 15;
            // 
            // fromTextBox
            // 
            this.fromTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fromTextBox.Location = new System.Drawing.Point(62, 56);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(56, 22);
            this.fromTextBox.TabIndex = 1;
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toTextBox.Location = new System.Drawing.Point(149, 56);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(56, 22);
            this.toTextBox.TabIndex = 2;
            // 
            // ipAddressTextbox
            // 
            this.ipAddressTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ipAddressTextbox.ForeColor = System.Drawing.Color.Blue;
            this.ipAddressTextbox.Location = new System.Drawing.Point(90, 18);
            this.ipAddressTextbox.Name = "ipAddressTextbox";
            this.ipAddressTextbox.Size = new System.Drawing.Size(100, 22);
            this.ipAddressTextbox.TabIndex = 0;
            // 
            // fromLabelDesc
            // 
            this.fromLabelDesc.AutoSize = true;
            this.fromLabelDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fromLabelDesc.Location = new System.Drawing.Point(16, 59);
            this.fromLabelDesc.Name = "fromLabelDesc";
            this.fromLabelDesc.Size = new System.Drawing.Size(39, 16);
            this.fromLabelDesc.TabIndex = 7;
            this.fromLabelDesc.Text = "From";
            // 
            // toLabelDesc
            // 
            this.toLabelDesc.AutoSize = true;
            this.toLabelDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toLabelDesc.Location = new System.Drawing.Point(124, 59);
            this.toLabelDesc.Name = "toLabelDesc";
            this.toLabelDesc.Size = new System.Drawing.Size(19, 16);
            this.toLabelDesc.TabIndex = 6;
            this.toLabelDesc.Text = "to";
            // 
            // ipAddressLabelDesc
            // 
            this.ipAddressLabelDesc.AutoSize = true;
            this.ipAddressLabelDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ipAddressLabelDesc.Location = new System.Drawing.Point(16, 21);
            this.ipAddressLabelDesc.Name = "ipAddressLabelDesc";
            this.ipAddressLabelDesc.Size = new System.Drawing.Size(77, 16);
            this.ipAddressLabelDesc.TabIndex = 5;
            this.ipAddressLabelDesc.Text = "IP Address:";
            // 
            // scanPortsButton
            // 
            this.scanPortsButton.AutoSize = true;
            this.scanPortsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scanPortsButton.BackColor = System.Drawing.Color.Blue;
            this.scanPortsButton.Depth = 0;
            this.scanPortsButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanPortsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scanPortsButton.Icon = null;
            this.scanPortsButton.Location = new System.Drawing.Point(231, 24);
            this.scanPortsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.scanPortsButton.Name = "scanPortsButton";
            this.scanPortsButton.Primary = true;
            this.scanPortsButton.Size = new System.Drawing.Size(104, 36);
            this.scanPortsButton.TabIndex = 3;
            this.scanPortsButton.Text = "Scan Ports";
            this.scanPortsButton.UseVisualStyleBackColor = false;
            this.scanPortsButton.Click += new System.EventHandler(this.scanPortsButton_Click);
            // 
            // portCountListBox
            // 
            this.portCountListBox.FormattingEnabled = true;
            this.portCountListBox.HorizontalExtent = 4;
            this.portCountListBox.ItemHeight = 16;
            this.portCountListBox.Location = new System.Drawing.Point(19, 82);
            this.portCountListBox.Name = "portCountListBox";
            this.portCountListBox.ScrollAlwaysVisible = true;
            this.portCountListBox.Size = new System.Drawing.Size(462, 132);
            this.portCountListBox.TabIndex = 4;
            // 
            // materialTabSelect
            // 
            this.materialTabSelect.BaseTabControl = this.tabToggle;
            this.materialTabSelect.Depth = 0;
            this.materialTabSelect.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialTabSelect.Location = new System.Drawing.Point(2, 26);
            this.materialTabSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelect.Name = "materialTabSelect";
            this.materialTabSelect.Size = new System.Drawing.Size(638, 30);
            this.materialTabSelect.TabIndex = 2;
            // 
            // openPortsLabelDesc
            // 
            this.openPortsLabelDesc.AutoSize = true;
            this.openPortsLabelDesc.BackColor = System.Drawing.SystemColors.Highlight;
            this.openPortsLabelDesc.Depth = 0;
            this.openPortsLabelDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.openPortsLabelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.openPortsLabelDesc.Location = new System.Drawing.Point(361, 19);
            this.openPortsLabelDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPortsLabelDesc.Name = "openPortsLabelDesc";
            this.openPortsLabelDesc.Size = new System.Drawing.Size(83, 38);
            this.openPortsLabelDesc.TabIndex = 17;
            this.openPortsLabelDesc.Text = "Open Ports\r\nFound:";
            this.openPortsLabelDesc.Visible = false;
            // 
            // openPortsLabel
            // 
            this.openPortsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openPortsLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortsLabel.ForeColor = System.Drawing.Color.Blue;
            this.openPortsLabel.Location = new System.Drawing.Point(450, 21);
            this.openPortsLabel.Name = "openPortsLabel";
            this.openPortsLabel.Size = new System.Drawing.Size(39, 32);
            this.openPortsLabel.TabIndex = 16;
            this.openPortsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openPortsLabel.Visible = false;
            // 
            // PortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(526, 351);
            this.Controls.Add(this.materialTabSelect);
            this.Controls.Add(this.tabToggle);
            this.Controls.Add(this.materialSkinTitleLbl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortScanner";
            this.Load += new System.EventHandler(this.PortScanner_Load);
            this.tabToggle.ResumeLayout(false);
            this.ipInfoPage.ResumeLayout(false);
            this.ipInfoPage.PerformLayout();
            this.portInfoPage.ResumeLayout(false);
            this.portInfoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialSkinTitleLbl;
        private MaterialSkin.Controls.MaterialTabControl tabToggle;
        private System.Windows.Forms.TabPage ipInfoPage;
        private System.Windows.Forms.TabPage portInfoPage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelect;
        private MaterialSkin.Controls.MaterialRaisedButton getIPButton;
        private System.Windows.Forms.ListBox ipListBox;
        private System.Windows.Forms.Label foundIpLbl;
        private MaterialSkin.Controls.MaterialRaisedButton clearButton;
        private MaterialSkin.Controls.MaterialRaisedButton exitButton;
        private MaterialSkin.Controls.MaterialLabel foundIpLblDesc;
        public MaterialSkin.Controls.MaterialRaisedButton scanPortsButton;
        public System.Windows.Forms.ListBox portCountListBox;
        private System.Windows.Forms.Label fromLabelDesc;
        private System.Windows.Forms.Label toLabelDesc;
        private System.Windows.Forms.Label ipAddressLabelDesc;
        private System.Windows.Forms.TextBox ipAddressTextbox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton proceedButton;
        private System.Windows.Forms.ProgressBar scanProgressBar;
        private MaterialSkin.Controls.MaterialLabel openPortsLabelDesc;
        private System.Windows.Forms.Label openPortsLabel;
    }
}

