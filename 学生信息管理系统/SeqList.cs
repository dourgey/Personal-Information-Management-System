using System;

namespace 学生信息管理系统
{
    public interface IListDS<T>
    {
        int GetLength();//求长度
        void Clear();//请空操作
        bool IsEmpty();//判断线性表是否为空
        void add(T item);//添加操作
        void Insert(T item, int index);//插入操作
        T Delete(int i);//删除操作
        T GetElem(int i);//取表元
        T this[int index] { get; }//定义一个索引器，获取元素
        int Locate(T value);//按值查找
    }
   class SeqList<T> : IListDS<T>
    {
        private T[] data;
        private int count = 0;

        public SeqList(int size)//构造函数
        {
            data = new T[size];
            count = 0;
        }
        public SeqList()
            : this(10)//默认构造函数，容量为10
        {

        }
        public int GetLength()
        {
            return count;
        }
        public void Clear()
        {
            count = 0;
        }
        public bool IsEmpty()  //判断线性表是否为空，true为空
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void add(T item)//添加操作
        {
            if (count == data.Length)
            {
                Console.WriteLine("线性表已存满！");
            }
            else
            {
                data[count] = item;
                count++;
                Console.WriteLine("添加成功！");
            }
        }
        public void Insert(T item, int index)//插入操作
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }
        public T Delete(int index)//删除操作
        {
            T temp = data[index];
            for (int i = index; i < count; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
            return temp;
        }
        public T GetElem(int i)//取表元
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("线性表为空！");
                return default(T);
            }
            else
            {
                return this.data[i];
            }
        }
        public T this[int index] //定义一个索引器，获取元素
        {
            get
            {
                return this.data[index];
            }
        }
        public int Locate(T value)//按值查找
        {
            int temp = 0;
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    temp = i;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("线性表中无该数据！");
                return 0;
            }
            else
            {
                Console.WriteLine("已查找到该数据！");
                return temp;
            }
        }
    }
}
