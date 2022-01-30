using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class ContextDb:DbContext
    {
        public DbSet<ModelsTest.Models.DateItem> Dates { get; set; }
        public DbSet<ModelsTest.Models.Book> Books { get; set; }

        public ContextDb() : base("appdb")
        {

        }

        public ContextDb(bool local = true):base("localdb")
        {

        }
    }
}