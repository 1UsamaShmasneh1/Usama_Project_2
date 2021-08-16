using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureProject
{
    public class TemperatureManagament
    {
        private string[] cities = { "jaljulia", "kefar sava", "tell aviv" };
        public Temperature[] temperatures = new Temperature[28];
        public int Count { get; set; }
        public void Add(Temperature temperature)
        {
            Random random = new Random();
            temperature.City = cities[random.Next(cities.Length)];
            temperature.Date = Count + 1;
            temperature.Temp = random.Next(24, 40) + random.NextDouble();
            temperatures[Count] = temperature;
            Count++;
        }
        public double this[int date]
        {
            get
            {
                if (date > Count - 1)
                    throw new ArgumentException("");
                return temperatures[date - 1].Temp;
            }
        }
        public double this[string city]
        {
            get
            {
                foreach(Temperature temp in temperatures)
                {
                    if (city == temp.City)
                        return temp.Temp;
                }
                throw new ArgumentException("ther are no temp for that city");
            }
        }
        public bool this[string city, int date]
        {
            get
            {
                if (temperatures[date - 1].City == city && temperatures[date - 1] != null)
                    return true;
                return false;
            }
        }
    }
}
