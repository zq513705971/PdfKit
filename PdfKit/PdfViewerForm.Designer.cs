namespace PdfKit
{
    partial class PdfViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfViewerForm));
            this.pdfViewerMain = new PdfiumViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfViewerMain
            // 
            this.pdfViewerMain.AllowDrop = true;
            this.pdfViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerMain.Location = new System.Drawing.Point(0, 0);
            this.pdfViewerMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdfViewerMain.Name = "pdfViewerMain";
            this.pdfViewerMain.Size = new System.Drawing.Size(1324, 754);
            this.pdfViewerMain.TabIndex = 0;
            this.pdfViewerMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.pdfViewerMain_DragEnter);
            // 
            // PdfViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 754);
            this.Controls.Add(this.pdfViewerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PdfViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfViewerForm";
            this.Load += new System.EventHandler(this.PdfViewerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PdfiumViewer.PdfViewer pdfViewerMain;
    }
}