using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfKit
{
    public partial class PdfViewerForm : Form
    {
        private string pdfName;
        private string title;
        public PdfViewerForm(string pdfName, string title)
        {
            InitializeComponent();

            this.pdfName = pdfName;
            this.title = title;
            if (string.IsNullOrEmpty(title))
                this.title = this.pdfName; 
            this.Text = this.title;
        }

        private void PdfViewerForm_Load(object sender, EventArgs e)
        {
            showPdf(this.pdfName);
        }

        private void showPdf(string path)
        {
            try
            {
                pdfViewerMain.Document = PdfiumViewer.PdfDocument.Load(path);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pdfViewerMain_DragEnter(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.Text = Path.GetFileName(path);
            showPdf(path);
        }
    }
}
