using System.IO;
using System.Collections.Generic;

namespace ModelBank {
    class ModelBank {

        Book Book;
        Dictionary<string, string> ModelDict;

        static void Main(string[] args) {
            
        }
        
        public ModelBank(string name) {
            ModelDict = new Dictionary<string, string>();
            Book = new Book(name);
        }
        public void MakeBook(string[] args) {
            foreach (string s in File.ReadLines(args[2])) {
                var pairs = s.Split('|');
                pairs[1] = OsCompat.LocalizedPath(pairs[1]);
                ModelDict.Add(pairs[0], pairs[1]);
            }
            Book = new Book(args[1]);
            foreach ((string n, string path) in ModelDict) {
                Book.Add(n, path);
            }
        }

        public void MakePages(string f) {
            foreach (string s in File.ReadLines(f)) {
                Page p = new Page();
                Book.AddPage(p);
                var models = s.Split(',');
                foreach (string name in models) {
                    p.Add(name);
                }
            }
        }

        public string GetPath(int pageNumber, int modelNumber) {
            return GetAbsoluteModelPath(GetModelOnPage(Book, pageNumber, modelNumber));
        }

        static Model GetModelOnPage(Book b, int page, int num) {
            var id = b.GetPage(page).GetNameList()[num];
            return b.GetModel(id);
        }

        static string GetAbsoluteModelPath(Model model) {
            return Path.GetFullPath(model.GetPath());
        }
    }
}
