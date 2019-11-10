using System.Collections.Generic;

namespace ModelBank {
    class Book {
        string Name;
        Dictionary<string,Model> Models;
        HashSet<string> Names;
        List<Page> Pages;

        public Book(string name) {
            Names = new HashSet<string>();
            Models = new Dictionary<string, Model>();
            Pages = new List<Page>();
            Name = name;
        }

        public void Add(string name, string path) {
            if (!Names.Contains(name)) {
                var m = new Model(name, path);
                Models.Add(m.GetName(), m);
                Names.Add(name);
            } else {
                throw new DuplicateNameException(name, Name);
            }
            
        }

        public void AddPage() {
            this.AddPage(new Page());
        }

        public void AddPage(Page page) {
            Pages.Add(page);
        }

        public void InsertPage(int index) {
            this.InsertPage(index, new Page());
        }

        public void InsertPage(int index, Page page) {
            Pages.Insert(index, page);
        }

        public void AddToPage(int pageNumber, string name) {
            GetPage(pageNumber).Add(GetModel(name).GetName());
        }
        public Page GetPage(int page) {
            return Pages[page];
        }

        public Model GetModel(string name) {
            return Models[name];
        }

        public override string ToString() {
            var str = "";
            foreach ((string id, Model m) in Models) {
                str += m + System.Environment.NewLine;
            }
            return str.Substring(0,str.Length-1);
        }
    }
}