namespace QuickPictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Previous");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Node22");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Node23");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Node24");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Node25");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Node26");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Node27");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Node28");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Node29");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Node30");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tvSubFolders = new System.Windows.Forms.TreeView();
            this.lsbImages = new System.Windows.Forms.ListBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPixels = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxPicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiOpenPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchOptions = new System.Windows.Forms.ComboBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerDelaySearch = new System.Windows.Forms.Timer(this.components);
            this.btnPinning = new System.Windows.Forms.Button();
            this.panelTouchSensor = new System.Windows.Forms.Panel();
            this.timerHideSidebar = new System.Windows.Forms.Timer(this.components);
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.ctxPicture.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnZoomOut);
            this.splitContainer1.Panel2.Controls.Add(this.btnFullScreen);
            this.splitContainer1.Panel2.Controls.Add(this.btnZoomIn);
            this.splitContainer1.Panel2.Controls.Add(this.panelTouchSensor);
            this.splitContainer1.Panel2.Controls.Add(this.btnNext);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrevious);
            this.splitContainer1.Panel2.Controls.Add(this.picImage);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 636);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsbImages);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 536);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPinning);
            this.panel1.Controls.Add(this.tvSubFolders);
            this.panel1.Controls.Add(this.btnSelectFolder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panel1.Size = new System.Drawing.Size(288, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "資料夾";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvSubFolders
            // 
            this.tvSubFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSubFolders.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tvSubFolders.Location = new System.Drawing.Point(8, 48);
            this.tvSubFolders.Margin = new System.Windows.Forms.Padding(6);
            this.tvSubFolders.Name = "tvSubFolders";
            treeNode81.Name = "Node21";
            treeNode81.Text = "Previous";
            treeNode82.Name = "Node22";
            treeNode82.Text = "Node22";
            treeNode83.Name = "Node23";
            treeNode83.Text = "Node23";
            treeNode84.Name = "Node24";
            treeNode84.Text = "Node24";
            treeNode85.Name = "Node25";
            treeNode85.Text = "Node25";
            treeNode86.Name = "Node26";
            treeNode86.Text = "Node26";
            treeNode87.Name = "Node27";
            treeNode87.Text = "Node27";
            treeNode88.Name = "Node28";
            treeNode88.Text = "Node28";
            treeNode89.Name = "Node29";
            treeNode89.Text = "Node29";
            treeNode90.Name = "Node30";
            treeNode90.Text = "Node30";
            this.tvSubFolders.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90});
            this.tvSubFolders.Size = new System.Drawing.Size(272, 48);
            this.tvSubFolders.TabIndex = 2;
            this.tvSubFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSubFolders_AfterSelect);
            // 
            // lsbImages
            // 
            this.lsbImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbImages.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lsbImages.FormattingEnabled = true;
            this.lsbImages.ItemHeight = 20;
            this.lsbImages.Items.AddRange(new object[] {
            "圖片清單:"});
            this.lsbImages.Location = new System.Drawing.Point(0, 58);
            this.lsbImages.Name = "lsbImages";
            this.lsbImages.Size = new System.Drawing.Size(288, 478);
            this.lsbImages.TabIndex = 0;
            this.lsbImages.SelectedIndexChanged += new System.EventHandler(this.lsbImages_SelectedIndexChanged);
            // 
            // picImage
            // 
            this.picImage.ContextMenuStrip = this.ctxPicture;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(893, 611);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picImage_MouseMove);
            this.picImage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.picImage_PreviewKeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblPixels,
            this.toolStripStatusLabel3,
            this.lblSize,
            this.toolStripStatusLabel5,
            this.lblLocation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(893, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(10, 9);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(71, 37);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<-";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(810, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 37);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel1.Text = "尺寸:";
            // 
            // lblPixels
            // 
            this.lblPixels.ForeColor = System.Drawing.Color.Blue;
            this.lblPixels.Name = "lblPixels";
            this.lblPixels.Size = new System.Drawing.Size(89, 20);
            this.lblPixels.Text = "1920x1024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(77, 20);
            this.toolStripStatusLabel3.Text = "圖片大小:";
            // 
            // ctxPicture
            // 
            this.ctxPicture.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ctxPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenPicture});
            this.ctxPicture.Name = "ctxPicture";
            this.ctxPicture.Size = new System.Drawing.Size(230, 28);
            // 
            // lblSize
            // 
            this.lblSize.ForeColor = System.Drawing.Color.Blue;
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(56, 20);
            this.lblSize.Text = "2.0MB";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(77, 20);
            this.toolStripStatusLabel5.Text = "圖片位置:";
            // 
            // lblLocation
            // 
            this.lblLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblLocation.ForeColor = System.Drawing.Color.Blue;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(534, 20);
            this.lblLocation.Spring = true;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiOpenPicture
            // 
            this.tsmiOpenPicture.Name = "tsmiOpenPicture";
            this.tsmiOpenPicture.Size = new System.Drawing.Size(229, 24);
            this.tsmiOpenPicture.Text = "在圖片檢視器開啓(&O)";
            this.tsmiOpenPicture.Click += new System.EventHandler(this.tsmiOpenPicture_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.cboSearchOptions);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 58);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label2.Size = new System.Drawing.Size(288, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "搜尋";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearch.Location = new System.Drawing.Point(0, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboSearchOptions
            // 
            this.cboSearchOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchOptions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSearchOptions.FormattingEnabled = true;
            this.cboSearchOptions.Items.AddRange(new object[] {
            "包含",
            "開頭",
            "結尾"});
            this.cboSearchOptions.Location = new System.Drawing.Point(209, 20);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.Size = new System.Drawing.Size(79, 28);
            this.cboSearchOptions.TabIndex = 2;
            this.cboSearchOptions.SelectedIndexChanged += new System.EventHandler(this.cboSearchOptions_SelectedIndexChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectFolder.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectFolder.Location = new System.Drawing.Point(8, 25);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(272, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = ">>> 選擇資料夾";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.TextChanged += new System.EventHandler(this.btnSelectFolder_TextChanged);
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "選擇圖片資料夾";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // timerDelaySearch
            // 
            this.timerDelaySearch.Interval = 2000;
            this.timerDelaySearch.Tick += new System.EventHandler(this.timerDelaySearch_Tick);
            // 
            // btnPinning
            // 
            this.btnPinning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPinning.Location = new System.Drawing.Point(232, 3);
            this.btnPinning.Name = "btnPinning";
            this.btnPinning.Size = new System.Drawing.Size(48, 23);
            this.btnPinning.TabIndex = 4;
            this.btnPinning.Text = "釘選";
            this.btnPinning.UseVisualStyleBackColor = true;
            this.btnPinning.Click += new System.EventHandler(this.btnPinning_Click);
            // 
            // panelTouchSensor
            // 
            this.panelTouchSensor.BackColor = System.Drawing.Color.Transparent;
            this.panelTouchSensor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTouchSensor.Location = new System.Drawing.Point(0, 0);
            this.panelTouchSensor.Name = "panelTouchSensor";
            this.panelTouchSensor.Size = new System.Drawing.Size(20, 611);
            this.panelTouchSensor.TabIndex = 3;
            this.panelTouchSensor.MouseHover += new System.EventHandler(this.panelTouchSensor_MouseHover);
            // 
            // timerHideSidebar
            // 
            this.timerHideSidebar.Interval = 3000;
            this.timerHideSidebar.Tick += new System.EventHandler(this.timerHideSidebar_Tick);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.BackColor = System.Drawing.Color.Green;
            this.btnZoomIn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnZoomIn.Location = new System.Drawing.Point(841, 529);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(34, 34);
            this.btnZoomIn.TabIndex = 4;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnZoomOut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnZoomOut.Location = new System.Drawing.Point(841, 567);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(34, 34);
            this.btnZoomOut.TabIndex = 4;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(147)))));
            this.btnFullScreen.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFullScreen.Location = new System.Drawing.Point(841, 491);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(34, 34);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.Text = "囗";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickPictureViewer - 簡易圖片瀏覽器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctxPicture.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lsbImages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboSearchOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvSubFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPixels;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblLocation;
        private System.Windows.Forms.ContextMenuStrip ctxPicture;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenPicture;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timerDelaySearch;
        private System.Windows.Forms.Button btnPinning;
        private System.Windows.Forms.Panel panelTouchSensor;
        private System.Windows.Forms.Timer timerHideSidebar;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnFullScreen;
    }
}

