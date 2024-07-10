using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {

        public int Id {  get; set; }
        public string? Model {  get; set; }
        public decimal Speed {  get; set; }
        public Car(int Id ,string Model ,decimal Speed)
        {
            this.Id = Id;
            this.Model = Model;
            this.Speed = Speed;
            Console.WriteLine("Constructor 1");
        }
        public Car(int Id, string Model):this(Id,Model,200)
        {
            Console.WriteLine("Constructor 2");
        }
        public Car(int Id) : this(Id, "BMW", 300) //Constrctor chain 
        {
            Console.WriteLine("Constructor 3");
        }
        public override string ToString()
        {
            return $"Id : {Id}\nModel is :{Model}\nSpeed ={Speed}";
        }
    }
}
