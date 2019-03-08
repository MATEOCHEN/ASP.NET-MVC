using System;
using Steven_Homework1.Controllers;

namespace Steven_Homework1.Models
{
    public class RandomData
    {
        public int [] Id = new int [50];
        public String [] moneyStack = new String[50];
        public String [] type = new string[50];
        public String [] typeSelect = {"支出","收入"};
        public String [] DateStack = new String[50];
        private Random random = new Random();
        private static DateTime start = new DateTime(2018,1,1);
        private int range = (DateTime.Today - start).Days;

        public RandomData()
        {
            for (var i = 0; i < moneyStack.Length; i++)
            {
                DateStack[i] = start.AddDays(random.Next(range)).ToShortDateString();
                type[i] = typeSelect[random.Next(typeSelect.Length)];
                Id[i] = i + 1;
                moneyStack[i] = random.Next(1000,3000).ToString();
            }
        }
    }
}