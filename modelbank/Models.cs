using System;
using System.Collections.Generic;
using System.IO;

namespace modelbank {
    class Model {
        private HashSet<string> Identifiers;
        private string Id;
        private string Name;

        public Model(HashSet<string> identifiers, string name) {
            Identifiers = identifiers;
            Name = name;
            Id = GenUuid();
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

        public string getId() {
            return Id;
        }

        public string getName() {
            return Name;
        }

        public override string ToString() {
            return String.Format("{0} ({1})", Name, Id);
        }
    }
}