using Demo.Inheritance;
using System.Security.Principal;

namespace Demo
{
    internal class Program
    {
        #region Func Overloading 
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z)// Count Of Parameter
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)//Different data type
        {
            return x + y;
        }
        #endregion
        public static void Main(string[] args)
        {
            #region Constructor Chaining
            //Car C1 = new Car(1);
            //Console.WriteLine(C1);
            #endregion
            #region Struct Vs Class
            #region Class
            //1 - Allowed Access Modifiers In Class
            //Private (Default) in Class
            //Internal (Default) for Class
            //Public
            //Prodected 
            //Provate Protected
            //Internal Protected
            //2 - Reference Type (Address In Stack , Value In Heap)
            //3 - Support Encapsulation ,Inheritance ,Polymorphism(Overloading , Overriding) ,Abstraction
            /*4 - If You Defined a User Defined Constructor Compiler
                  Will No Longer Generate ParameterLess Constructor*/
            #endregion
            #region Struct
            //1 - Allowed Access Modifiers In Struct
            //Private 
            //Internal (Default) For Struct
            //Public (Default) in Struct
            //2 - Value Type (Address And Object In Stack)
            //3 - Support Encapsulation ,Polymorphism(Overloading)
            /*4 - If You Defined a User Defined Constructor Compiler 
                  Will Always Longer Generate ParameterLess Constructor*/
            #endregion
            #endregion
            #region Inheritance
            //Relation Is A
            //Child c1 = new Child(2,9,8);
            //Console.WriteLine(c1);
            #endregion
            #region Overloading
            //int a = Sum(6, 7); user defined function
            //Console.WriteLine(); Built in function
            #endregion
            #region Overriding
            //Child c1 = new Child();
            //c1.Print();
            //c1.Display();
            #endregion
        }
    }
}
