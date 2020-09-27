using System;
namespace exam1
{
    public class ExternalSave : ISave
    {
        public void Save(MenuItem item)
        {
            Console.WriteLine($"Saving {item.Name} to an external device");
        }
    }
}