using System.Collections.Generic;

namespace modelbank {
    class Book {
        string Name;
        HashSet<string> Identifiers;
        Dictionary<string,Model> Models;
        HashSet<string> Names;
        List<Page> Pages;

        public Book(string name) {
            Identifiers = new HashSet<string>();
            Names = new HashSet<string>();
            Models = new Dictionary<string, Model>();
            Pages = new List<Page>();
            Name = name;
        }

        public void Add(string name, string path) {
            if (!Names.Contains(name)) {
                var m = new Model(Identifiers, name, path);
                Models.Add(m.GetName(), m);
                Names.Add(name);
            } else {
                throw new DuplicateNameException(name, Name);
            }
            
        }

        public void AddPage() {
            Pages.Add(new Page());
        }

        public void InsertPage(int index) {
            Pages.Insert(index, new Page());
        }

        public void AddToPage(int pageNumber, string name) {
            GetPage(pageNumber).Add(GetModel(name).GetId());
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