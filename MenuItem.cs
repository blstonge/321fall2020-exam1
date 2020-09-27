using System;
namespace exam1
{
    public class MenuItem
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}
        public ISave saveBehavior;

        public void SetSaveBehavior(ISave value)
        {
            saveBehavior = value;
        }

        public void Save(MenuItem item)
        {
            SetSaveBehavior(new DatabaseSave());
        }
    }
}