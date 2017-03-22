using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_LambdaExpression
{
    class Program
    {
        delegate int CalculateAreaDel(int a);
        static void Main(string[] args)
        {
            //             create a delegate object then use lambda expression for funcation body
            //             in below x => x * x is shortcut to, x before => is variable
            //
            //              public static int MyFunction(int x)
         //                 {
         //                     return x * x ;
         //                 }
         //
         //            CalculateAreaDel A = x => x * x;

            CalculateAreaDel A = x => x * x;

            Console.WriteLine(A(9));
            Console.Read();
        }
    }
}
