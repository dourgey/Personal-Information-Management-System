using System;
using System.Windows.Forms;

namespace 小区居民管理系统
{
    public partial class 管理员窗口 : Form
    {
        public 管理员窗口()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            管理员新增用户 nf = new 管理员新增用户();
            nf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            管理员新增居民 nf = new 管理员新增居民();
            nf.ShowDialog();
        }
    }
}
