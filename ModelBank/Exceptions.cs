using System;
namespace ModelBank {
    class DuplicateNameException : Exception {
        public DuplicateNameException() {

        }

        public DuplicateNameException(string name, string bookName) : base(String.Format("Model with name {0} already exists in book {1}", name, bookName)) {
            
        }
    }

    class ModelDoesNotExistException : Exception {
        public ModelDoesNotExistException() {

        }

        public ModelDoesNotExistException(string name, string bookName) : base(String.Format("Model with name {0} does not exist in book {1}", name, bookName)) {
            
        }
    }
}