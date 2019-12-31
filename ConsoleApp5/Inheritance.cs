using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  public  class Order
    {
       protected Order()
        {

        }
        private int ID { get; set; }
        protected string  OrderName { get; set; }
        public  string OrderDetails { get; set; }
    }

    public class Items:Order
    {
        private int ItemID { get; set; }
        protected string ItemName { get; set; }
        public string ItemDetails { get; set; }
       

        void Get()
        {
            Items items = new Items();
            Mainn Gmain = new Mainn();
        }

    }

   public class Mainn:Items
    { 

        void Test()
        {
            Items items = new Items();
            Mainn mainn = new Mainn();
            



        }
       
    }


}
