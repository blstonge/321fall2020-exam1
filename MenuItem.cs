using System;
namespace exam1
{
    public class MenuItem
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}

        public static void Save(MenuItem item){
            Console.WriteLine($"Saving {item.Name} to the local database");
        }
    }
}