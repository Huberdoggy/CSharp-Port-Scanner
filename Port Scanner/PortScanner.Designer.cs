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
            this.foundIpLbl = new System.Windows.Forms.Label();
            this.ipListBox = new System.Windows.Forms.ListBox();
            this.getIPButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.portInfoPage = new System.Windows.Forms.TabPage();
            this.materialTabSelect = new MaterialSkin.Controls.MaterialTabSelector();
            this.exitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clearButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.foundIpLblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.tabToggle.SuspendLayout();
            this.ipInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialSkinTitleLbl
            // 
            this.materialSkinTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.materialSkinTitleLbl.Depth = 0;
            this.materialSkinTitleLbl.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ipListBox.TabIndex = 1;
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
            this.portInfoPage.Location = new System.Drawing.Point(4, 28);
            this.portInfoPage.Name = "portInfoPage";
            this.portInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.portInfoPage.Size = new System.Drawing.Size(518, 256);
            this.portInfoPage.TabIndex = 1;
            this.portInfoPage.Text = "Scanner";
            this.portInfoPage.UseVisualStyleBackColor = true;
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
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // foundIpLblDesc
            // 
            this.foundIpLblDesc.AutoSize = true;
            this.foundIpLblDesc.BackColor = System.Drawing.SystemColors.Highlight;
            this.foundIpLblDesc.Depth = 0;
            this.foundIpLblDesc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundIpLblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foundIpLblDesc.Location = new System.Drawing.Point(367, 24);
            this.foundIpLblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.foundIpLblDesc.Name = "foundIpLblDesc";
            this.foundIpLblDesc.Size = new System.Drawing.Size(87, 19);
            this.foundIpLblDesc.TabIndex = 6;
            this.foundIpLblDesc.Text = "Found IPs:";
            this.foundIpLblDesc.Visible = false;
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
            this.tabToggle.ResumeLayout(false);
            this.ipInfoPage.ResumeLayout(false);
            this.ipInfoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialSkinTitleLbl;
        private MaterialSkin.Controls.MaterialTabControl tabToggle;
        private System.Windows.Forms.TabPage ipInfoPage;
        private System.Windows.Forms.TabPage portInfoPage;
        private MaterialSkin.Controls.MaterialRaisedButton getIPButton;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelect;
        private System.Windows.Forms.ListBox ipListBox;
        private System.Windows.Forms.Label foundIpLbl;
        private MaterialSkin.Controls.MaterialRaisedButton clearButton;
        private MaterialSkin.Controls.MaterialRaisedButton exitButton;
        private MaterialSkin.Controls.MaterialLabel foundIpLblDesc;
    }
}

