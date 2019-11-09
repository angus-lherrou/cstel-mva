using System;

namespace cstel_mva
{
    class Program
    {
        static void Main(string[] args)
        {
            Max maxwell = new Max();
            Console.WriteLine(maxwell.getName());
        }
    }

    class Max
    {
        private string name;
        public Max()
        {
            name = "Max";
        }

        public string getName()
        {
            return name;
        }
    }
}
