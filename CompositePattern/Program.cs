using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractComponent f1 = new File("File1");
            IAbstractComponent f2 = new File("File2");
            IAbstractComponent f3 = new File("File3");
            IAbstractComponent f4 = new File("File4");
            IAbstractComponent f5 = new File("File5");

            Directory d1 = new Directory("Folder1");
            Directory d2 = new Directory("Folder2");
            Directory d3 = new Directory("Folder3");

            d1.AddComponent(f1);
            d1.AddComponent(f2);
            d2.AddComponent(f3);
            d2.AddComponent(f4);
            d3.AddComponent(f5);
            d1.AddComponent(d2);
            d2.AddComponent(d3);

            d1.PrintName();
            Console.WriteLine("Hola mundo");
            Console.ReadKey();
        }
    }
}
