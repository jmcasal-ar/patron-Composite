using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Directory : IAbstractComponent
    {
        private readonly string _name;
        private List<IAbstractComponent> _components;

        public Directory(string name) 
        {
            _name = name;
            _components = new List<IAbstractComponent>();
        }

        public void AddComponent(IAbstractComponent component) 
        {
            _components.Add(component);
        }

        public void PrintName()
        {
            Console.WriteLine($"Folder: {_name}");
            foreach (var component in _components)
            {
                component.PrintName();
            }       
            
        }
    }
}
