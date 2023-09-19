using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chen_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelngay.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}",
                DateTime.Now.ToString("dd/mm/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnufileExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không!", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mnufileOpen_Click(object sender, EventArgs e)
        {
            //Tạo hộp thoại mở file.
            OpenFileDialog ofd = new OpenFileDialog();
            //Lọc hiển thị file.
            ofd.Filter = "*.mp3| *.mp4| MP4 file| MP3";
            //Hiển thị opendialog 
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;//lấy tên file cần mở.
            }
        }
    }
}
