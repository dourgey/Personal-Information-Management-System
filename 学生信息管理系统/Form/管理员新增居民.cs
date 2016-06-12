using System;
using System.Windows.Forms;

namespace 小区居民管理系统
{
    public partial class 管理员新增居民 : Form
    {
        private string box1text;
        private string box2text;
        private string box3text;
        private string box4text;
        public 管理员新增居民()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            box1text = this.textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            box2text = this.textBox2.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            box3text = this.textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            box4text = this.textBox4.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (box1text == null)
            {
                MessageBox.Show("请输入居民的姓名！！！");
            }
            if (box1text != null && box2text == null)
            {
                MessageBox.Show("请输入居民的居民编号！！！");
            }
            if (box1text != null && box2text != null && box3text == null)
            {
                MessageBox.Show("请输入居民的住址编号！！！");
            }
            if (box1text != null && box2text != null && box3text != null && box4text == null)
            {
                MessageBox.Show("请输入居民的入住时间！！！");
            }
            if (box1text != null && box2text != null && box3text != null && box4text != null)
            {
                Login.setData(Login.NameDataPath, box1text);
                Login.setData(Login.PersonIDPath, box2text);
                Login.setData(Login.PersonProfessionPath, box3text);
                Login.setData(Login.PersonYearPath,box4text);
                MessageBox.Show("保存成功！！！");
                this.Close();
            }
        }



    }
}
