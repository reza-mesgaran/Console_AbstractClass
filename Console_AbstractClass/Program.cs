using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class MyNormalClass
    {
        // public abstract void MyAbstractMethod1();    Error : Abstract-Method only acceptable on Abstract-Class
    }

    abstract class MyAbstractClass    // Abstract-Class Can have All type of methodes.
    {
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
        public override void MyAbstractMethod()     //Any Class which inherited from abstract-class should implement all abstracts methods

        {
            
        }
    }
}
