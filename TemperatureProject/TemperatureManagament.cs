using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureProject
{
    class TemperatureManagament
    {
        private string[] cities = { "jaljulia", "kefar sava", "tell aviv" };
        public Temperature[] Temperatures { get; set; } = new Temperature[28];
        public int Count { get; set; }
        public void Add(Temperature temperature)
        {
            Random random = new Random();
            temperature.City = cities[random.Next(cities.Length)];
            temperature.Date = Count + 1;
            temperature.Temp = random.Next(24, 40) + random.NextDouble();
            Temperatures[Count] = temperature;
            Count++;
        }
        public double GetTempByDate(int date)
        {
            if (date > Count - 1)
                throw new ArgumentException("");
            return Temperatures[date - 1].Temp;
        }
        public double GetTempByCity(string city)
        {
            foreach(Temperature temp in Temperatures)
            {
                if (city == temp.City)
                    return temp.Temp;
            }
            throw new ArgumentException("ther are no temp for that city");
        }
        public bool IsTempInCity(string city, int date)
        {
            if (Temperatures[date - 1].City == city && Temperatures[date - 1] != null)
                return true;
            return false;
        }
    }
}
