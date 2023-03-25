using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickPictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] Images { get; set; }
        private bool IsLoaded { get; set; }

        /// <summary>
        /// 將 byte 格式化爲 B/KB/MB/GB
        /// </summary>
        /// <param name="byteSize"></param>
        /// <returns></returns>
        private static string FormatByteSize(long byteSize)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = byteSize;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            return string.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var index = lsbImages.SelectedIndex;
            if (index < lsbImages.Items.Count - 1)
            {
                lsbImages.SelectedIndex += 1;
            }
        }

        private void btnPinning_Click(object sender, EventArgs e)
        {
            var isPin = !Convert.ToBoolean(btnPinning.Tag);
            btnPinning.Tag = isPin;
            btnPinning.ForeColor = isPin ? Color.White : SystemColors.ControlText;
            btnPinning.BackColor = isPin ? Color.Crimson : SystemColors.ControlLightLight;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var index = lsbImages.SelectedIndex;
            if (index > 0)
            {
                lsbImages.SelectedIndex -= 1;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                btnSelectFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSelectFolder_TextChanged(object sender, EventArgs e)
        {
            RefreshFolderInfo();
        }

        private void cboSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            RefreshImageList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitFields();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            IsLoaded = true;
        }

        private void InitFields()
        {
            cboSearchOptions.SelectedIndex = 0;
            tvSubFolders.Nodes.Clear();
            lblLocation.Text = "";
            lblPixels.Text = "        ";
            lblSize.Text = "        ";
        }

        private void lsbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lsbImages.SelectedIndex;
            if (index > 0)
            {
                var folder = btnSelectFolder.Text;
                var file = lsbImages.SelectedItem.ToString();
                var fileName = Images.First(f => f.Contains(file));
                var filePath = Path.Combine(folder, fileName);
                var fileInfo = new FileInfo(filePath);
                // Show image
                picImage.Load(filePath);
                picImage.SizeMode = PictureBoxSizeMode.CenterImage;
                picImage.Tag = 1; // Scale rate

                // Show image info
                var img = picImage.Image;
                lblLocation.Text = filePath;
                lblLocation.ToolTipText = filePath;
                lblPixels.Text = $"{img.PhysicalDimension.Width}x{img.PhysicalDimension.Height}";
                lblSize.Text = FormatByteSize(fileInfo.Length);
            }
        }

        private void panelTouchSensor_MouseHover(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            timerHideSidebar.Stop();
        }

        private void picImage_MouseMove(object sender, MouseEventArgs e)
        {
            // 沒有圖片時, 不處理
            if (lsbImages.Items.Count <= 1) return;
            if (picImage.Image is null) return;

            // 沒有釘選頁面
            if (!Convert.ToBoolean(btnPinning.Tag))
            {
                timerHideSidebar.Start();
            }
        }

        private void picImage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnPrevious_Click(sender, EventArgs.Empty);
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                btnNext_Click(sender, EventArgs.Empty);
                return;
            }
        }

        private void RefreshFolderInfo()
        {
            RefreshSubFolders();
            RefreshImageList();
        }

        private void RefreshImageList()
        {
            lsbImages.Items.Clear();
            lsbImages.Items.Add("圖片清單:");

            // Get folder path
            var folder = btnSelectFolder.Text;

            // Get Images
            //var reg_image = new Regex(@"(?<filename>.+?)\.(?<extension>bmp|jpg|jpeg|png|gif|tiff)", RegexOptions.IgnoreCase);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };
            var files = Directory
                .EnumerateFiles(folder)
                .Where(file => imageExtensions.Any(ext => ext == Path.GetExtension(file)));
            var strFilter = txtSearch.Text.Trim();
            var startOfString = cboSearchOptions.SelectedIndex == 1 ? "^" : "";
            var endOfString = cboSearchOptions.SelectedIndex == 2 ? "$" : "";
            var reg_fileFilter = new Regex($@"{startOfString}{strFilter}{endOfString}", RegexOptions.IgnoreCase);
            foreach (string file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                if (string.IsNullOrEmpty(strFilter))
                {
                    lsbImages.Items.Add(fileName);
                }
                else if (reg_fileFilter.IsMatch(fileName))
                {
                    lsbImages.Items.Add(fileName);
                }
            }

            Images = files.ToArray();
        }

        private void RefreshSubFolders()
        {
            var rootFolder = btnSelectFolder.Text;

            // Clear all nodes
            tvSubFolders.Nodes.Clear();

            // Add parent node
            tvSubFolders.Nodes.Add("..");

            // Add SubFolders
            var subFolders = Directory.GetDirectories(rootFolder);
            foreach (var subFolder in subFolders)
            {
                var subFolderName = subFolder.Replace($"{rootFolder}\\", "");
                tvSubFolders.Nodes.Add(subFolderName);
            }
        }

        private void timerDelaySearch_Tick(object sender, EventArgs e)
        {
            RefreshImageList();
            timerDelaySearch.Stop();
        }

        private void timerHideSidebar_Tick(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            timerHideSidebar.Stop();
        }

        private void tsmiOpenPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(picImage.ImageLocation);
        }

        private void tvSubFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!IsLoaded) return;
            if (splitContainer1.Panel1Collapsed) return;

            // Get node name
            var node = e.Node;
            // Get root folder
            var rootFolder = btnSelectFolder.Text;

            // Move to parent
            if (node.Text == "..")
            {
                var parent = Directory.GetParent(rootFolder);
                if (parent != null && parent.Exists)
                {
                    // Change root folder
                    btnSelectFolder.Text = parent.FullName;
                }
            }
            else
            {
                // Move to subfolder
                btnSelectFolder.Text = Path.Combine(rootFolder, node.Text);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // restart search
            timerDelaySearch.Stop();
            timerDelaySearch.Start();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (picImage.Image is null) return;

            // 放大 1.2 倍
            picImage.Image = ScaleImage(picImage.Image, 1.2f);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (picImage.Image is null) return;

            // 縮小 0.8 倍
            picImage.Image = ScaleImage(picImage.Image, 0.8f);
        }

        private Image ScaleImage(Image image, float scaleFactor)
        {
            // 計算新圖片的大小
            int width = (int)(image.Width * scaleFactor);
            int height = (int)(image.Height * scaleFactor);

            // 創建新的 Bitmap
            Bitmap bitmap = new Bitmap(width, height);

            // 創建一個 Graphics 物件
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // 設定繪圖品質
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // 繪製圖片至 Bitmap 中
                graphics.DrawImage(image, 0, 0, width, height);
            }

            // 回傳縮放後的 Image
            return bitmap;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            picImage.Load(lblLocation.Text);
            picImage.SizeMode = picImage.SizeMode == PictureBoxSizeMode.Zoom
                ? PictureBoxSizeMode.CenterImage
                : PictureBoxSizeMode.Zoom;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                if(e.KeyCode == Keys.Left)
                {
                    btnPrevious_Click(sender, EventArgs.Empty);
                }

                if(e.KeyCode == Keys.Right)
                {
                    btnNext_Click(sender, EventArgs.Empty);
                }

                // 不傳遞按鈕事件
                e.SuppressKeyPress = true;
            }
        }
    }
}