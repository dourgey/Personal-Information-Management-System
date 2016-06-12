using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace 小区居民管理系统
{
    class Data
    {
        public string correctpassword;
        public void setCorrectpassword(String correctpassword)
        {
            this.correctpassword = correctpassword;
        }
        public string getCorrectpassword()
        {
            return correctpassword;
        }

        public string correctusername;
        public void setCorrectusername(String correctusername)
        {
            this.correctusername = correctusername;
        }
        public string getCorrectusername()
        {
            return correctusername;
        }

        public static string[] Usernameline;
        public static int intUsernameline;
        public static string[] Passwordline;
        public static int intPasswordline;
        public static string[] NameDataline;
        public static int intNameDataline;
        public static string[] PersonID;
        public static int intPersonID;
        public static string[] PersonProfessionline;
        public static int intPersonProfessionline;
        public static string[] PersonYearline;
        public static int intPersonYearline;

        //从txt文件按行返回数组
        public static string[] readTxtData(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string s = sr.ReadToEnd();
            string[] str1 = s.Split();
            sr.Close();
            List<String> tmp = new List<string>();
            foreach (String aa in str1)
            {
                if (aa != null && aa.Length != 0)
                {
                    tmp.Add(aa);
                }
            }
            str1 = tmp.ToArray();

            return str1;
        }

        //判断登陆密码是否正确
        public static bool compareUP(string str1, string str2)
        {
            bool a = false;
            if (str1 == str2)
            {
                a = true;
            }
            return a;
        }

        //得到下标
        public static int getLineNumber(string[] str1,string str2)
        {
            int LineNumber = -1;
            for (int i = 0; i < str1.Length; i++)
            {   
                if (str1[i].Equals(str2))
                {
                    LineNumber = i;
                    break;
                }
            }
            return LineNumber;
        }

    }
}
