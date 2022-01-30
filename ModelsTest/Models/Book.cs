using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest.Models
{
    public class Book : Item
    {
        public DateItem Date { get; set; }
        public string Author { get; set; }


        public Book()
        {

        }

        protected override void InitObject()
        {
            Date = new DateItem();
            
        }

    }
}
