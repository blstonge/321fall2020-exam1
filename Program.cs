using System;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem newMenuItem = new MenuItem(){Name = "Lemon Pie", Description = "One slice of Lemon Pie", Price = 3.50};

            MenuItem.Save(newMenuItem);
        }
    }
}
