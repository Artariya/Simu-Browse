
namespace Simu_Browse
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.checkBoxFixSize = new System.Windows.Forms.CheckBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.buttonShortcut = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBoxDevices = new System.Windows.Forms.GroupBox();
            this.buttonSelectDevice = new System.Windows.Forms.Button();
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.tabPageWebData = new System.Windows.Forms.TabPage();
            this.buttonDeleteDevice = new System.Windows.Forms.Button();
            this.buttonAddDevice = new System.Windows.Forms.Button();
            this.splitContainerSettings = new System.Windows.Forms.SplitContainer();
            this.groupBoxFeatures = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBoxDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSettings)).BeginInit();
            this.splitContainerSettings.Panel1.SuspendLayout();
            this.splitContainerSettings.Panel2.SuspendLayout();
            this.splitContainerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBrowser
            // 
            this.panelBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBrowser.Location = new System.Drawing.Point(8, 32);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(440, 485);
            this.panelBrowser.TabIndex = 0;
            this.panelBrowser.SizeChanged += new System.EventHandler(this.panelBrowser_SizeChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnter.Location = new System.Drawing.Point(373, 6);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(6, 6);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(223, 20);
            this.textBoxUrl.TabIndex = 2;
            // 
            // checkBoxFixSize
            // 
            this.checkBoxFixSize.AutoSize = true;
            this.checkBoxFixSize.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFixSize.Name = "checkBoxFixSize";
            this.checkBoxFixSize.Size = new System.Drawing.Size(90, 17);
            this.checkBoxFixSize.TabIndex = 3;
            this.checkBoxFixSize.Text = "Fixed tab size";
            this.checkBoxFixSize.UseVisualStyleBackColor = true;
            this.checkBoxFixSize.CheckedChanged += new System.EventHandler(this.checkBoxFixSize_CheckedChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageBrowser);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tabPageWebData);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(464, 551);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageBrowser
            // 
            this.tabPageBrowser.Controls.Add(this.buttonShortcut);
            this.tabPageBrowser.Controls.Add(this.buttonForward);
            this.tabPageBrowser.Controls.Add(this.buttonBackward);
            this.tabPageBrowser.Controls.Add(this.textBoxUrl);
            this.tabPageBrowser.Controls.Add(this.buttonEnter);
            this.tabPageBrowser.Controls.Add(this.panelBrowser);
            this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrowser.Name = "tabPageBrowser";
            this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrowser.Size = new System.Drawing.Size(456, 525);
            this.tabPageBrowser.TabIndex = 0;
            this.tabPageBrowser.Text = "Browser";
            this.tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // buttonShortcut
            // 
            this.buttonShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShortcut.Location = new System.Drawing.Point(235, 6);
            this.buttonShortcut.Name = "buttonShortcut";
            this.buttonShortcut.Size = new System.Drawing.Size(67, 23);
            this.buttonShortcut.TabIndex = 5;
            this.buttonShortcut.Text = "Shortcut";
            this.buttonShortcut.UseVisualStyleBackColor = true;
            this.buttonShortcut.Click += new System.EventHandler(this.buttonShortcut_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForward.Location = new System.Drawing.Point(340, 6);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(27, 23);
            this.buttonForward.TabIndex = 4;
            this.buttonForward.Text = ">";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackward.Location = new System.Drawing.Point(308, 6);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(27, 23);
            this.buttonBackward.TabIndex = 3;
            this.buttonBackward.Text = "<";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.splitContainerSettings);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(456, 525);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxDevices
            // 
            this.groupBoxDevices.Controls.Add(this.buttonAddDevice);
            this.groupBoxDevices.Controls.Add(this.buttonDeleteDevice);
            this.groupBoxDevices.Controls.Add(this.buttonSelectDevice);
            this.groupBoxDevices.Controls.Add(this.dataGridViewDevices);
            this.groupBoxDevices.Controls.Add(this.checkBoxFixSize);
            this.groupBoxDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDevices.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDevices.Name = "groupBoxDevices";
            this.groupBoxDevices.Size = new System.Drawing.Size(450, 351);
            this.groupBoxDevices.TabIndex = 4;
            this.groupBoxDevices.TabStop = false;
            this.groupBoxDevices.Text = "Devices";
            // 
            // buttonSelectDevice
            // 
            this.buttonSelectDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectDevice.Location = new System.Drawing.Point(340, 15);
            this.buttonSelectDevice.Name = "buttonSelectDevice";
            this.buttonSelectDevice.Size = new System.Drawing.Size(104, 23);
            this.buttonSelectDevice.TabIndex = 5;
            this.buttonSelectDevice.Text = "Select Device";
            this.buttonSelectDevice.UseVisualStyleBackColor = true;
            this.buttonSelectDevice.Click += new System.EventHandler(this.buttonSelectDevice_Click);
            // 
            // dataGridViewDevices
            // 
            this.dataGridViewDevices.AllowUserToAddRows = false;
            this.dataGridViewDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevices.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewDevices.MultiSelect = false;
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.RowHeadersVisible = false;
            this.dataGridViewDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDevices.Size = new System.Drawing.Size(444, 304);
            this.dataGridViewDevices.TabIndex = 4;
            this.dataGridViewDevices.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevices_CellEndEdit);
            // 
            // tabPageWebData
            // 
            this.tabPageWebData.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebData.Name = "tabPageWebData";
            this.tabPageWebData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebData.Size = new System.Drawing.Size(456, 525);
            this.tabPageWebData.TabIndex = 2;
            this.tabPageWebData.Text = "Web Data (coming soon)";
            this.tabPageWebData.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDevice
            // 
            this.buttonDeleteDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteDevice.Location = new System.Drawing.Point(259, 15);
            this.buttonDeleteDevice.Name = "buttonDeleteDevice";
            this.buttonDeleteDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDevice.TabIndex = 6;
            this.buttonDeleteDevice.Text = "Delete";
            this.buttonDeleteDevice.UseVisualStyleBackColor = true;
            this.buttonDeleteDevice.Click += new System.EventHandler(this.buttonDeleteDevice_Click);
            // 
            // buttonAddDevice
            // 
            this.buttonAddDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDevice.Location = new System.Drawing.Point(178, 15);
            this.buttonAddDevice.Name = "buttonAddDevice";
            this.buttonAddDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDevice.TabIndex = 7;
            this.buttonAddDevice.Text = "Add";
            this.buttonAddDevice.UseVisualStyleBackColor = true;
            this.buttonAddDevice.Click += new System.EventHandler(this.buttonAddDevice_Click);
            // 
            // splitContainerSettings
            // 
            this.splitContainerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSettings.Location = new System.Drawing.Point(3, 3);
            this.splitContainerSettings.Name = "splitContainerSettings";
            this.splitContainerSettings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSettings.Panel1
            // 
            this.splitContainerSettings.Panel1.Controls.Add(this.groupBoxDevices);
            // 
            // splitContainerSettings.Panel2
            // 
            this.splitContainerSettings.Panel2.Controls.Add(this.groupBoxFeatures);
            this.splitContainerSettings.Size = new System.Drawing.Size(450, 519);
            this.splitContainerSettings.SplitterDistance = 351;
            this.splitContainerSettings.TabIndex = 5;
            // 
            // groupBoxFeatures
            // 
            this.groupBoxFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFeatures.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFeatures.Name = "groupBoxFeatures";
            this.groupBoxFeatures.Size = new System.Drawing.Size(450, 164);
            this.groupBoxFeatures.TabIndex = 0;
            this.groupBoxFeatures.TabStop = false;
            this.groupBoxFeatures.Text = "Features (coming soon)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 551);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Simu Browse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageBrowser.ResumeLayout(false);
            this.tabPageBrowser.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBoxDevices.ResumeLayout(false);
            this.groupBoxDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
            this.splitContainerSettings.Panel1.ResumeLayout(false);
            this.splitContainerSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSettings)).EndInit();
            this.splitContainerSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBrowser;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxFixSize;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageBrowser;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.GroupBox groupBoxDevices;
        private System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.TabPage tabPageWebData;
        private System.Windows.Forms.Button buttonShortcut;
        private System.Windows.Forms.Button buttonSelectDevice;
        private System.Windows.Forms.Button buttonAddDevice;
        private System.Windows.Forms.Button buttonDeleteDevice;
        private System.Windows.Forms.SplitContainer splitContainerSettings;
        private System.Windows.Forms.GroupBox groupBoxFeatures;
    }
}

