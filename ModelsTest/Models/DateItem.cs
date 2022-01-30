using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest.Models
{
    public class DateItem: Item
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }
        [NotMapped]
        public DateTime This { get; set; }
        public DateItem()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            
        }

       public void initthis()
        {
            This = new DateTime(Year, Month, Day);
            
        }

        public DateItem(DateTime date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            This = new DateTime(Year, Month, Day);
        }

        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}гг";
        }

        public static List<DateItem> Sorting(List<DateItem> dates, bool New = false, bool Old = false)
        {
            List<DateItem> result = new List<DateItem>();



            return result;
        }
    }
}
