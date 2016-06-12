using System;
using System.Windows.Forms;

namespace 小区居民管理系统
{
    public partial class 欢迎页 : Form
    {
        public 欢迎页()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 欢迎页_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            管理员窗口 nf = new 管理员窗口();
            nf.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            查询页面 nf = new 查询页面();
            nf.ShowDialog();
        }
    }
}
