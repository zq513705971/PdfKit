namespace PdfKit
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lbVer = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.lbHome = new System.Windows.Forms.Label();
            this.tabPageMegre = new System.Windows.Forms.TabPage();
            this.groupBoxMerge = new System.Windows.Forms.GroupBox();
            this.lbMergeMsg = new System.Windows.Forms.Label();
            this.btnMergeClear = new System.Windows.Forms.Button();
            this.btnMergePdf = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMergeDel = new System.Windows.Forms.Button();
            this.btnMergeAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxMerge = new System.Windows.Forms.ListBox();
            this.groupBoxSplit = new System.Windows.Forms.GroupBox();
            this.lbSplitMsg = new System.Windows.Forms.Label();
            this.btnSplitPdf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tPdfPages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectPdf = new System.Windows.Forms.Button();
            this.tPdfPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageWatermark = new System.Windows.Forms.TabPage();
            this.groupBoxWatermark = new System.Windows.Forms.GroupBox();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDoWatermark = new System.Windows.Forms.Button();
            this.tWatermark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectWatermarkPdf = new System.Windows.Forms.Button();
            this.tWatermarkPdf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageEncryption = new System.Windows.Forms.TabPage();
            this.groupBoxDecrypt = new System.Windows.Forms.GroupBox();
            this.btnRemovePassProtect = new System.Windows.Forms.Button();
            this.tDecryptEditPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDecryptPdf = new System.Windows.Forms.Button();
            this.tDecryptPdf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxEncrypt = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEncryptProtect = new System.Windows.Forms.Button();
            this.tEncryptReadPass = new System.Windows.Forms.TextBox();
            this.tEncryptEditPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEncryptPdf = new System.Windows.Forms.Button();
            this.tEncryptPdf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageViewer = new System.Windows.Forms.TabPage();
            this.pdfViewerMain = new PdfiumViewer.PdfViewer();
            this.backgroundWorkerSplit = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerMerge = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerWatermark = new System.ComponentModel.BackgroundWorker();
            this.tabControlMain.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.tabPageMegre.SuspendLayout();
            this.groupBoxMerge.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSplit.SuspendLayout();
            this.tabPageWatermark.SuspendLayout();
            this.groupBoxWatermark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.tabPageEncryption.SuspendLayout();
            this.groupBoxDecrypt.SuspendLayout();
            this.groupBoxEncrypt.SuspendLayout();
            this.tabPageViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMain.Controls.Add(this.tabPageHome);
            this.tabControlMain.Controls.Add(this.tabPageMegre);
            this.tabControlMain.Controls.Add(this.tabPageWatermark);
            this.tabControlMain.Controls.Add(this.tabPageEncryption);
            this.tabControlMain.Controls.Add(this.tabPageViewer);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.ItemSize = new System.Drawing.Size(40, 100);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(906, 517);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.panelHome);
            this.tabPageHome.Location = new System.Drawing.Point(104, 4);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(798, 509);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "首页";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.lbVer);
            this.panelHome.Controls.Add(this.lbCopyright);
            this.panelHome.Controls.Add(this.lbHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(792, 503);
            this.panelHome.TabIndex = 0;
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Location = new System.Drawing.Point(571, 471);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(142, 15);
            this.lbVer.TabIndex = 2;
            this.lbVer.Text = "version：1.0.5.21";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(571, 441);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(173, 15);
            this.lbCopyright.TabIndex = 1;
            this.lbCopyright.Text = "明月 513705971@qq.com";
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("华文隶书", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHome.ForeColor = System.Drawing.Color.Blue;
            this.lbHome.Location = new System.Drawing.Point(181, 142);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(304, 81);
            this.lbHome.TabIndex = 0;
            this.lbHome.Text = "Pdf工具";
            // 
            // tabPageMegre
            // 
            this.tabPageMegre.Controls.Add(this.groupBoxMerge);
            this.tabPageMegre.Controls.Add(this.groupBoxSplit);
            this.tabPageMegre.Location = new System.Drawing.Point(104, 4);
            this.tabPageMegre.Name = "tabPageMegre";
            this.tabPageMegre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMegre.Size = new System.Drawing.Size(798, 509);
            this.tabPageMegre.TabIndex = 1;
            this.tabPageMegre.Text = "分拆合并";
            this.tabPageMegre.UseVisualStyleBackColor = true;
            // 
            // groupBoxMerge
            // 
            this.groupBoxMerge.Controls.Add(this.lbMergeMsg);
            this.groupBoxMerge.Controls.Add(this.btnMergeClear);
            this.groupBoxMerge.Controls.Add(this.btnMergePdf);
            this.groupBoxMerge.Controls.Add(this.btnMoveDown);
            this.groupBoxMerge.Controls.Add(this.btnMoveUp);
            this.groupBoxMerge.Controls.Add(this.btnMergeDel);
            this.groupBoxMerge.Controls.Add(this.btnMergeAdd);
            this.groupBoxMerge.Controls.Add(this.groupBox2);
            this.groupBoxMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMerge.Location = new System.Drawing.Point(3, 159);
            this.groupBoxMerge.Name = "groupBoxMerge";
            this.groupBoxMerge.Size = new System.Drawing.Size(792, 347);
            this.groupBoxMerge.TabIndex = 2;
            this.groupBoxMerge.TabStop = false;
            this.groupBoxMerge.Text = "合并";
            // 
            // lbMergeMsg
            // 
            this.lbMergeMsg.AutoSize = true;
            this.lbMergeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMergeMsg.Location = new System.Drawing.Point(19, 320);
            this.lbMergeMsg.Name = "lbMergeMsg";
            this.lbMergeMsg.Size = new System.Drawing.Size(31, 15);
            this.lbMergeMsg.TabIndex = 8;
            this.lbMergeMsg.Text = "...";
            this.lbMergeMsg.Visible = false;
            // 
            // btnMergeClear
            // 
            this.btnMergeClear.Location = new System.Drawing.Point(521, 193);
            this.btnMergeClear.Name = "btnMergeClear";
            this.btnMergeClear.Size = new System.Drawing.Size(75, 31);
            this.btnMergeClear.TabIndex = 7;
            this.btnMergeClear.Text = "清空";
            this.btnMergeClear.UseVisualStyleBackColor = true;
            this.btnMergeClear.Click += new System.EventHandler(this.btnMergeClear_Click);
            // 
            // btnMergePdf
            // 
            this.btnMergePdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMergePdf.Location = new System.Drawing.Point(602, 45);
            this.btnMergePdf.Name = "btnMergePdf";
            this.btnMergePdf.Size = new System.Drawing.Size(106, 68);
            this.btnMergePdf.TabIndex = 6;
            this.btnMergePdf.Text = "合并";
            this.btnMergePdf.UseVisualStyleBackColor = true;
            this.btnMergePdf.Click += new System.EventHandler(this.btnMergePdf_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(521, 156);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 31);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "下移";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(521, 119);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 31);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.Text = "上移";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMergeDel
            // 
            this.btnMergeDel.Location = new System.Drawing.Point(521, 82);
            this.btnMergeDel.Name = "btnMergeDel";
            this.btnMergeDel.Size = new System.Drawing.Size(75, 31);
            this.btnMergeDel.TabIndex = 3;
            this.btnMergeDel.Text = "删除";
            this.btnMergeDel.UseVisualStyleBackColor = true;
            this.btnMergeDel.Click += new System.EventHandler(this.btnMergeDel_Click);
            // 
            // btnMergeAdd
            // 
            this.btnMergeAdd.Location = new System.Drawing.Point(521, 45);
            this.btnMergeAdd.Name = "btnMergeAdd";
            this.btnMergeAdd.Size = new System.Drawing.Size(75, 31);
            this.btnMergeAdd.TabIndex = 2;
            this.btnMergeAdd.Text = "添加";
            this.btnMergeAdd.UseVisualStyleBackColor = true;
            this.btnMergeAdd.Click += new System.EventHandler(this.btnMergeAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxMerge);
            this.groupBox2.Location = new System.Drawing.Point(16, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待合并列表";
            // 
            // listBoxMerge
            // 
            this.listBoxMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMerge.FormattingEnabled = true;
            this.listBoxMerge.ItemHeight = 15;
            this.listBoxMerge.Location = new System.Drawing.Point(3, 21);
            this.listBoxMerge.Name = "listBoxMerge";
            this.listBoxMerge.Size = new System.Drawing.Size(483, 261);
            this.listBoxMerge.TabIndex = 0;
            // 
            // groupBoxSplit
            // 
            this.groupBoxSplit.Controls.Add(this.lbSplitMsg);
            this.groupBoxSplit.Controls.Add(this.btnSplitPdf);
            this.groupBoxSplit.Controls.Add(this.label3);
            this.groupBoxSplit.Controls.Add(this.tPdfPages);
            this.groupBoxSplit.Controls.Add(this.label2);
            this.groupBoxSplit.Controls.Add(this.btnSelectPdf);
            this.groupBoxSplit.Controls.Add(this.tPdfPath);
            this.groupBoxSplit.Controls.Add(this.label1);
            this.groupBoxSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSplit.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSplit.Name = "groupBoxSplit";
            this.groupBoxSplit.Size = new System.Drawing.Size(792, 156);
            this.groupBoxSplit.TabIndex = 1;
            this.groupBoxSplit.TabStop = false;
            this.groupBoxSplit.Text = "分拆";
            // 
            // lbSplitMsg
            // 
            this.lbSplitMsg.AutoSize = true;
            this.lbSplitMsg.ForeColor = System.Drawing.Color.Red;
            this.lbSplitMsg.Location = new System.Drawing.Point(17, 129);
            this.lbSplitMsg.Name = "lbSplitMsg";
            this.lbSplitMsg.Size = new System.Drawing.Size(31, 15);
            this.lbSplitMsg.TabIndex = 7;
            this.lbSplitMsg.Text = "...";
            this.lbSplitMsg.Visible = false;
            // 
            // btnSplitPdf
            // 
            this.btnSplitPdf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSplitPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSplitPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSplitPdf.Location = new System.Drawing.Point(627, 71);
            this.btnSplitPdf.Name = "btnSplitPdf";
            this.btnSplitPdf.Size = new System.Drawing.Size(75, 30);
            this.btnSplitPdf.TabIndex = 6;
            this.btnSplitPdf.Text = "提取";
            this.btnSplitPdf.UseVisualStyleBackColor = false;
            this.btnSplitPdf.Click += new System.EventHandler(this.btnSplitPdf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(120, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "例如：1,5,10-20";
            // 
            // tPdfPages
            // 
            this.tPdfPages.Location = new System.Drawing.Point(120, 73);
            this.tPdfPages.Name = "tPdfPages";
            this.tPdfPages.Size = new System.Drawing.Size(500, 25);
            this.tPdfPages.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "页码范围：";
            // 
            // btnSelectPdf
            // 
            this.btnSelectPdf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelectPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSelectPdf.Location = new System.Drawing.Point(626, 37);
            this.btnSelectPdf.Name = "btnSelectPdf";
            this.btnSelectPdf.Size = new System.Drawing.Size(75, 29);
            this.btnSelectPdf.TabIndex = 2;
            this.btnSelectPdf.Text = "浏览";
            this.btnSelectPdf.UseVisualStyleBackColor = false;
            this.btnSelectPdf.Click += new System.EventHandler(this.btnSelectPdf_Click);
            // 
            // tPdfPath
            // 
            this.tPdfPath.Location = new System.Drawing.Point(120, 39);
            this.tPdfPath.Name = "tPdfPath";
            this.tPdfPath.ReadOnly = true;
            this.tPdfPath.Size = new System.Drawing.Size(500, 25);
            this.tPdfPath.TabIndex = 1;
            this.tPdfPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tPdfPath_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径：";
            // 
            // tabPageWatermark
            // 
            this.tabPageWatermark.Controls.Add(this.groupBoxWatermark);
            this.tabPageWatermark.Location = new System.Drawing.Point(104, 4);
            this.tabPageWatermark.Name = "tabPageWatermark";
            this.tabPageWatermark.Size = new System.Drawing.Size(798, 509);
            this.tabPageWatermark.TabIndex = 2;
            this.tabPageWatermark.Text = "水印";
            this.tabPageWatermark.UseVisualStyleBackColor = true;
            // 
            // groupBoxWatermark
            // 
            this.groupBoxWatermark.Controls.Add(this.numAngle);
            this.groupBoxWatermark.Controls.Add(this.numFontSize);
            this.groupBoxWatermark.Controls.Add(this.label7);
            this.groupBoxWatermark.Controls.Add(this.label6);
            this.groupBoxWatermark.Controls.Add(this.btnDoWatermark);
            this.groupBoxWatermark.Controls.Add(this.tWatermark);
            this.groupBoxWatermark.Controls.Add(this.label5);
            this.groupBoxWatermark.Controls.Add(this.btnSelectWatermarkPdf);
            this.groupBoxWatermark.Controls.Add(this.tWatermarkPdf);
            this.groupBoxWatermark.Controls.Add(this.label4);
            this.groupBoxWatermark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWatermark.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWatermark.Name = "groupBoxWatermark";
            this.groupBoxWatermark.Size = new System.Drawing.Size(798, 509);
            this.groupBoxWatermark.TabIndex = 0;
            this.groupBoxWatermark.TabStop = false;
            this.groupBoxWatermark.Text = "水印";
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(136, 103);
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(120, 25);
            this.numAngle.TabIndex = 10;
            this.numAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(136, 134);
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(120, 25);
            this.numFontSize.TabIndex = 9;
            this.numFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFontSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "字体大小：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "旋转角度：";
            // 
            // btnDoWatermark
            // 
            this.btnDoWatermark.Location = new System.Drawing.Point(645, 70);
            this.btnDoWatermark.Name = "btnDoWatermark";
            this.btnDoWatermark.Size = new System.Drawing.Size(75, 32);
            this.btnDoWatermark.TabIndex = 5;
            this.btnDoWatermark.Text = "加水印";
            this.btnDoWatermark.UseVisualStyleBackColor = true;
            this.btnDoWatermark.Click += new System.EventHandler(this.btnDoWatermark_Click);
            // 
            // tWatermark
            // 
            this.tWatermark.Location = new System.Drawing.Point(136, 71);
            this.tWatermark.Name = "tWatermark";
            this.tWatermark.Size = new System.Drawing.Size(488, 25);
            this.tWatermark.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "水印内容：";
            // 
            // btnSelectWatermarkPdf
            // 
            this.btnSelectWatermarkPdf.Location = new System.Drawing.Point(645, 34);
            this.btnSelectWatermarkPdf.Name = "btnSelectWatermarkPdf";
            this.btnSelectWatermarkPdf.Size = new System.Drawing.Size(75, 33);
            this.btnSelectWatermarkPdf.TabIndex = 2;
            this.btnSelectWatermarkPdf.Text = "浏览";
            this.btnSelectWatermarkPdf.UseVisualStyleBackColor = true;
            this.btnSelectWatermarkPdf.Click += new System.EventHandler(this.btnSelectWatermarkPdf_Click);
            // 
            // tWatermarkPdf
            // 
            this.tWatermarkPdf.Location = new System.Drawing.Point(136, 37);
            this.tWatermarkPdf.Name = "tWatermarkPdf";
            this.tWatermarkPdf.ReadOnly = true;
            this.tWatermarkPdf.Size = new System.Drawing.Size(488, 25);
            this.tWatermarkPdf.TabIndex = 1;
            this.tWatermarkPdf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tWatermarkPdf_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择文件：";
            // 
            // tabPageEncryption
            // 
            this.tabPageEncryption.Controls.Add(this.groupBoxDecrypt);
            this.tabPageEncryption.Controls.Add(this.groupBoxEncrypt);
            this.tabPageEncryption.Location = new System.Drawing.Point(104, 4);
            this.tabPageEncryption.Name = "tabPageEncryption";
            this.tabPageEncryption.Size = new System.Drawing.Size(798, 509);
            this.tabPageEncryption.TabIndex = 3;
            this.tabPageEncryption.Text = "加密";
            this.tabPageEncryption.UseVisualStyleBackColor = true;
            // 
            // groupBoxDecrypt
            // 
            this.groupBoxDecrypt.Controls.Add(this.btnRemovePassProtect);
            this.groupBoxDecrypt.Controls.Add(this.tDecryptEditPass);
            this.groupBoxDecrypt.Controls.Add(this.label13);
            this.groupBoxDecrypt.Controls.Add(this.btnDecryptPdf);
            this.groupBoxDecrypt.Controls.Add(this.tDecryptPdf);
            this.groupBoxDecrypt.Controls.Add(this.label9);
            this.groupBoxDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDecrypt.Location = new System.Drawing.Point(0, 236);
            this.groupBoxDecrypt.Name = "groupBoxDecrypt";
            this.groupBoxDecrypt.Size = new System.Drawing.Size(798, 273);
            this.groupBoxDecrypt.TabIndex = 1;
            this.groupBoxDecrypt.TabStop = false;
            this.groupBoxDecrypt.Text = "解密";
            // 
            // btnRemovePassProtect
            // 
            this.btnRemovePassProtect.Location = new System.Drawing.Point(633, 82);
            this.btnRemovePassProtect.Name = "btnRemovePassProtect";
            this.btnRemovePassProtect.Size = new System.Drawing.Size(93, 58);
            this.btnRemovePassProtect.TabIndex = 11;
            this.btnRemovePassProtect.Text = "移除密码";
            this.btnRemovePassProtect.UseVisualStyleBackColor = true;
            this.btnRemovePassProtect.Click += new System.EventHandler(this.btnRemovePassProtect_Click);
            // 
            // tDecryptEditPass
            // 
            this.tDecryptEditPass.Location = new System.Drawing.Point(142, 77);
            this.tDecryptEditPass.Name = "tDecryptEditPass";
            this.tDecryptEditPass.PasswordChar = '*';
            this.tDecryptEditPass.Size = new System.Drawing.Size(153, 25);
            this.tDecryptEditPass.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "编辑密码：";
            // 
            // btnDecryptPdf
            // 
            this.btnDecryptPdf.Location = new System.Drawing.Point(651, 43);
            this.btnDecryptPdf.Name = "btnDecryptPdf";
            this.btnDecryptPdf.Size = new System.Drawing.Size(75, 33);
            this.btnDecryptPdf.TabIndex = 5;
            this.btnDecryptPdf.Text = "浏览";
            this.btnDecryptPdf.UseVisualStyleBackColor = true;
            this.btnDecryptPdf.Click += new System.EventHandler(this.btnDecryptPdf_Click);
            // 
            // tDecryptPdf
            // 
            this.tDecryptPdf.Location = new System.Drawing.Point(142, 46);
            this.tDecryptPdf.Name = "tDecryptPdf";
            this.tDecryptPdf.ReadOnly = true;
            this.tDecryptPdf.Size = new System.Drawing.Size(488, 25);
            this.tDecryptPdf.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "选择文件：";
            // 
            // groupBoxEncrypt
            // 
            this.groupBoxEncrypt.Controls.Add(this.label12);
            this.groupBoxEncrypt.Controls.Add(this.btnEncryptProtect);
            this.groupBoxEncrypt.Controls.Add(this.tEncryptReadPass);
            this.groupBoxEncrypt.Controls.Add(this.tEncryptEditPass);
            this.groupBoxEncrypt.Controls.Add(this.label11);
            this.groupBoxEncrypt.Controls.Add(this.label10);
            this.groupBoxEncrypt.Controls.Add(this.btnEncryptPdf);
            this.groupBoxEncrypt.Controls.Add(this.tEncryptPdf);
            this.groupBoxEncrypt.Controls.Add(this.label8);
            this.groupBoxEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEncrypt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEncrypt.Name = "groupBoxEncrypt";
            this.groupBoxEncrypt.Size = new System.Drawing.Size(798, 236);
            this.groupBoxEncrypt.TabIndex = 0;
            this.groupBoxEncrypt.TabStop = false;
            this.groupBoxEncrypt.Text = "加密";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(301, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "(可为空)";
            // 
            // btnEncryptProtect
            // 
            this.btnEncryptProtect.Location = new System.Drawing.Point(633, 85);
            this.btnEncryptProtect.Name = "btnEncryptProtect";
            this.btnEncryptProtect.Size = new System.Drawing.Size(93, 58);
            this.btnEncryptProtect.TabIndex = 10;
            this.btnEncryptProtect.Text = "添加密码";
            this.btnEncryptProtect.UseVisualStyleBackColor = true;
            this.btnEncryptProtect.Click += new System.EventHandler(this.btnEncryptProtect_Click);
            // 
            // tEncryptReadPass
            // 
            this.tEncryptReadPass.Location = new System.Drawing.Point(142, 116);
            this.tEncryptReadPass.Name = "tEncryptReadPass";
            this.tEncryptReadPass.PasswordChar = '*';
            this.tEncryptReadPass.Size = new System.Drawing.Size(153, 25);
            this.tEncryptReadPass.TabIndex = 9;
            // 
            // tEncryptEditPass
            // 
            this.tEncryptEditPass.Location = new System.Drawing.Point(142, 82);
            this.tEncryptEditPass.Name = "tEncryptEditPass";
            this.tEncryptEditPass.PasswordChar = '*';
            this.tEncryptEditPass.Size = new System.Drawing.Size(153, 25);
            this.tEncryptEditPass.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "打开密码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "编辑密码：";
            // 
            // btnEncryptPdf
            // 
            this.btnEncryptPdf.Location = new System.Drawing.Point(651, 42);
            this.btnEncryptPdf.Name = "btnEncryptPdf";
            this.btnEncryptPdf.Size = new System.Drawing.Size(75, 33);
            this.btnEncryptPdf.TabIndex = 5;
            this.btnEncryptPdf.Text = "浏览";
            this.btnEncryptPdf.UseVisualStyleBackColor = true;
            this.btnEncryptPdf.Click += new System.EventHandler(this.btnEncryptPdf_Click);
            // 
            // tEncryptPdf
            // 
            this.tEncryptPdf.Location = new System.Drawing.Point(142, 45);
            this.tEncryptPdf.Name = "tEncryptPdf";
            this.tEncryptPdf.ReadOnly = true;
            this.tEncryptPdf.Size = new System.Drawing.Size(488, 25);
            this.tEncryptPdf.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "选择文件：";
            // 
            // tabPageViewer
            // 
            this.tabPageViewer.Controls.Add(this.pdfViewerMain);
            this.tabPageViewer.Location = new System.Drawing.Point(104, 4);
            this.tabPageViewer.Name = "tabPageViewer";
            this.tabPageViewer.Size = new System.Drawing.Size(798, 509);
            this.tabPageViewer.TabIndex = 4;
            this.tabPageViewer.Text = "Pdf查看";
            this.tabPageViewer.UseVisualStyleBackColor = true;
            // 
            // pdfViewerMain
            // 
            this.pdfViewerMain.AllowDrop = true;
            this.pdfViewerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerMain.Location = new System.Drawing.Point(0, 0);
            this.pdfViewerMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdfViewerMain.Name = "pdfViewerMain";
            this.pdfViewerMain.Size = new System.Drawing.Size(798, 509);
            this.pdfViewerMain.TabIndex = 2;
            this.pdfViewerMain.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitBest;
            this.pdfViewerMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.pdfViewerMain_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(906, 517);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pdf工具";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.tabPageMegre.ResumeLayout(false);
            this.groupBoxMerge.ResumeLayout(false);
            this.groupBoxMerge.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxSplit.ResumeLayout(false);
            this.groupBoxSplit.PerformLayout();
            this.tabPageWatermark.ResumeLayout(false);
            this.groupBoxWatermark.ResumeLayout(false);
            this.groupBoxWatermark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.tabPageEncryption.ResumeLayout(false);
            this.groupBoxDecrypt.ResumeLayout(false);
            this.groupBoxDecrypt.PerformLayout();
            this.groupBoxEncrypt.ResumeLayout(false);
            this.groupBoxEncrypt.PerformLayout();
            this.tabPageViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageMegre;
        private System.Windows.Forms.TabPage tabPageWatermark;
        private System.Windows.Forms.GroupBox groupBoxSplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPdfPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPdfPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSplitPdf;
        private System.Windows.Forms.Label lbSplitMsg;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSplit;
        private System.Windows.Forms.GroupBox groupBoxMerge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxMerge;
        private System.Windows.Forms.Button btnMergeAdd;
        private System.Windows.Forms.Button btnMergeDel;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMergePdf;
        private System.Windows.Forms.Button btnSelectPdf;
        private System.Windows.Forms.Button btnMergeClear;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMerge;
        private System.Windows.Forms.Label lbMergeMsg;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.GroupBox groupBoxWatermark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tWatermarkPdf;
        private System.Windows.Forms.Button btnSelectWatermarkPdf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tWatermark;
        private System.Windows.Forms.Button btnDoWatermark;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWatermark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.TabPage tabPageEncryption;
        private System.Windows.Forms.GroupBox groupBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBoxDecrypt;
        private System.Windows.Forms.Button btnEncryptPdf;
        private System.Windows.Forms.TextBox tEncryptPdf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDecryptPdf;
        private System.Windows.Forms.TextBox tDecryptPdf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tEncryptReadPass;
        private System.Windows.Forms.TextBox tEncryptEditPass;
        private System.Windows.Forms.Button btnEncryptProtect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tDecryptEditPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRemovePassProtect;
        private System.Windows.Forms.TabPage tabPageViewer;
        private PdfiumViewer.PdfViewer pdfViewerMain;
    }
}

