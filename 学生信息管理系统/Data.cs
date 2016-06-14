using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

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

        //MD5加密密码
        public static string Md5(string str)
        {
            string temp = "";
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);  //将字符串编码为一个字节序列
            byte[] md5Data = md5.ComputeHash(data);  //计算data字节数组的哈希值
            md5.Clear();  //释放掉计算过程中所用到的所有资源
            for(int j = 0;j < md5Data.Length;j ++)
            {
                temp += md5Data[j].ToString("x").PadLeft(2, '0');
            }
            return temp; 
        }

        //判断登陆密码是否正确
        public static bool compareUP(string str1, string str2)
        {
            bool a = false;
            string str = Md5(str1);
            if (str == str2)
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
