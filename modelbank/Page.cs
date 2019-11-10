using System.Collections.Generic;

namespace modelbank {
    class Page {
        List<string> Names;

        public Page() {
            Names = new List<string>();
        }

        public void Add(string uuid) {
            Names.Add(uuid);
        }

        /// <remarks>
        /// To return an individual name, just use GetNameList()[index]
        /// </remarks>
        public List<string> GetNameList() {
            return Names;
        }
    }
}