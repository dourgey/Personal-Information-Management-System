using System;
using System.IO;

namespace 小区居民管理系统
{
    class Login
    {
        //路径定义
        public static string LoginUsernamePath =AppDomain.CurrentDomain.BaseDirectory + @"data\LoginData\LoginUsername.txt";
        public static string LoginPasswordPath =AppDomain.CurrentDomain.BaseDirectory + @"data\LoginData\LoginPassword.txt";
        public static string NameDataPath = AppDomain.CurrentDomain.BaseDirectory + @"data\PersonData\NameData.txt";
        public static string PersonIDPath = AppDomain.CurrentDomain.BaseDirectory + @"data\PersonData\PersonID.txt";
        public static string PersonProfessionPath = AppDomain.CurrentDomain.BaseDirectory + @"data\PersonData\PersonProfession.txt";
        public static string PersonYearPath = AppDomain.CurrentDomain.BaseDirectory + @"data\PersonData\PersonYear.txt";
        
        public static void setData(string path,string write_data){
            FileStream FSUN = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(FSUN);
            sw.WriteLine(write_data);
            sw.Close();
            FSUN.Close();
        }



        private string username ;
        public void setUsername(string username)
        {
            this.username = username;
        }
        public string getUsername()
        {
            return username;
        }

        //成员变量Password
        private string password;
        public void setPassword(String password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
