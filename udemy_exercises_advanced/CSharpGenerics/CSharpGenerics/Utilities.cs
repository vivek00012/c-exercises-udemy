using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    //generics with constraints..
    //where T:IComparable-applying constraints to interface
    //T:Product-applying constraints to class
    //T:Struct-applying constraints to value tyoe
    //T:class
    //T:new()

    public class Utilities<T> where T : IComparable,new()
    {
        //conventional way..
        //takes only integer..
        public int Max(int a,int b)
        {
            return a > b ? a : b;
        }
        //instantiating T with Default Constructor
        public void DoSomething(T value)
        {
            var obj = new T();
        }
        //with generics
        public T Max(T a ,T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
