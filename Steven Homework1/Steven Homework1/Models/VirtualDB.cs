using System.Collections;

namespace Steven_Homework1.Models
{
    public class VirtualDB
    {
        public ArrayList DB = new ArrayList();
        public VirtualDB()
        {
            for (int i = 0; i < 50; i++)
            {
                var newData = new RandomData();
                newData.Id = i + 1;
                DB.Add(newData);
            }
        }
    }
}