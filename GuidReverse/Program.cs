using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("ClassA");
        }
        public void Method()
        {
            Console.WriteLine("MethodA");
        }
    }

    internal class ClassB : ClassA
    {
        public ClassB()
        {
            Console.WriteLine("ClassB");
        }
        public void Method()
        {
            Console.WriteLine("MethodB");
        }
    }

    internal class ClassC : ClassB
    {
        public ClassC()
        {
            Console.WriteLine("ClassC");
        }
        public void Method()
        {
            Console.WriteLine("MethodC");
        }
    }

    internal class ClassD : ClassC
    {
        public ClassD()
        {
            Console.WriteLine("ClassD");
        }
        //public override void Method()
        //{
        //    Console.WriteLine("MethodD");
        //}
    }

    public sealed class Program
    {
        /*public class TestClass
        {
            public int a;
            //public TestClass(int a = 1)
            //{
            //    this.a = a;
            //}
        }*/

        /*private static void GetVal(out int v)
        {
            v = 10;
        }

        private static void GetVal(out TestClass val)
        {
            val = new TestClass();
            val.a = 10;
        }*/


        public static void Main(string[] args)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0)
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                Console.Write("WRONG!");
            }

            for(int i = 1; i <= num; i++)
            {
                if(i%3 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            ClassA classA = new ClassA();
            ClassA classB = new ClassB();
            ClassC classC = new ClassC();
            ClassD classD = new ClassD();
            classA.Method();
            classB.Method();
            classC.Method();
            classD.Method();


            /*int x;
            TestClass y = new TestClass();
            GetVal(out y);
            GetVal(out x);
            Console.WriteLine(x);
            Console.WriteLine(y.a);*/
        }
    }
}
