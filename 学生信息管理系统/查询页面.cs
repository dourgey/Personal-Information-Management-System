using System;
using System.Windows.Forms;

namespace 小区居民管理系统
{
    public partial class 查询页面 : Form
    {
        public 查询页面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PersonID = this.textBox1.Text.ToString();
            string[] hadPersonID = Data.readTxtData(Login.PersonIDPath);
            int lineNumber = Data.getLineNumber(hadPersonID, PersonID);
            
                if (lineNumber == -1)
                {
                    if (PersonID == "")
                    {
                        MessageBox.Show("请输入您要查询的用户的居民编号！！！");
                    }
                    else
                    {
                        MessageBox.Show("该用户不存在！！！");
                        this.linkLabel1.Text = "                         ";
                        this.linkLabel2.Text = "                         ";
                        this.linkLabel3.Text = "                         ";
                    }
                    }
                else
                {
                    string PersonName = Data.readTxtData(Login.NameDataPath)[lineNumber];
                    string PersonProfession = Data.readTxtData(Login.PersonProfessionPath)[lineNumber];
                    string PersonYear = Data.readTxtData(Login.PersonYearPath)[lineNumber];

                    this.linkLabel1.Text = PersonName;
                    this.linkLabel2.Text = PersonProfession;
                    this.linkLabel3.Text = PersonYear;

                    MessageBox.Show("查询成功！！！");
                }

            }
        
    }
}
