using System;
using System.Collections.Generic;

namespace modelbank {
    class Model {
        private HashSet<string> Identifiers;
        private string Id;
        private string Name;

        private string Path;

        public Model(HashSet<string> identifiers, string name, string path) {
            Identifiers = identifiers;
            Name = name;
            Id = GenUuid();            
            Path = path;
        }

        string GenUuid() {
            var id = Uuid.UUID_Make();
            var count = 0;
            while (Identifiers.Contains(id)) {
                id = Uuid.UUID_Make();
                count++;
                if (count >= 3) {
                    throw new CollisionException(id);
                }
            }
            Identifiers.Add(id);
            return id;
        }

        public string GetId() {
            return Id;
        }

        public string GetName() {
            return Name;
        }

        public string GetPath() {
            return Path;
        }

        public override string ToString() {
            return String.Format("{0} ({1})", Name, Id);
        }
    }
}