using System;
namespace exam1
{
    public class DatabaseSave : ISave
    {
        public void Save(MenuItem item)
        {
            Console.WriteLine($"Saving {item.Name} to the local database");
        }
    }
}