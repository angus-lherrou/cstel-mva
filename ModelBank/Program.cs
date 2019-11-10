using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                throw new ArgumentException("Not the right arguments!");
            }
            string modelManifest = args[0];
            string pageManifest = args[1];
            int pageNumber = Convert.ToInt32(args[2]);
            int modelNumber = Convert.ToInt32(args[3]);
            ModelBank.ModelBank mb = new ModelBank.ModelBank("book");
            try {mb.MakeBook(modelManifest);
            mb.MakePages(pageManifest);
            Console.Write(mb.GetUnityPath(pageNumber, modelNumber));
            } catch (FileNotFoundException e) {
                Console.WriteLine("File(s) not found");
            }
        }
    }
}
