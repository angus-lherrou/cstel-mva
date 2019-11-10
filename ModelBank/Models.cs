using System;

namespace ModelBank {
    class Model {
        private string Name;
        private string Path;

        public Model(string name, string path) {
            Name = name;            
            Path = path;
        }

        public string GetName() {
            return Name;
        }

        public string GetPath() {
            return Path;
        }

        public override string ToString() {
            return String.Format("{0} ({1})", Name, Path);
        }
    }
}