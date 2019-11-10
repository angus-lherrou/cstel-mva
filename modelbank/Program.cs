using System;
using System.Collections.Generic;

namespace modelbank {
    class Program {
        
        static void Main(string[] args) {
            List<Book> books = new List<Book>();
            var book1 = new Book("Chem 100");
            books.Add(book1);
            book1.Add("water");
            book1.Add("glucose");
            Console.WriteLine(books[0]);
        }

        public static Model GetModelOnPage(Book b, int page, int num) {
            var id = b.GetPage(page).GetIdList()[num];
            return b.GetModel(id);
        }
    }
}
