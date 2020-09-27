using System;
namespace exam1
{
    public class CloudSave : ISave
    {
        public void Save(MenuItem item)
        {
            Console.WriteLine($"Saving {item.Name} to the cloud");
        }
    }
}