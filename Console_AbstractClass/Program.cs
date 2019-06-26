using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Note:
    Abstract Class    : has abstarct and normal member
    Abstract Members  : should located on Abstract class (Only)
    Abstract Class :Can not instantiated so Abstract class's constructor will run only 
                    If another class inherit from that abstarct class
 */
namespace Console_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //  MyAbstractClass m1 = new MyAbstractClass(); Error


            MyChildClass m1 = new MyChildClass();    //1st method of calling Abstract class's Constructor
            //Or
            MyAbstractClass m2 = new MyChildClass(); //2st method of calling Abstract class's Constructor
    
            m1.MyAbstractMethod();

            Console.ReadKey();
        }
    }


    class MyNormalClass
    {
        // public abstract void MyAbstractMethod1();    Error : Abstract-Method only acceptable on Abstract-Class
    }

    abstract class MyAbstractClass    // Abstract-Class Can have All type of methodes.
    {
        public MyAbstractClass()
        {
            Console.WriteLine("I am Default Constructor of Abstarct Class");
        }
        public MyAbstractClass(string i)
        {
            Console.WriteLine("I am Parameterized Constructor of Abstarct Class : {0} ", i);
        }
        public abstract void MyAbstractMethod();    //Abstract-Method of Abstract-Class

        public static void MyStaticMethod()         //Static-Method of Abstract-Class
        {

        }              
        public void MyNormalMethod()            //Normal-Method of Abstract-Class
        {

        }
    }


    class MyChildClass : MyAbstractClass
    {
        public MyChildClass()
        {            
            Console.WriteLine("I'm Constructor of normal Child class which derived from an Abstract Class");
        }
        public override void MyAbstractMethod()     //Any Class which inherited from abstract-class should implement all abstracts methods

        {
            Console.WriteLine("I Overrided an Abstract Method");
        }
    }
}
