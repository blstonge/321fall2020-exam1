using System;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            ISave database = new DatabaseSave();
            ISave cloud = new CloudSave();
            ISave external = new ExternalSave();

            MenuItem newMenuItem = new MenuItem(){Name = "Lemon Pie", Description = "One slice of Lemon Pie", Price = 3.50};

            Console.WriteLine("Select where you would like to save the menu item:\n(1) Local Database"
            + "\n(2) Cloud\n(3) External Device");

            try
            {
                input = int.Parse(Console.ReadLine());
                if(input < 1 || input > 3)
                {
                    throw new Exception("Not a valid menu choice");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Clear();
                if (input == 1)
                {
                    newMenuItem.SetSaveBehavior(database);
                    newMenuItem.saveBehavior.Save(newMenuItem);
                }
                else if (input == 2)
                {
                    newMenuItem.SetSaveBehavior(cloud);
                    newMenuItem.saveBehavior.Save(newMenuItem);
                }
                else if (input == 3)
                {
                    newMenuItem.SetSaveBehavior(external);
                    newMenuItem.saveBehavior.Save(newMenuItem);
                }
            }

        }
    }
}
