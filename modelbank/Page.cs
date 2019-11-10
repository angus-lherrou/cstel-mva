using System.Collections.Generic;

namespace modelbank {
    class Page {
        List<string> Ids;

        public Page() {
            Ids = new List<string>();
        }

        public void Add(string uuid) {
            Ids.Add(uuid);
        }

        /// <remarks>
        /// To return an individual ID, just use GetIdList()[index]
        /// </remarks>
        public List<string> GetIdList() {
            return Ids;
        }
    }
}