using System;
using System.Windows.Forms;

namespace 小区居民管理系统
{
    public partial class 管理员新增用户 : Form
    {
        public 管理员新增用户()
        {
            InitializeComponent();
        }

        private string box1text;
        private string box2text;
        private string box3text;

        private void button1_Click(object sender, EventArgs e)
        {
            if (box1text == null)
            {
                MessageBox.Show("请输入您要注册的账号！！！");
            }
            if (box1text != null && box2text == null)
            {
                MessageBox.Show("请输入您要设定的密码！！！");
            }
            if (box1text != null && box2text != null && box3text == null)
            {
                MessageBox.Show("请再次输入您要设定的密码！！！");
            }
            if (box1text != null && box2text != null && box3text != null && box2text != box3text)
            {
                MessageBox.Show("两次输入的密码不一致！！！");
                return;
            }
            if (box1text != null && box2text != null && box3text != null && box2text == box3text)
            {
                string[] strUsername = Data.readTxtData(Login.LoginUsernamePath);
                Login login = new Login();
                int lineNumber = Data.getLineNumber(strUsername, login.getUsername()); ;
                if (lineNumber  == -1)
                {
                    MessageBox.Show("用户名已存在！！！");
                    this.Close();
                    return;
                }
                else
                {
                Login.setData(Login.LoginUsernamePath, box1text);
                Login.setData(Login.LoginPasswordPath, box2text);
                MessageBox.Show("保存成功！！！");
                this.Close();
                }
            }
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
    }
}
