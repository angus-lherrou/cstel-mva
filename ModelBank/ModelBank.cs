using System.IO;
using System.Collections.Generic;

namespace ModelBank {
    class ModelBank {

        Book Book;
        Dictionary<string, string> ModelDict;
        
        public ModelBank(string name) {
            ModelDict = new Dictionary<string, string>();
            Book = new Book(name);
        }
        public void MakeBook(string pathToModelManifest) {
            foreach (string s in File.ReadLines(pathToModelManifest)) {
                var pairs = s.Split('|');
                if (pairs.Length != 2) {
                    throw new FileLoadException("Model manifest not formatted correctly!");
                }
                pairs[1] = OsCompat.LocalizedPath(pairs[1]);
                ModelDict.Add(pairs[0], pairs[1]);
            }
            foreach ((string n, string path) in ModelDict) {
                try {
                    Book.Add(n, path);
                } catch (DuplicateNameException e) {
                    throw new FileLoadException(e.Message);
                }
            }
        }

        public void MakePages(string pathToPageManifest) {
            foreach (string s in File.ReadLines(pathToPageManifest)) {
                Page p = new Page();
                Book.AddPage(p);
                var models = s.Split(',');
                foreach (string name in models) {
                    if (!ModelDict.ContainsKey(name)) {
                        throw new ModelDoesNotExistException(name, Book.GetName());
                    }
                    p.Add(name);
                }
            }
        }

        public string GetPath(int pageNumber, int modelNumber) {
            return GetAbsoluteModelPath(GetModelOnPage(pageNumber, modelNumber));
        }

        Model GetModelOnPage(int page, int num) {
            var id = Book.GetPage(page).GetNameList()[num];
            return Book.GetModel(id);
        }

        static string GetAbsoluteModelPath(Model model) {
            return Path.GetFullPath(model.GetPath());
        }
    }
}
