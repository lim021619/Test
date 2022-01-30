using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        Models.ContextDb Context { get; set; }
        List<ModelsTest.Models.Book> Books { get; set; }

        public HomeController()
        {
            Context = new Models.ContextDb(true);
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Анна Каренина", Author = "Толстой Л.Н.", Date = new ModelsTest.Models.DateItem(new DateTime(1878, 6, 25))});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Евгений Онегин", Author ="Пушкин А.С.", Date = new ModelsTest.Models.DateItem(new DateTime(1837, 1, 1))});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Мастер и Маргарита", Author ="Булгаков", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Бесы", Author ="Достоевский", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Герой нашего времени", Author ="Лермантов М.Ю.", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Записки из мертвого дома", Author ="Достоевский", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Капитанская дочка", Author ="Пушкин А.С.", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Руслан и Людмила", Author ="Пушкин А.С.", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Воскресенье", Author ="Толстой Л.Н.", Date = new ModelsTest.Models.DateItem(new DateTime())});
            //Context.Books.Add(new ModelsTest.Models.Book() { Name = "Тихий Дон", Author ="Шолохов", Date = new ModelsTest.Models.DateItem(new DateTime())});
            Context.SaveChanges();
            
            Books = Context.Books?.Include(b => b.Date).AsNoTracking().ToList();
            
        }
        [HttpGet]
        public ActionResult Index()
        {

            return View(Books);
        }

        [HttpPost]
        public ActionResult Index(string namesorting)
        {
            Sorting(namesorting);
            return View(Books);
        }

        public void Sorting(string namesorting)
        {

            List<ModelsTest.Models.Book> b = new List<ModelsTest.Models.Book>();

            switch (namesorting)
            {
                case "byName":sortingName();break;
                case "byAuthor": sortingAuthor(); break;
                case "byDate": sortingDate(); break;   
                case "byId": sotringId(); break;   
            }

            
        }

        
        void sortingName()
        {
            Books.Sort((x, e) => String.Compare(x.Name, e.Name)) ;
        }

        void sortingDate()
        {
            foreach (var item in Books)
            {
                item.Date.initthis();

            }
            Books.Sort((x, e) => DateTime.Compare(x.Date.This, e.Date.This));
            
        }

        void sortingAuthor()
        {
            Books.Sort((x, e) => String.Compare(x.Author, e.Author));
        }

        void sotringId()
        {
            
            Books.Sort((x, e) => x.Id.CompareTo(e.Id));
        }

        
    }
}