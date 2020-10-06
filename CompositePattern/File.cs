using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class File : IAbstractComponent
    {
        private readonly string _name;

        public File(string name) 
        {
            _name = name;
        }
        public void PrintName()
        {
            Console.WriteLine($"File: {_name}");
        }
    }
}
