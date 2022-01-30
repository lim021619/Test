using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest.Models
{
   public class Item 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item()
        {
            InitObject();
        }
        protected virtual void InitObject() { }
    }
}
