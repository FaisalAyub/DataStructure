using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public class StringPractise
    {
        string name2 = "";
        
        public  string removeDuplicateString(string name)
        {
            for (int x = 0; x <name.Length; x++)
            {
                if (name2.IndexOf(name[x]) == -1)
                {
                    name2 += name[x];
                }
            }
            return name2;
        }


        public string countCharacterOfString(string name)
        {
          var name3=  name.GroupBy(x => x).Select(x=> new { x.Key,count=x.Count()});
            foreach(var key in name3)
            {
                Console.WriteLine(key.Key+" = "+key.count);
            }
            return null;
        }

        public string ReverseString(string name)
        {
            string reverseString = "";
            
            for(int x = name.Length-1; x >= 0;x--)
            {
                reverseString += name[x];
            }
                return reverseString;
        }


        public string[] countWordOfString(string name)
        {
           var name2= name.Split(',');

            return name2;
        }

        public List<DateTime> getDayOfMonth(int year,int month)
        {
            List<DateTime> dateTimes = new List<DateTime>();

           int days= DateTime.DaysInMonth(year, month);
            for(int x = 1; x <= days; x++)
            {
                DateTime day = new DateTime(year, month, x);

                if (day.DayOfWeek == DayOfWeek.Monday)
                {
                    dateTimes.Add(new DateTime(year, month, x));
                }
            }
 
            return dateTimes;
        }

        public List<DateTime> getDaysOfSpecificDuration(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> mondays = new List<DateTime>();

            while (dateFrom < dateTo)
            {
                if (dateFrom.DayOfWeek == DayOfWeek.Monday)
                {
                    mondays.Add(new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day));
                    dateFrom= dateFrom.AddDays(1);
                }
                else
                {
                    dateFrom= dateFrom.AddDays(1);
                    
                }
            }
          

            return mondays;
        }
         
        public int[] bubbleSorting(int[] arrayNumber)
        {
            for(int x = 0; x < arrayNumber.Length; x++)
            {
                for(int y = 0; y < arrayNumber.Length - 1; y++)
                {
                    if (arrayNumber[y] > arrayNumber[y + 1])
                    {

                        int temp = arrayNumber[y + 1];
                        arrayNumber[y + 1] = arrayNumber[y];
                        arrayNumber[y] = temp;

                    }

                }
            }
            return arrayNumber;

        }
    }
 
}
