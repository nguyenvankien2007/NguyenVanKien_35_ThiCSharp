using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanKien_35_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String HoTenSV = "Nguyễn Văn Kiên";
            String MSSV = "1223360060";
            String MonThi = "lập Trình Windows 2 C#";

            lblinfor.Text = "Họ và Tên: " + HoTenSV;
            lblinfor.Text += "\nMSSV: " + MSSV;
            lblinfor.Text += "\nMonThi: " + MonThi;
            lblinfor.Text += "\nTime: " + System.DateTime.Now.ToString();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin");
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }

        private void địnhDạngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DinhDang dd = new DinhDang();
            dd.Show();
        }
    }
}
