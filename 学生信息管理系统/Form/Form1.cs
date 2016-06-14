 using System;
using System.Windows.Forms;

namespace 小区居民管理系统
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Login login = new Login();
        Data data = new Data();


        private void button1_Click(object sender, EventArgs e)
        {
            string[] strUsername = Data.readTxtData(Login.LoginUsernamePath);
            string[] strPassword = Data.readTxtData(Login.LoginPasswordPath);
            int lineNumber = -1;

            if (login.getUsername() == null)
            {
                MessageBox.Show("亲，请输入您的用户名！！！");
            }
            if (login.getUsername() != null && login.getPassword() == null)
            {
                MessageBox.Show("亲，您还没有输入密码！！！");
                return;
            }
            if (login.getUsername() != null && login.getPassword() != null)
            {
                lineNumber = Data.getLineNumber(strUsername, login.getUsername());
                if (lineNumber >-1)
                {
                    data.setCorrectusername(login.getUsername());
                    data.setCorrectpassword(strPassword[lineNumber]);
                }
            }
            if (!Data.compareUP(login.getPassword(), data.getCorrectpassword()))
            {
                if (lineNumber == -1)
                {
                    MessageBox.Show("用户不存在！！！");
                    return;
                }
                else
                {
                    MessageBox.Show("亲，您输入的账号或密码有误！！！");
                    return;
                }
            }
            else
            {
                this.Visible = false;
                欢迎页 nf = new 欢迎页();
                nf.ShowDialog();
            }
        }

             

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login.setUsername(this.textBox1.Text.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            login.setPassword(this.textBox2.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请您联系管理员修改您的密码！！！");
        }
    }
}
