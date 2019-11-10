using System;
using System.IO;
using System.Collections.Generic;

namespace modelbank {
    class Program {
        
        static void Main(string[] args) {
            Dictionary<string, string> bookNames = new Dictionary<string, string>();
            foreach (string s in File.ReadLines(args[1])) {
                var pairs = s.Split('|');
                pairs[1] = OsCompat.LocalizedPath(pairs[1]);
                bookNames.Add(pairs[0], pairs[1]);
            }
            var book = new Book(args[0]);
            foreach ((string name, string path) in bookNames) {
                book.Add(name, path);
            }
            book.AddPage();
            book.AddToPage(0, "theobromine");
            try {
                Console.WriteLine(Directory.GetCurrentDirectory());
            } catch (Exception e) {
                Console.WriteLine("Exception! "+e);
            }
            Console.WriteLine(GetAbsoluteModelPath(GetModelOnPage(book, 0, 0)));
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
