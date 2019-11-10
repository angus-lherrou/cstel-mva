using System;
namespace ModelBank {
    class CollisionException : Exception {
        public CollisionException() {

        }
        public CollisionException(string id) : base(String.Format("UUID collision error: collided 3 times. Latest: {0}", id)) {
            
        }
    }

    class DuplicateNameException : Exception {
        public DuplicateNameException() {

        }

        public DuplicateNameException(string name, string book) : base(String.Format("Model with name {0} already exists in book {1}", name, book)) {
            
        }
    }
}