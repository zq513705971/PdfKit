using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;
using iText.Kernel.Pdf.Layer;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle tabArea = tabControlMain.GetTabRect(e.Index);//主要是做个转换来获得TAB项的RECTANGELF
            RectangleF tabTextArea = (RectangleF)(tabControlMain.GetTabRect(e.Index));
            Graphics g = e.Graphics;
            StringFormat sf = new StringFormat();//封装文本布局信息
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            Font font = this.tabControlMain.Font;
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);//绘制边框的画笔
            g.DrawString(((TabControl)(sender)).TabPages[e.Index].Text, font, brush, tabTextArea, sf);
        }

        private void btnSelectPdf_Click(object sender, EventArgs e)
        {
            fnSelectSplitPdf();
        }

        private void tPdfPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fnSelectSplitPdf();
        }

        private void fnSelectSplitPdf()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Pdf文件|*.pdf" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tPdfPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnSplitPdf_Click(object sender, EventArgs e)
        {
            string pdfPath = tPdfPath.Text;
            string numPages = tPdfPages.Text;

            if (string.IsNullOrEmpty(pdfPath) || string.IsNullOrEmpty(numPages))
            {
                MessageBox.Show("请选择待分拆Pdf文件，并按格式录入页码范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(pdfPath))
            {
                MessageBox.Show("当前文件不存在，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string pdfDir = Path.GetDirectoryName(pdfPath);
            string[] pages = numPages.Split(',');
            List<Common.PageRange> pageNums = new List<Common.PageRange>();
            try
            {
                foreach (string page in pages)
                {
                    int num = -1;
                    if (int.TryParse(page, out num))
                    {
                        pageNums.Add(new Common.PageRange(num));
                        continue;
                    }
                    else if (page.Contains("-"))
                    {
                        string[] subPages = page.Split('-');
                        if (subPages.Length != 2)
                        {
                            throw new Exception("");
                        }
                        int start = int.Parse(subPages[0]);
                        int end = int.Parse(subPages[1]);

                        pageNums.Add(new Common.PageRange(start, end));
                        continue;
                    }
                    throw new Exception("");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("页码范围有误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnSelectPdf.Enabled = false;
            tPdfPages.Enabled = false;
            tPdfPath.Enabled = false;
            lbSplitMsg.Text = "开始处理...";
            lbSplitMsg.Visible = true;
            Utils.RunBackgroundWorker(backgroundWorkerSplit, (sender1, e1) =>
            {
                PdfDocument pdfDocument = new PdfDocument(new PdfReader(new FileStream(pdfPath, FileMode.Open, FileAccess.Read, FileShare.Read)));
                int totalPages = pdfDocument.GetNumberOfPages();

                string dirPath = string.Format("{0}/{1}", pdfDir, Path.GetFileNameWithoutExtension(pdfPath));
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                foreach (Common.PageRange pageRange in pageNums)
                {
                    int start = pageRange.start;
                    int end = Math.Min(pageRange.end, totalPages);

                    if (start > end)
                        continue;


                    string pdf = string.Format("{0}/{1}/{2}.pdf", pdfDir, Path.GetFileNameWithoutExtension(pdfPath), pageRange.ToString());
                    if (File.Exists(pdf))
                        File.Delete(pdf);
                    Utils.Invoke(lbSplitMsg, () =>
                    {
                        lbSplitMsg.Text = string.Format("正在处理 {0}", Path.GetFileName(pdf));
                    });

                    PdfWriter pdfWriter = new PdfWriter(pdf);
                    PdfDocument pdfWriterDoc = new PdfDocument(pdfWriter);
                    pdfDocument.CopyPagesTo(start, end, pdfWriterDoc);
                    pdfWriterDoc.Close();
                    pdfWriter.Close();
                }

                pdfDocument.Close();
            }, (sender2, e2) =>
            {

            }, (sender3, e3) =>
            {
                MessageBox.Show("处理完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbSplitMsg.Text = "处理完成！";
                lbSplitMsg.Visible = false;
                btnSelectPdf.Enabled = true;
                tPdfPages.Enabled = true;
                tPdfPath.Enabled = true;
            });
        }

        private void btnMergeAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Pdf文件|*.pdf" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listBoxMerge.Items.Add(openFileDialog.FileName);
                }
            }
        }

        private void btnMergeClear_Click(object sender, EventArgs e)
        {
            listBoxMerge.Items.Clear();
        }

        private void btnMergeDel_Click(object sender, EventArgs e)
        {
            int index = listBoxMerge.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请选择一项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBoxMerge.Items.RemoveAt(listBoxMerge.SelectedIndex);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            object item = listBoxMerge.SelectedItem;
            int index = listBoxMerge.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请选择一项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == 0)
            {
                MessageBox.Show("已在首位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBoxMerge.Items.Remove(item);
            listBoxMerge.Items.Insert(index - 1, item);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            object item = listBoxMerge.SelectedItem;
            int index = listBoxMerge.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请选择一项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == listBoxMerge.Items.Count - 1)
            {
                MessageBox.Show("已在末尾！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBoxMerge.Items.Remove(item);
            listBoxMerge.Items.Insert(index + 1, item);
        }

        private void btnMergePdf_Click(object sender, EventArgs e)
        {
            if (listBoxMerge.Items.Count <= 1)
            {
                MessageBox.Show("请添加至少2个pdf文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string savePath = "";
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.DesktopDirectory,
                Description = "请选择文件合并后存放的路径"
            })
            {
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                savePath = folderBrowserDialog.SelectedPath;
            }
            lbMergeMsg.Text = "开始合并文件...";
            lbMergeMsg.Visible = true;
            groupBoxMerge.Enabled = false;
            Utils.RunBackgroundWorker(backgroundWorkerMerge, (sender1, e1) =>
            {
                string mergedPdf = string.Format("{0}/merged_{1:HHmmss}.pdf", savePath, DateTime.Now);
                PdfWriter pdfWriter = new PdfWriter(mergedPdf);
                PdfDocument pdfWriterDoc = new PdfDocument(pdfWriter);

                PdfMerger merger = new PdfMerger(pdfWriterDoc);
                foreach (object item in listBoxMerge.Items)
                {
                    Utils.Invoke(lbSplitMsg, () =>
                    {
                        lbMergeMsg.Text = string.Format("正在处理 {0}", Path.GetFileName(item.ToString()));
                    });
                    PdfDocument pdfDoc = new PdfDocument(new PdfReader(item.ToString()));
                    merger.Merge(pdfDoc, 1, pdfDoc.GetNumberOfPages());
                    pdfDoc.Close();
                }
                pdfWriterDoc.Close();
            }, (s2, e2) =>
            {
                groupBoxMerge.Enabled = true;
                MessageBox.Show("处理完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbMergeMsg.Visible = false;
            });

        }

        private void btnSelectWatermarkPdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Pdf文件|*.pdf" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tWatermarkPdf.Text = openFileDialog.FileName;
                }
            }
        }
        private void tWatermarkPdf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Pdf文件|*.pdf" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tWatermarkPdf.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnDoWatermark_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tWatermarkPdf.Text))
            {
                MessageBox.Show("请选择待加水印文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tWatermark.Text))
            {
                MessageBox.Show("请输入水印内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (numAngle.Value < -90 || numAngle.Value > 90)
            {
                MessageBox.Show("请输入-90 ~ 90旋转角度！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string srcPdf = tWatermarkPdf.Text;
            string targetPdf = string.Format("{0}/{1}_watermark.pdf", Path.GetDirectoryName(srcPdf), Path.GetFileNameWithoutExtension(srcPdf));
            string markStr = tWatermark.Text;
            int fontSize = Decimal.ToInt32(numFontSize.Value);
            groupBoxWatermark.Enabled = false;
            Utils.RunBackgroundWorker(backgroundWorkerWatermark, (s1, e1) =>
            {
                try
                {
                    PdfReader reader = new PdfReader(srcPdf);
                    PdfWriter writer = new PdfWriter(targetPdf);
                    PdfDocument pdfDoc = new PdfDocument(reader, writer);

                    PdfFont font = PdfFontFactory.CreateFont(string.Format("{0}/simsun.ttf", AppDomain.CurrentDomain.BaseDirectory), PdfEncodings.IDENTITY_H);
                    Paragraph paragraph = new Paragraph(markStr).SetFont(font).SetFontSize(fontSize);
                    paragraph.SetFontColor(ColorConstants.BLACK, 0.2f);

                    int numberOfPages = pdfDoc.GetNumberOfPages();
                    for (int i = 1; i <= numberOfPages; i++)
                    {
                        PdfPage page = pdfDoc.GetPage(i);
                        iText.Kernel.Geom.Rectangle ps = page.GetPageSize();

                        float pageHeight = ps.GetHeight();
                        float pageWidth = ps.GetWidth();

                        PdfLayer layer = new PdfLayer("watermark", pdfDoc);
                        PdfCanvas canvas = new PdfCanvas(page);
                        canvas.BeginLayer(layer);

                        Canvas canvasModel = new Canvas(canvas, ps);

                        int angle = Decimal.ToInt32(numAngle.Value);
                        float radAngle = float.Parse(((Math.PI / 180) * angle).ToString());
                        canvasModel.ShowTextAligned(paragraph, pageWidth / 2, pageHeight / 2, i, TextAlignment.CENTER, VerticalAlignment.MIDDLE, radAngle);
                        canvasModel.SetFontColor(ColorConstants.BLACK, 0.2f);
                        canvas.EndLayer();
                    }

                    pdfDoc.Close();
                }
                catch (Exception ex)
                {

                }
            }, (s2, e2) =>
            {
                groupBoxWatermark.Enabled = true;
                MessageBox.Show("处理完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

        }

        private void btnEncryptPdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Pdf文件|*.pdf" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tEncryptPdf.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnDecryptPdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Pdf文件|*.pdf" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tDecryptPdf.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnEncryptProtect_Click(object sender, EventArgs e)
        {
            string pdfPath = tEncryptPdf.Text;
            if (string.IsNullOrEmpty(pdfPath))
            {
                MessageBox.Show("请选择待加密文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(this.tEncryptEditPass.Text))
            {
                MessageBox.Show("请输入编辑密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PdfWriter pdfWriter = null;
            PdfReader pdfReader = null;
            PdfDocument pdfDocument = null;
            try
            {
                pdfReader = new PdfReader(pdfPath);
                WriterProperties writerProperties = new WriterProperties();

                byte[] USERPASS = Encoding.Default.GetBytes(this.tEncryptReadPass.Text);
                byte[] OWNERPASS = Encoding.Default.GetBytes(this.tEncryptEditPass.Text);

                writerProperties.SetStandardEncryption(USERPASS, OWNERPASS, EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_256);
                pdfWriter = new PdfWriter(new FileStream(string.Format("{0}/{1}_protected.pdf", Path.GetDirectoryName(pdfPath), Path.GetFileNameWithoutExtension(pdfPath)), FileMode.Create), writerProperties);
                pdfDocument = new PdfDocument(pdfReader, pdfWriter);
                pdfDocument.Close();
                MessageBox.Show("处理完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (pdfWriter != null)
                    pdfWriter.Close();
                if (pdfReader != null)
                    pdfReader.Close();
            }
        }

        private void btnRemovePassProtect_Click(object sender, EventArgs e)
        {
            string pdfPath = tDecryptPdf.Text;
            if (string.IsNullOrEmpty(pdfPath))
            {
                MessageBox.Show("请选择待移除密码的Pdf文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(this.tDecryptEditPass.Text))
            {
                MessageBox.Show("请输入编辑密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PdfWriter pdfWriter = null;
            PdfReader pdfReader = null;
            PdfDocument pdfDocument = null;
            try
            {
                byte[] OWNERPASS = Encoding.Default.GetBytes(this.tDecryptEditPass.Text);

                ReaderProperties readerProperties = new ReaderProperties().SetPassword(OWNERPASS);
                pdfReader = new PdfReader(pdfPath, readerProperties);
                pdfWriter = new PdfWriter(new FileStream(string.Format("{0}/{1}_unlocked.pdf", Path.GetDirectoryName(pdfPath), Path.GetFileNameWithoutExtension(pdfPath)), FileMode.Create));
                pdfDocument = new PdfDocument(pdfReader, pdfWriter);
                pdfDocument.Close();
                MessageBox.Show("处理完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (pdfWriter != null)
                    pdfWriter.Close();
                if (pdfReader != null)
                    pdfReader.Close();
            }
        }
    }
}
