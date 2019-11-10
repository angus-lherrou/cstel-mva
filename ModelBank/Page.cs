using System.Collections.Generic;

namespace ModelBank {
    class Page {
        List<string> Names;

        public Page() {
            Names = new List<string>();
        }

        public void Add(string name) {
            Names.Add(name);
        }

        /// <remarks>
        /// To return an individual name, just use GetNameList()[index]
        /// </remarks>
        public List<string> GetNameList() {
            return Names;
        }
    }
}