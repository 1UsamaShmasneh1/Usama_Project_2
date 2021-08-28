using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    class Lists2
    {
        List<Temperature> tempList = new List<Temperature>();
        public void SortByCity()
        {
            tempList.Sort((x, y) =>
            {                
                return x.City.CompareTo(y.City);
            });
        }
        public void SortByCityThenDate()
        {
            tempList.Sort((x, y) =>
            {
                if (x.City.CompareTo(y.City) == 0)
                {
                    return x.Date.CompareTo(y.Date);
                }
                return x.City.CompareTo(y.City);
            });
        }
        public void SortByTempThenCity()
        {
            tempList.Sort((x, y) =>
            {
                if (x.Temp.CompareTo(y.Temp) == 0)
                {
                    return x.City.CompareTo(y.City);
                }
                return x.Temp.CompareTo(y.Temp) * -1;
            });
        }
        public void SortByHumidityThenTempThenCity()
        {
            tempList.Sort((x, y) =>
            {
                if(x.Humidity.CompareTo(y.Humidity) == 0)
                {
                    if (x.Temp.CompareTo(y.Temp) == 0)
                    {
                        return x.City.CompareTo(y.City);
                    }
                    return x.Temp.CompareTo(y.Temp) * -1;
                }
                return x.Humidity.CompareTo(y.Humidity) * -1;
            });
        }
        public void main()
        {
            tempList.Sort((x, y) =>
            {
                if (x.City.CompareTo(y.City) == 0)
                {
                    if (x.Date.CompareTo(y.Date) == 0)
                    {
                        return x.Temp.CompareTo(y.Temp);
                    }
                    return x.Date.CompareTo(y.Date);
                }
                return x.City.CompareTo(y.City);
            });
        }
    }
    class Temperature //: IComparable<Temperature>
    {
        public string City { get; set; }
        public int Date { get; set; }
        public double Temp { get; set; }
        public double Humidity { get; set; }

        //public int CompareTo(Temperature other)
        //{
        //    if (City.CompareTo(other.City) == 0)
        //    {
        //        if(Date.CompareTo(other.Date) == 0)
        //        {
        //            return Temp.CompareTo(other.Temp);
        //        }
        //        return Date.CompareTo(other.Date);
        //    }
        //    return City.CompareTo(other.City);
        //}
    }
}
