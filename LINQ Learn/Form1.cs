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
            var filteredResult = studentList.Where((s, i) =>
            {
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

        #region Join  

        IList<Student> joinstudentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};

        IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};
        /* join 的两个重载方法
         * public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, 
                                                        IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, 
                                                        Func<TInner, TKey> innerKeySelector, 
                                                        Func<TOuter, TInner, TResult> resultSelector);

         public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, 
                                                        IEnumerable<TInner> inner, 
                                                        Func<TOuter, TKey> outerKeySelector,
                                                        Func<TInner, TKey> innerKeySelector, 
                                                        Func<TOuter, TInner, TResult> resultSelector,
                                                        IEqualityComparer<TKey> comparer);
         */
        private void button4_Click(object sender, EventArgs e)
        {
            #region 方法语法
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };

            IList<string> strList2 = new List<string>() { "One", "Two", "Five", "Six" };

            var innerjoin = strList1.Join(strList2, str1 => str1, str2 => str2, (str1, str2) => str2);
            foreach (var item in innerjoin)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 查询语法
            /* 
              from ... in outerSequence
              join ... in innerSequence  
             on outerKey equals innerKey
            select ...
           */
           
            var queryJoin = from s in joinstudentList
                            join st in standardList
                            on s.StandardID equals st.StandardID
                            select new { studentName = s.StudentName, StandardName = st.StandardName };

            foreach (var item in queryJoin)
            {
                Console.WriteLine(item.studentName+"---"+item.StandardName);
            }
            #endregion

        }


        #endregion

        #region GroupJoin
        /*GroupJoin 的两个重载方法
         public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector);

         public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer);

         */
        private void button5_Click(object sender, EventArgs e)
        {

            #region 方法查询
            joinstudentList.GroupJoin(standardList, student => student.StandardID, stand => stand.StandardID, (student, standGroup) => new { group = standGroup, StandarFulldName = student.StudentName });
            #endregion
            #region 语法查询
            var groupJoin = from std in standardList
                            join s in joinstudentList
                            on std.StandardID equals s.StandardID
                                into studentGroup
                            select new
                            {
                                Students = studentGroup,
                                StandardName = std.StandardName
                            };

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandardName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
            #endregion

        }
        #endregion

        #region ElementAt ElementAtOrDefault
        
        private void button6_Click(object sender, EventArgs e)
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

            Console.WriteLine("10th Element in intList: {0} - default int value",
                            intList.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in strList: {0} - default string value (null)",
                             strList.ElementAtOrDefault(9));


            Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(intList.ElementAt(9));
        }
        #endregion

        #region First FirstOrDefault
    private void button7_Click(object sender, EventArgs e)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
            IList<string> nulllist = null;


            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.First());
            var teststr = strList.First();
            var tets = strList.FirstOrDefault();

            Console.WriteLine("emptyList.First() throws an InvalidOperationException");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("my test: emptyList.FirstOrDefault() :" +emptyList.FirstOrDefault());
            var nui = nulllist.First();
            var nu= nulllist.FirstOrDefault();
           
            Console.WriteLine(emptyList.First());

          
        }
        #endregion

        #region DefaultIfEmpty
        private void button8_Click(object sender, EventArgs e)
        {
            List<string> emptyList = new List<string>();
            List<string> testlist = null;
           
            testlist.DefaultIfEmpty();
             var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));
        }
        #endregion

        #region Empty
        private void button9_Click(object sender, EventArgs e)
        {
            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);

            var intCollection = Enumerable.Range(10, 10);
        }
        #endregion

        #region Skip & SkipWhile
        private void button10_Click(object sender, EventArgs e)
        {
            IList<string> strList = new List<string>() { "Three",
                                            "Four",
                                            "Five",
                                            "Hundred" };
          var result=  strList.TakeWhile(s=>s.Length>4);
            foreach (string str in result)
                Console.WriteLine(str);
        } 
        #endregion
    }
}
