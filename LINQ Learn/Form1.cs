using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

        #region WHERE 
        //Where运算符（Linq扩展方法）根据给定的条件表达式过滤集合并返回一个新的集合。条件可以指定为lambda表达式或Func委托类型。
        // 在其中扩展方法有以下两个重载。两种重载方法都接受一个Func委托类型参数。需要一个过载Func<TSource，bool> 输入参数和所需的第二个重载方法Func<TSource，int，bool>输入参数其中int用于索引：


        private void button2_Click(object sender, EventArgs e)
        {
            //使用Where子句过滤集合中的奇数元素并仅返回偶数元素。请记住，索引从零开始。
            var filteredResult = studentList.Where((s, i) => {
                if (i % 2 == 0) // if it is even element
                    return true;

                return false;
            });

            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);
        }
        

        #endregion

        #region 使用OfType运算符根据每个元素的类型过滤上述集合
        private void button1_Click(object sender, EventArgs e)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;
            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }
            
        }
        #endregion

        #region  OrderBy
        
        private void button3_Click(object sender, EventArgs e)
        {
            //var orderResult = from result in studentList
            //                  orderby result.Age descending
            //                  select result;
            //foreach (var item in orderResult)
            //{
            //    Console.WriteLine(item.Age);
            //}
            //方法查询示例
            Func<Student, int> forOrderby = new Func<Student, int>(GetString);
            var orderResult = studentList.OrderBy(delegate (Student s) { return s.Age; });
            foreach (var item in orderResult)
            {
                Console.WriteLine(item.Age);
            }
            var orderDesc = studentList.OrderBy(delegate (Student s) { return s.Age; });
        }
        private int GetString(Student s)
        {
            return s.Age;
        }
        #endregion
    }
}
