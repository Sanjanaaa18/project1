using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class multilevel
    {

        public void dog()
        {
            Console.WriteLine("Dog is barking");
        }
        public void eat()
        {
            dog();
            Console.WriteLine("Dog is eating");
        }
        public void bone()
        {
            eat();
            Console.WriteLine("Dog is chewing a bone");
        }
    }
}
