using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{


    public abstract class Person
    {
        public abstract int ID { get; set; }
        protected virtual string PersonName { get; set; }
    }

  public  class Book:Person
    {
        public int quantity { get; set; }
        protected string name { get; set; }
        protected override string PersonName { get; set; } 
        public override int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void TestOne()
        {
            this.PersonName = "";
            base.PersonName = "";
        }
    }

    public class Main:Book
    {

        Book book = new Book();
        public void testTwo()
        {
            
        }
    }
}
