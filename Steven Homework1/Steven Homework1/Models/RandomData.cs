using System;
using Steven_Homework1.Controllers;

namespace Steven_Homework1.Models
{
    public class RandomData
    {
        public int Id = 0;
        public String money;
        public String type;
        public String [] typeSelect = {"支出","收入"};
        public String Date;
        private static Random random = new Random();
        private static DateTime start = new DateTime(2018,1,1);
        private int range = (DateTime.Today - start).Days;

        public RandomData()
        {
                Date = start.AddDays(random.Next(range)).ToShortDateString();
                type = typeSelect[random.Next(typeSelect.Length)];
                money = random.Next(1000,3000).ToString();
        }
    }
}