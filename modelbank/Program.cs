using System;
using System.IO;
using System.Collections.Generic;

namespace modelbank {
    class Program {
        
        static void Main(string[] args) {
            List<Book> books = new List<Book>();
            var book1 = new Book("Chem 100");
            books.Add(book1);
            book1.Add("buckyball", "models\\buckyball.fbx");
            book1.Add("theobromine", "models/Theobromine.obj");
            book1.AddPage();
            book1.AddToPage(0, "theobromine");
            try {
                Console.WriteLine(Directory.GetCurrentDirectory());
            } catch (Exception e) {
                Console.WriteLine("Exception! "+e);
            }
            
            Console.WriteLine(GetAbsoluteModelPath(GetModelOnPage(book1, 0, 0)));
        }

        public static Model GetModelOnPage(Book b, int page, int num) {
            var id = b.GetPage(page).GetNameList()[num];
            return b.GetModel(id);
        }

        public static string GetAbsoluteModelPath(Model model) {
            string p = "No path!";
            try {
                p = Path.GetFullPath(model.GetPath());
            } catch (Exception e) {
                e.ToString();
            }
            return p;
        }
    }
}
