using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int z { get; set; }
        public Child()
        {

        }
        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return $"x : {x}\ny : {y}\nz : {z}";
        }
        public new void Print() // Override using new
        {
            Console.WriteLine("I am A Child");
        }
        public override void Display() //override using override (parent's Method is public virtual)
        {
            Console.WriteLine("I am A Child");
        }
    }
}
