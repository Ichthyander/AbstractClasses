using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Animal
    {
        string name;

        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string Say();

        public void ShowInfo()
        {
            Console.WriteLine(name);
            Say();
        }
    }
}
