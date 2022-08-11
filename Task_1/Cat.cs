using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Cat : Animal
    {
        string name;
        const string sound = "Мяу";
        public override string Name { get => name; set => name = value; }

        public override void Say()
        {
            Console.WriteLine(sound);
        }

        public Cat(string name)
            : base(name)
        {
            //nothing to override
        }
    }
}
